using Models.Entities;
using Models.ValueObjects;

namespace Projects.Domain.Project
{
    public class Project : BaseEntity
    {
        public Title Name { get; set; }
        public Project(int id, Title title) : base(id)
        {
            Name = title;
        }
    }
}
