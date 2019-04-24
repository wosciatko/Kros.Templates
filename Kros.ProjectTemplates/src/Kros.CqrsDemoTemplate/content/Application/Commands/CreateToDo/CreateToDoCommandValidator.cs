using FluentValidation;

namespace Kros.CqrsDemoTemplate.Application.Commands
{
    /// <summary>
    /// Validator for <see cref="CreateToDoCommand"/>.
    /// </summary>
    public class CreateToDoCommandValidator : AbstractValidator<CreateToDoCommand>
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        public CreateToDoCommandValidator()
        {
            RuleFor(x => x.Description).DescriptionValidation();
            RuleFor(x => x.Name).NameValidation();
        }
    }
}
