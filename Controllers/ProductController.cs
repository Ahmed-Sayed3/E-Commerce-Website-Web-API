namespace E_Commerce_C_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        private AppResponse _Response;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
            _Response = new AppResponse();
        }

        //1- Get All Product  (Done)
        [HttpGet]
        public async Task<IActionResult> GetProductItems()
        {
            List<Product> products = productRepository.GetAll();
            List<ProductDTO> productsDTO = products.Select(products => new ProductDTO
            {
                Id = products.Id,
                Name = products.Name,
                Description = products.Description,
                Category = products.Category,
                SpecialTag = products.SpecialTag,
                Price = products.Price,
                Image = products.Image,
            }).ToList();

            _Response.Result = productsDTO ;
            _Response.StatusCode = HttpStatusCode.OK;
            return Ok(_Response);
        }

        //2- Get Product By Id  (Done)
        [HttpGet("{id:int}",Name = "GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            Product product = productRepository.GetById(id);

            if (id == 0)
            {
                _Response.StatusCode = HttpStatusCode.BadRequest;
                return BadRequest(_Response);
            }
            if (product == null)
            {
                _Response.StatusCode = HttpStatusCode.NotFound;
                return NotFound(_Response);
            }
            _Response.Result = product;
            _Response.StatusCode = HttpStatusCode.OK;
            return Ok(_Response);
        }

        //3- Create Product   (Done)
        [HttpPost]
        public async Task<ActionResult<AppResponse>> AddProduct ([FromForm] AddProductDTO addProductDTO)
        {
            try
            {
                if (ModelState.IsValid ==true)
                {
                    //string fileName = $"{Guid.NewGuid()}{Path.GetExtension(addProductDTO.file.FileName)}";
                    Product productToCreate = new()
                    {
                        Name = addProductDTO.Name,
                        Price = addProductDTO.Price,
                        Category = addProductDTO.Category,
                        SpecialTag = addProductDTO.SpecialTag,
                        Description = addProductDTO.Description,
                        //Image = addProductDTO.file,
                    };
                    productRepository.Insert(productToCreate);
                    productRepository.Save();
                    _Response.Result = productToCreate;
                    _Response.StatusCode = HttpStatusCode.Created;
                    return CreatedAtRoute("GetById", new { id = productToCreate }, _Response);
                }
                else
                {
                    _Response.IsSuccess = false;
                }
            }
            catch (Exception ex)
            {
                _Response.IsSuccess = false;
                _Response.ErrorMessages = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _Response;
        }

        //4- Update Product   (Done)
        [HttpPut]
        public async Task<ActionResult<AppResponse>> UpdateProduct(int id,[FromForm] UpdateProductDTO updateProductDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Product Oldproduct = productRepository.GetById(id);
                    if (Oldproduct == null)
                    {
                        return BadRequest();
                    }

                    Oldproduct.Name = updateProductDTO.Name;
                    Oldproduct.Price = updateProductDTO.Price;
                    Oldproduct.Category = updateProductDTO.Category;
                    Oldproduct.SpecialTag = updateProductDTO.SpecialTag;
                    Oldproduct.Description = updateProductDTO.Description;

                    productRepository.Update(Oldproduct);
                    productRepository.Save();
                    _Response.StatusCode = HttpStatusCode.NoContent;
                    return Ok(_Response);
                }
                else
                {
                    _Response.IsSuccess = false;
                }
            }
            catch (Exception ex)
            {
                _Response.IsSuccess = false;
                _Response.ErrorMessages = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _Response;
        }

        //5- Delete Product (Done)
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<AppResponse>> DeleteProduct(int id)
        {
            try
            {
                    Product productFromDb = productRepository.GetById(id); 
                    if (id == 0)
                    {
                        return BadRequest();
                    }

                    if (productFromDb == null)
                    {
                        return BadRequest();
                    }

                    //int millisecod = 2000;
                    //Thread.Sleep(millisecod);

                    productRepository.Delete(id);
                    productRepository.Save();
                    _Response.StatusCode = HttpStatusCode.NoContent;
                    return Ok(_Response);
            }
            catch (Exception ex)
            {
                _Response.IsSuccess = false;
                _Response.ErrorMessages = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _Response;
        }
    }
}
