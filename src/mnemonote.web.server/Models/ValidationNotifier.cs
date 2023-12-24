namespace Models.Entities
{
    public class ValidationNotifier<T>
    {
        public readonly List<OperationResult<T>> Errors = new();
        public bool HasErrors => Errors.Any();

        public void AddError(string error)
        {
            Errors.Add(new OperationResult<T>(error, Enums.OperationStatus.Error));
        }
    }
}
