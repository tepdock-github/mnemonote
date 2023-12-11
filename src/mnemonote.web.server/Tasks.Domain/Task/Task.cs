using Models;

namespace Tasks.Domain.Task
{
    public class Task : BaseEntity
    {
        public Title Title { get; set; }
        public Priority Priority { get; set; }
    }
}
