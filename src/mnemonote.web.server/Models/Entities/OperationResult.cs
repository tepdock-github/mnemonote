using Models.Enums;

namespace Models.Entities
{
    public class OperationResult<T>
    {
        public string? Message { get; set; }
        public T? Data { get; set; }
        public OperationStatus Status {get; set; }

        public OperationResult(string message, OperationStatus status, T? data)
        {
            Message = message;
            Status = status;
            Data = data;
        }

        public OperationResult(string message, OperationStatus status) 
        {
            Message = message;
            Status = status;
        }

        public OperationResult(T data, OperationStatus status)
        {
            Status = status;
            Data = data;
        }
    }
}
