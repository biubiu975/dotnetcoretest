using Demo2.Models.Requst;

namespace Demo2.Models.Requst
{
    public class ApiResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public static ApiResponse Success(string message, object data = null)
        {
            var result = new ApiResponse
            {
                Code = ActionCode.Success,
                Message = message
            };

            if (null != data)
            {
                result.Data = data;
            }

            return result;
        }
        
        public static ApiResponse Fail(string message, object data = null)
        {
            var result = new ApiResponse
            {
                Code = ActionCode.Failure,
                Message = message
            };

            if (null != data)
            {
                result.Data = data;
            }

            return result;
        }
    }
}