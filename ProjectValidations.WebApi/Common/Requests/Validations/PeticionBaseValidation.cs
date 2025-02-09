using FluentValidation;

namespace ProjectValidations;

public class PeticionBaseValidation : AbstractValidator<PeticionBase>
{
    public PeticionBaseValidation()
    {
        RuleFor(x => x.Adquiriente).NotEmpty().WithMessage("El campo Adquiriente es requerido");
        RuleFor(x => x.Proceso).NotEmpty().WithMessage("El campo Proceso es requerido");
        RuleFor(x => x.TotalBase).GreaterThan(0).WithMessage("El campo TotalBase debe ser mayor a 0");
        RuleFor(x => x.totalIva).GreaterThan(0).WithMessage("El campo totalIva debe ser mayor a 0");
        RuleFor(x => x.totalDescuento).GreaterThanOrEqualTo(0).WithMessage("El campo totalDescuento debe ser mayor o igual a 0");
        RuleFor(x => x.Total).GreaterThan(0).WithMessage("El campo Total debe ser mayor a 0");

        When(x => string.Equals(x.Adquiriente, "Medianet", StringComparison.InvariantCultureIgnoreCase), () =>
        {
            MedianetValidator.ApplyRules(this);
        });
    }
}

