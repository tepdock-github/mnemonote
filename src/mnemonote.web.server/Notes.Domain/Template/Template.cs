using Models;

namespace Notes.Domain.Template
{
    public class Template : BaseEntity
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public int? ProjectId { get; set; }
        public Template (Type type, string name, int id, int? projectId) : base(id)
        {
            Type = type;
            Name = name;
            ProjectId = projectId;
        }
    }
}
