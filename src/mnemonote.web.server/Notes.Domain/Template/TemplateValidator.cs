using Models.Entities;

namespace Notes.Domain.Template
{
    public class TemplateValidator<T> where T : Template
    {
        public Validator<Template> PopulateValidator(Template? template)
        {
            var templateValidator = new Validator<Template>()
                .AddErrorIfTrue(template is null, "Object for template wasn't created")
                .AddErrorIfTrue(template?.Type is null, "Type for template wasn't set")
                .AddErrorIfTrue(string.IsNullOrEmpty(template?.Name), "Name for template wasn't set");

            return templateValidator;
        }
    }
}
