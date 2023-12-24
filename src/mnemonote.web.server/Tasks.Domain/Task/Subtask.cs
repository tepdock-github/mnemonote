using Models.ValueObjects;

namespace Tasks.Domain.Task
{
    public sealed class Subtask : Task
    {
        public new Title Name { get; set; }
        public int ParentTaskId { get; private init; }
        public Subtask(int id, Title title, int parentId, Priority priority, int? projectId)
            : base(id, title, priority, projectId)
        {
            Name = title;
            ParentTaskId = parentId;
        }
    }
}
