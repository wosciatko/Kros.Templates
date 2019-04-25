using FluentValidation;

namespace Kros.CqrsTemplate.Application.Commands
{
    /// <summary>
    /// Validator for <see cref="CreateRRREntityNameRRR_Command"/>.
    /// </summary>
    public class CreateRRREntityNameRRR_CommandValidator : AbstractValidator<CreateRRREntityNameRRR_Command>
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        public CreateRRREntityNameRRR_CommandValidator()
        {
        }
    }
}
