namespace E_Commerce_C_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private AppResponse _Response;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private string SecretKey;


        public AccountController(ApplicationDbContext db, IConfiguration configuration,
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            SecretKey = configuration.GetValue<string>("ApiSetting:Secret");
            _Response = new AppResponse();
            _userManager = userManager;
            _roleManager = roleManager;
        }

        //1-Registration
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationDTO model)
        {
            ApplicationUser userFromDb = _db.ApplicationUsers
                .FirstOrDefault(u => u.UserName.ToLower() == model.UserName.ToLower());
            //ApplicationUser emailFromdb = _db.ApplicationUsers
            //    .FirstOrDefault(e => e.Email.ToLower() == model.Email.ToLower());

            if (userFromDb != null)
            {
                _Response.StatusCode = HttpStatusCode.BadRequest;
                _Response.IsSuccess = false;
                _Response.ErrorMessages.Add("Username already exists");
                return BadRequest(_Response);
            }
            //if (emailFromdb != null)
            //{
            //    _Response.StatusCode = HttpStatusCode.BadRequest;
            //    _Response.IsSuccess = false;
            //    _Response.ErrorMessages.Add("This E-mail Is Already Exists");
            //    return BadRequest();
            //}

            ApplicationUser newUser = new()
            {
                UserName = model.UserName,
                Email = model.UserName,
                NormalizedEmail = model.UserName.ToUpper(),
                Name = model.Name
            };

            try
            {
                var result = await _userManager.CreateAsync(newUser, model.Password);
                if (result.Succeeded)
                {
                    if (!_roleManager.RoleExistsAsync(SD.Role_Admin).GetAwaiter().GetResult())
                    {
                        //create roles in database
                        await _roleManager.CreateAsync(new IdentityRole(SD.Role_Admin));
                        await _roleManager.CreateAsync(new IdentityRole(SD.Role_Customer));
                    }
                    if (model.Role.ToLower() == SD.Role_Admin)
                    {
                        await _userManager.AddToRoleAsync(newUser, SD.Role_Admin);
                    }
                    else
                    {
                        await _userManager.AddToRoleAsync(newUser, SD.Role_Customer);
                    }

                    _Response.StatusCode = HttpStatusCode.OK;
                    _Response.IsSuccess = true;
                    return Ok(_Response);
                }
            }
            catch (Exception)
            {

            }
            _Response.StatusCode = HttpStatusCode.BadRequest;
            _Response.IsSuccess = false;
            _Response.ErrorMessages.Add("Error while registering");
            return BadRequest(_Response);

        }

        //2-Login
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO model)
        {
            ApplicationUser userFromdb = _db.ApplicationUsers
                .FirstOrDefault(u => u.UserName.ToLower() == model.UserName.ToLower());

            bool isValid = await _userManager.CheckPasswordAsync(userFromdb, model.Password);

            if (isValid ==false) 
            {
                _Response.Result = new LoginResponseDTO();
                _Response.StatusCode=HttpStatusCode.BadRequest;
                _Response.IsSuccess = false;
                _Response.ErrorMessages.Add("Username Or Password Is Incorrect");
                return BadRequest(_Response);
            }

            // Else If The Password Is Correct We Have To Generate JWT Token Right Now In Response .
            //Token Generated
            var roles = await _userManager.GetRolesAsync(userFromdb);
            JwtSecurityTokenHandler tokenHandler = new ();
            byte[] key = Encoding.UTF8.GetBytes(SecretKey);

            SecurityTokenDescriptor tokenDescriptor = new()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("FullName", userFromdb.Name),
                    new Claim("ID", userFromdb.Id.ToString()),
                    new Claim(ClaimTypes.Email, userFromdb.UserName.ToString()),
                    new Claim(ClaimTypes.Role, roles.FirstOrDefault()),
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256),
            };

            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

            LoginResponseDTO loginResponse = new()
            {
                Email = userFromdb.Email,
                Token = tokenHandler.WriteToken(token),
            };

            if (loginResponse.Email == null || string.IsNullOrEmpty(loginResponse.Token))
            {
                _Response.StatusCode = HttpStatusCode.BadRequest;
                _Response.IsSuccess = false;
                _Response.ErrorMessages.Add("Username Or Password Is Incorrect");
                return BadRequest(_Response);
            }

            _Response.StatusCode = HttpStatusCode.OK;
            _Response.IsSuccess = true;
            _Response.Result = loginResponse;
            return BadRequest(_Response);
        }
    }
}
