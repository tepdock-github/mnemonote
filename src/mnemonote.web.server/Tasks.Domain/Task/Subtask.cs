namespace Tasks.Domain.Task
{
    public sealed class Subtask : Task
    {
        public int ParentTaskId { get; set; }
    }
}
