using Models.Entities;
using Models.ValueObjects;

namespace Tasks.Domain.Task
{
    public class Task : BaseEntity
    {
        public Title Name { get; set; }
        public Priority Priority { get; set; }
        public int? ProjectId { get; set; }
        public Task(int id, Title title, Priority priority, int? projectId) : base(id)
        {
            Name = title;
            Priority = priority;
            ProjectId = projectId;
        }
    }
}
