using Core.CrossCuttingConcerns.Constant;
using FluentValidation;

namespace Application.Features.Developers.Commands.DeleteCommand;

public class DeleteFrameworkCommandValidator : AbstractValidator<DeleteDeveloperCommand>
{
    public DeleteFrameworkCommandValidator ()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("{PropertyName}" + AspectMessages.IsRequired)
            .NotNull();
        RuleFor(p => p.isSoftDelete)
            .NotEmpty().WithMessage("{PropertyName}" + AspectMessages.IsRequired)
            .NotNull();
    }
}
