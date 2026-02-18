namespace ProInvoice.CleanArchitectureWebAPI.Domain.Abstraction
{
    public class Result<TEntity> where TEntity : BaseEntity
    {
        // Success With No Data
        public Result(int statusCode)
        {
            StatusCode = statusCode;
            IsNotSuccessful = false;
        }

        // Success
        public Result(int statusCode, TEntity? data)
        {
            StatusCode = statusCode;
            Data = data;
            IsNotSuccessful = false;
        }
        //Failed With One Error
        public Result(int statusCode, string errorCode, string errorMessage)
        {
            StatusCode = statusCode;
            IsNotSuccessful = true;
            Errors = new() { { errorCode, errorMessage } };
        }
        //Failed With Many Errors
        public Result(int statusCode, Dictionary<string, string>? errors)
        {
            IsNotSuccessful = true;
            StatusCode = statusCode;
            Errors = errors;
        }

        public int StatusCode { get; set; }
        public TEntity? Data { get; set; }
        public bool IsNotSuccessful { get; set; }
        public Dictionary<string, string>? Errors { get; set; }

        public static Result<TEntity> Success(int statusCode) => new(statusCode);
        public static Result<TEntity> Success(int statusCode, TEntity? entity) => new(statusCode, entity);
        public static Result<TEntity> Failed(int statusCode, string errorCode, string errorMessage) => new(statusCode, errorCode, errorMessage);
        public static Result<TEntity> Failed(int statusCode, Dictionary<string, string>? errors) => new(statusCode, errors);
    }
}
