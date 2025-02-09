using FluentValidation;

namespace ProjectValidations;

public class RedebanValidator : AbstractValidator<Redeban>
{
    public RedebanValidator()
    {
        RuleFor(x => x.Cajero)
            .NotEmpty().WithMessage("El campo 'Cajero' es obligatorio para Redeban.");
    }
}
