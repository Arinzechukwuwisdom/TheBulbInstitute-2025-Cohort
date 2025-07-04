namespace TodoList.Utils
{
    public class ResponseModel<T>
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }
        public string? Error { get; set; }
        public int StatusCode { get; set; }


        public static ResponseModel<T> Success(T data, string message = "Operation completed successfully", int statusCode = 200)
        {
            var response = new ResponseModel<T>
            {
                IsSuccess = true,
                Message = message,
                Data = data,
                StatusCode = statusCode
            };
            return response;
        }

        public static ResponseModel<T> Failed(string error = "Bad Request", string message = "operation was unsuccessful", int statusCode = 400)
        {
            var response = new ResponseModel<T>
            {
                IsSuccess = false,
                Message = message,
                Error = error,
                StatusCode = statusCode
            };
            return response;
        }
    }
}
