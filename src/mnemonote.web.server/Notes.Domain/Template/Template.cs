using Models;

namespace Notes.Domain.Template
{
    public class Template : BaseEntity
    {
        public Template (Type type, string name, int id) : base(id)
        {
            Type = type;
            Name = name;
        }

        public string Name { get; set; }
        public Type Type { get; set; }
    }
}
