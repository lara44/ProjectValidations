
using FluentValidation;

namespace ProjectValidations;

public static class MedianetValidator
{
    public static void ApplyRules(AbstractValidator<PeticionBase> validator)
    {
        validator.RuleFor(x => x.CamposAdicionales)
            .NotNull().WithMessage("Se requieren campos adicionales para Medianet.")
            .Must(dict => dict != null &&
                          dict.ContainsKey("Secuencia") &&
                          !string.IsNullOrWhiteSpace(dict["Secuencia"]?.ToString()))
            .WithMessage("El campo 'Secuencia' es obligatorio para Medianet.");
    }
}
