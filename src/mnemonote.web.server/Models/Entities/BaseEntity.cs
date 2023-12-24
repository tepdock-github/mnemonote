namespace Models.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; private init; }
        protected BaseEntity(int id)
        {
            Id = id;
        }

        public static bool operator ==(BaseEntity? left, BaseEntity? right) =>
            left is not null && right is not null && left.Equals(right);

        public static bool operator !=(BaseEntity? left, BaseEntity? right) =>
            !(left == right);

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;

            if (obj.GetType() != GetType()) return false;

            if (obj is not BaseEntity entity) return false;

            return entity.Id == Id;
        }

        public override int GetHashCode() => Id.GetHashCode();

    }
}
