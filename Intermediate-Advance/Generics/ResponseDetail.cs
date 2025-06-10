namespace Generics
{
    public class ResponseDetail<T>
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; } = string.Empty;
        public T? Data { get; set; }
        //public string Error { get; set; } = string.Empty;
        public int StatusCode { get; set; }


        public ResponseDetail<T> Failed(string message = "Operation Failed", int statusCode = 500)
        {
            var response = new ResponseDetail<T>
            {
                IsSuccessful = false,
                Message = message,
                StatusCode = statusCode
            };

            return response;
        }

        public ResponseDetail<T> Success(T data, string message = "Operation successful", int statusCode = 200)
        {
            var response = new ResponseDetail<T>
            {
                IsSuccessful = true,
                Message = message,
                Data = data,
                StatusCode = statusCode
            };
            return response;
        }

        public ResponseDetail<T> Success(string message = "Operation successful", int statusCode = 200)
        {
            var response = new ResponseDetail<T>
            {
                IsSuccessful = true,
                Message = message,
                StatusCode = statusCode
            };
            return response;
        }
    }
}
