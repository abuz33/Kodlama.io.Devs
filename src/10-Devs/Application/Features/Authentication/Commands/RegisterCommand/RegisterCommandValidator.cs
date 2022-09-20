using Core.CrossCuttingConcerns.Constant;
using FluentValidation;

namespace Application.Features.Authentication.Commands.RegisterCommand;

//-----------------------------------------------------------------------------------------
/// <summary>
/// RegisterCommandValidator class
/// </summary>
public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    //-----------------------------------------------------------------------------------------
    /// <summary>
    /// The Constructor
    /// </summary>
    public RegisterCommandValidator ()
    {
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("{PropertyName}" + AspectMessages.IsRequired)
            .EmailAddress().WithMessage(AspectMessages.WrongEmailFormat);
        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("{PropertyName}" + AspectMessages.IsRequired);
        RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage("{PropertyName}" + AspectMessages.IsRequired);
        RuleFor(x => x.LastName)
            .NotEmpty().WithMessage("{PropertyName}" + AspectMessages.IsRequired);
    }
}
