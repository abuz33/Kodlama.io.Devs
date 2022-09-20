using Core.CrossCuttingConcerns.Constant;
using FluentValidation;

namespace Application.Features.Authentication.Commands.LoginCommand;

internal class RefreshTokenLoginCommandValidator : AbstractValidator<RefreshTokenLoginCommand>
{
    public RefreshTokenLoginCommandValidator ()
    {
        RuleFor(x => x.AccessToken)
            .NotEmpty().WithMessage("{PropertyName}" + AspectMessages.IsRequired);
        RuleFor(x => x.RefreshToken)
            .NotEmpty().WithMessage("{PropertyName}" + AspectMessages.IsRequired);
    }
}
