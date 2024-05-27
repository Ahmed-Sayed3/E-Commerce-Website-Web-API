namespace E_Commerce_C_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        protected AppResponse _Response;
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _db;

        public PaymentController(IConfiguration configuration, ApplicationDbContext db)
        {
            _configuration = configuration;
            _db = db;
            _Response = new AppResponse();
        }

        //1- Create Payment Intent
        [HttpPost]
        public async Task<ActionResult<AppResponse>> MakePayment(string userid)
        {
            ShoppingCart shoppingCart = _db.ShoppingCarts.Include(u => u.cartItems)
                .ThenInclude(u => u.Products)
                .FirstOrDefault(u => u.UserId == userid);

            if (shoppingCart == null || shoppingCart.cartItems == null || shoppingCart.cartItems.Count() == 0)
            {
                _Response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                _Response.IsSuccess = false;
                return BadRequest();
            }

            #region Create Payment Intent
            StripeConfiguration.ApiKey = _configuration["StripeSettings:SecretKey"];

            shoppingCart.CartTotal = shoppingCart.cartItems.Sum(u => u.Quantity * u.Products.Price);

            PaymentIntentCreateOptions options = new()
            {
                Amount = (int)(shoppingCart.CartTotal * 100),
                Currency = "usd",
                AutomaticPaymentMethods = new PaymentIntentAutomaticPaymentMethodsOptions
                {
                    Enabled = true,
                },
            };
            PaymentIntentService service = new();
            PaymentIntent response = service.Create(options);
            shoppingCart.StripPaymentIntenId = response.Id;
            shoppingCart.ClientSecret = response.ClientSecret;

            #endregion
            _Response.Result = shoppingCart;
            _Response.StatusCode = HttpStatusCode.OK;
            return Ok(_Response);
        }
    }
}
