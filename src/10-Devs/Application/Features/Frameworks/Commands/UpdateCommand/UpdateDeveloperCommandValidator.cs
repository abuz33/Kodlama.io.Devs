using Core.CrossCuttingConcerns.Constant;
using FluentValidation;

namespace Application.Features.Frameworks.Commands.UpdateCommand;

public class UpdateFrameworkCommandValidator : AbstractValidator<UpdateFrameworkCommand>
{
    public UpdateFrameworkCommandValidator ()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("{PropertyName}" + AspectMessages.IsRequired)
            .NotNull();
    }
}
