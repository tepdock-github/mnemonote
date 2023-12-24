using Models.Entities;

namespace Notes.Domain.Note
{
    public class NoteValidator<T> where T : Note
    {
        public ValidationNotifier<Note> Validate(Note? note)
        {
            var notifier = new ValidationNotifier<Note>();

            if (note is null)
                notifier.AddError("Object for note wasn't created");

            if (note?.Name is null)
                notifier.AddError("Title for note wasn't set");

            return notifier;
        }
    }
}
