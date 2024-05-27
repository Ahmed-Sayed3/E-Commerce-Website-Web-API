namespace E_Commerce_C_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private AppResponse _Response;
        public OrderController(ApplicationDbContext db)
        {
            _db = db;
            _Response = new AppResponse();
        }


        //1- Get All Orders By User Id
        [HttpGet]
        public async Task<ActionResult<AppResponse>> GetOrders(String? userId)
        {
            try
            {
                var OrderHeader = _db.OrderHeaders.Include(u => u.OrderDetails).ThenInclude(u => u.Product).OrderByDescending(u => u.OrderHeaderId);
                if (!string.IsNullOrEmpty(userId))
                {
                    _Response.Result = OrderHeader.Where(u => u.ApplicationUserId == userId);
                }
                else
                {
                    _Response.Result = OrderHeader;
                }
                _Response.StatusCode = HttpStatusCode.OK;
                return Ok(_Response);
            }
            catch (Exception ex)
            {
                _Response.IsSuccess = false;
                _Response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _Response;
        }

        //2- Get Orders By Ordder Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<AppResponse>> GetOrders(int id)
        {
            try
            {
                if (id == 0)
                {
                    _Response.StatusCode=HttpStatusCode.BadRequest;
                    return BadRequest(_Response);   
                }

                var OrderHeader = _db.OrderHeaders.Include(u => u.OrderDetails).ThenInclude(u => u.Product).Where(u => u.OrderHeaderId==id);
                if (OrderHeader == null)
                {
                    _Response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_Response);
                }

                _Response.Result = OrderHeader;
                _Response.StatusCode = HttpStatusCode.OK;
                return Ok(_Response);
            }
            catch (Exception ex)
            {
                _Response.IsSuccess = false;
                _Response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _Response;
        }

        //3- Create Order 
        [HttpPost]
        public async Task<ActionResult<AppResponse>> CreateOrder([FromBody] OrderHeaderCreateDTO orderHeaderDTO)
        {
            try
            {
                OrderHeader order = new()
                {
                    ApplicationUserId = orderHeaderDTO.ApplicationUserId,
                    PickupEmail = orderHeaderDTO.PickupEmail,
                    PickupName = orderHeaderDTO.PickupName,
                    PickupPhoneNumber = orderHeaderDTO.PickupPhoneNumber,
                    OrderTotal = orderHeaderDTO.OrderTotal,
                    OrderDate = DateTime.Now,
                    StripePaymentIntentID = orderHeaderDTO.StripePaymentIntentID,
                    TotalItems = orderHeaderDTO.TotalItems,
                    Status = String.IsNullOrEmpty(orderHeaderDTO.Status) ? SD.status_pending : orderHeaderDTO.Status,
                };

                if (ModelState.IsValid)
                {
                    _db.OrderHeaders.Add(order);
                    _db.SaveChanges();
                    foreach( var orderDetailDTO in orderHeaderDTO.OrderDetailsDTO)
                    {
                        OrderDetails orderDetails = new()
                        {
                            OrderHeaderId = order.OrderHeaderId,
                            ItemName = orderDetailDTO.ItemName,
                            ProductId = orderDetailDTO.ProductId,
                            Price = orderDetailDTO.Price,
                            Quantity = orderDetailDTO.Quantity,
                        };
                        _db.orderDetails.Add(orderDetails);
                    }
                    _db.SaveChanges();
                    _Response.Result = true;
                    order.OrderDetails = null;
                    _Response.StatusCode = HttpStatusCode.Created;
                    return Ok(_Response);
                }
            }
            catch (Exception ex)
            {
                _Response.IsSuccess = false;
                _Response.ErrorMessages = new List<string> { ex.ToString() }; 
            }
            return _Response;
        }

        //4- Update Order By order Id 
        [HttpPut("{id:int}")]
        public async Task<ActionResult<AppResponse>> UpdateOrderHeader (int id , [FromBody] OrderHeaderUpdateDTO orderHeaderUpdateDTO)
        {
            try
            {
                if (orderHeaderUpdateDTO == null || id != orderHeaderUpdateDTO.OrderHeaderId)
                {
                    _Response.IsSuccess=false;
                    _Response.StatusCode=HttpStatusCode.BadRequest;
                    return BadRequest();
                }
                OrderHeader OrderFromDb = _db.OrderHeaders.FirstOrDefault(u => u.OrderHeaderId == id);

                if (OrderFromDb == null)
                {
                    _Response.IsSuccess = false;
                    _Response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest();
                }
                
                if(!string.IsNullOrEmpty(orderHeaderUpdateDTO.PickupName))
                {
                    OrderFromDb.PickupName = orderHeaderUpdateDTO.PickupName;
                }

                if (!string.IsNullOrEmpty(orderHeaderUpdateDTO.PickupPhoneNumber))
                {
                    OrderFromDb.PickupPhoneNumber = orderHeaderUpdateDTO.PickupPhoneNumber;
                }

                if (!string.IsNullOrEmpty(orderHeaderUpdateDTO.PickupEmail))
                {
                    OrderFromDb.PickupEmail = orderHeaderUpdateDTO.PickupEmail;
                }

                if (!string.IsNullOrEmpty(orderHeaderUpdateDTO.Status))
                {
                    OrderFromDb.Status = orderHeaderUpdateDTO.Status;
                }

                if (!string.IsNullOrEmpty(orderHeaderUpdateDTO.StripePaymentIntentID))
                {
                    OrderFromDb.StripePaymentIntentID = orderHeaderUpdateDTO.StripePaymentIntentID;
                }

                _db.SaveChanges();
                _Response.StatusCode = HttpStatusCode.NoContent;
                _Response.IsSuccess = true;
                return Ok(_Response);
            }
            catch (Exception ex)
            {
                _Response.IsSuccess = false;
                _Response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _Response;
        }
    }
}
