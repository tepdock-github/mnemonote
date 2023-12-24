namespace Models.ValueObjects
{
    public abstract class ValueObject
    {
        public static bool operator ==(ValueObject? left, ValueObject? right) =>
            left is not null && right is not null && left.Equals(right);

        public static bool operator !=(ValueObject? left, ValueObject? right) =>
            !(left == right);
        protected abstract IEnumerable<object> GetEqualityComponents();
        public override bool Equals(object? obj)
        {
            if (obj is null) return false;

            if (obj.GetType() != GetType()) return false;

            var other = (ValueObject)obj;

            return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
        }

        public override int GetHashCode() =>
            GetEqualityComponents()
            .Select(x => x is not null ? x.GetHashCode() : 0)
            .Aggregate((x, y) => x ^ y);
    }
}
