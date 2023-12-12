using Models;

namespace Notes.Domain.Note
{
    public sealed class Note : BaseEntity
    {
        public Title Name { get; set; }
        public string Content { get; set; }
        public Note(Title title, string content, int id) : base(id)
        {
            Name = title;
            Content = content;
        }
    }
}
