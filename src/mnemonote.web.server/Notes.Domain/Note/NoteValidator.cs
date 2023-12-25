using Models.Entities;

namespace Notes.Domain.Note
{
    public class NoteValidator
    {
        public Validator<Note> PopulateValidator(Note? note)
        {
            var noteValidator = new Validator<Note>()
                .AddErrorIfTrue(note is null, "Object for note wasn't created")
                .AddErrorIfTrue(note?.Name is null, "Title for note wasn't set");

            return noteValidator;
        }
    }
}
