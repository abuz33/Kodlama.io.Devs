using Core.CrossCuttingConcerns.Constant;
using FluentValidation;

namespace Application.Features.Frameworks.Commands.CreateCommand;

public class CreateFrameworkCommandValidator : AbstractValidator<CreateFrameworkCommand>
{
    public CreateFrameworkCommandValidator ()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName}" + AspectMessages.IsRequired)
            .NotNull()
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
    }
}
