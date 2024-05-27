//namespace E_Commerce_C_.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ShoppingCartCtontroller : ControllerBase
//    {
//       // private readonly IShoppingCartRepository shoppingCartRepository;
//        private readonly ApplicationDbContext _db;
//        private AppResponse _Response;

//        public ShoppingCartCtontroller(/*IShoppingCartRepository shoppingCartRepository,*/ ApplicationDbContext db)
//        {
//            //this.shoppingCartRepository = shoppingCartRepository;
//            _db = db;
//            _Response = new ();
//        }

//        //1-Get Cart Items
//        [HttpGet]
//        public async Task<ActionResult<AppResponse>> GetShoppingCart(string userid)
//        {
//            try
//            {
//                if(string.IsNullOrEmpty(userid))
//                {
//                    _Response.IsSuccess = false;
//                    _Response.StatusCode = HttpStatusCode.BadRequest;
//                    return BadRequest(_Response);
//                }
//                ShoppingCart shoppingCart = _db.ShoppingCarts
//                    .Include(u=>u.cartItems).ThenInclude(u=>u.Products)
//                    .FirstOrDefault(u=>u.UserId==userid);

//                _Response.IsSuccess = true;
//                _Response.StatusCode = HttpStatusCode.OK;
//                return Ok(_Response);
//            }
//            catch (Exception ex)
//            {
//                _Response.IsSuccess = false;
//                _Response.ErrorMessages = new List<string>() { ex.ToString() };
//                _Response.StatusCode = HttpStatusCode.BadRequest;
//            }

//            return _Response;
//        }


//        //2- Add Product To Cart
//        [HttpPost]
//        // One Methood For All 
//        public async Task<ActionResult<AppResponse>> AddOrUpdateItemInCart(string userid , int productItemId, int updateQuantityBy )
//        {
//            // -------------- Business Model --------------
//            // Shopping cart will have one entry per user id, even if a user has many items in cart.
//            // Cart items will have all the items in shopping cart for a user
//            // updatequantityby will have count by with an items quantity needs to be updated
//            // if it is -1 that means we have lower a count if it is 5 it means we have to add 5 count to existing count.
//            // if updatequantityby by is 0, item will be removed

//            // -------------- Scenarios --------------
//            // 1- when a user adds a new item to a new shopping cart for the first time
//            // 2- when a user adds a new item to an existing shopping cart (basically user has other items in cart)
//            // 3- when a user updates an existing item count
//            // 4- when a user removes an existing item
            
//            ShoppingCart shoppingCart = _db.ShoppingCarts.Include(u=>u.cartItems).FirstOrDefault(u => u.UserId==userid);
//            Product product = _db.Products.FirstOrDefault(u=>u.Id==productItemId);

//            // First Scenario
//            if (product == null)
//            {
//                _Response.StatusCode = HttpStatusCode.BadRequest;
//                _Response.IsSuccess = false;
//                return BadRequest();
//            }
//            if (shoppingCart == null && updateQuantityBy>0)
//            {
//                //Create Shopping Cart 
//                ShoppingCart newCart = new() 
//                {
//                    UserId= userid,
//                };
//                _db.ShoppingCarts.Add(newCart);
//                _db.SaveChanges();

//                //Create Cart Items 
//                CartItem newCartItems = new()
//                {
//                    ProductItemId = productItemId,
//                    Quantity = updateQuantityBy,
//                    ShoppingCartId = newCart.Id,  //From The Last Function
//                    //if it wasn't null during the initial insertion, an error would occur //
//                    //as it would attempt to generate a product from the beginning //
//                    //without all necessary data so we put it null.
//                    Products = null 
//                };
//                _db.CartItems.Add(newCartItems);
//                _db.SaveChanges();
//            }

//            // Second Scenario
//            else
//            {
//                //Shopping Cart Is Already Exists
//               CartItem cartItemInCart = shoppingCart.cartItems.FirstOrDefault(u=>u.ProductItemId == productItemId);
               
//                if(cartItemInCart == null)
//                {
//                    //Items Does not Exist In Current Cart 
//                    CartItem newCartItems = new()
//                    {
//                        ProductItemId = productItemId,
//                        Quantity = updateQuantityBy,
//                        ShoppingCartId = shoppingCart.Id,  
//                        Products = null
//                    };
//                    _db.CartItems.Add(newCartItems);
//                    _db.SaveChanges();
//                }
//                else
//                {
//                    //Items Is Already Exists In The Cart And We Have To Update Quantity
//                    int newQuantity = cartItemInCart.Quantity + updateQuantityBy;
//                    if (updateQuantityBy==0 || newQuantity <= 0)
//                    {
//                        //Remove Cart Item From Cart If this The only Ites Then Remove Cart
//                        _db.CartItems.Remove(cartItemInCart);

//                        if(shoppingCart.cartItems.Count()==1) 
//                        {
//                            _db.CartItems.Remove(cartItemInCart);
//                        }
//                        _db.SaveChanges();  
//                    }
//                    else
//                    {
//                        cartItemInCart.Quantity = newQuantity;
//                        _db.SaveChanges();
//                    }
//                }
//            }
//            return _Response;
//        }
//    }
//}
