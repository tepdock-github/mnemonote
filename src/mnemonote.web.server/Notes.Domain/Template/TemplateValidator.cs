using Models.Entities;

namespace Notes.Domain.Template
{
    public class TemplateValidator<T> where T : Template
    {
        public ValidationNotifier<Template> Validate(Template? template)
        {
            var notifier = new ValidationNotifier<Template>();

            if (template is null)
                notifier.AddError("Object for template wasn't created");

            if (template?.Type is null)
                notifier.AddError("Type for template wasn't set");

            if (string.IsNullOrEmpty(template?.Name))
                notifier.AddError("Name for template wasn't set");

            return notifier;
        }
    }
}
