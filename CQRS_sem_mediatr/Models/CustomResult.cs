namespace CQRS_sem_mediatr.Models
{
    public class CustomResult<T>
    {
        public CustomResult(
            bool isSuccess = true,
            string errorMessage = default,
            T? data = default)
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
            Data = data;
        }

        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public T? Data { get; set; }
    }
}
