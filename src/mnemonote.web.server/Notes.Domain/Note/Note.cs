using Models;

namespace Notes.Domain.Note
{
    public sealed class Note : BaseEntity
    {
        public Note(Title title, int id) : base(id)
        {
            Title = title;
        }

        public Title Title { get; set; }
    }
}
