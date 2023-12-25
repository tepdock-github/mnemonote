using Models.Entities;

namespace Notes.Domain.Template
{
    public class Template : BaseEntity
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public Template (Type type, string name, int id) : base(id)
        {
            Type = type;
            Name = name;
        }
    }
}
