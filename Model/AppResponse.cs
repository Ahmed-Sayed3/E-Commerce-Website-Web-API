namespace E_Commerce_C_.Model
{
    public class AppResponse
    {
        public AppResponse() 
        {
            ErrorMessages = new List<string>();
        }
        public HttpStatusCode StatusCode { get; set; }  
        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }
    }
}
