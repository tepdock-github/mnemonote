using Models.Entities;
using Models.ValueObjects;

namespace Notes.Domain.Note
{
    public class Note : BaseEntity
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
