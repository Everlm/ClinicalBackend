using FluentValidation;

namespace Clinical.Application.UseCases.UseCases.Analysis.Commands.CreateCommand
{
    public class CreateAnalysisValidator : AbstractValidator<CreateAnalysisCommand>
    {
        public CreateAnalysisValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("No null")
                .NotEmpty().WithMessage("No empty");
        }
    }
}
