namespace Models.Entities
{
    public class Validator<T>
    {
        private readonly List<OperationResult<T>> _errors = new();
        public bool HasErrors => _errors.Any();

        public List<OperationResult<T>> GetErrors() => _errors;

        public Validator<T> AddErrorIfTrue(bool condition, string error)
        {
            if (condition)
                _errors.Add(new OperationResult<T>(error, Enums.OperationStatus.Error));

            return this;
        }
    }
}
