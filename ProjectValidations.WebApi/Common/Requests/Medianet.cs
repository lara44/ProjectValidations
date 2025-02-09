namespace ProjectValidations;

public class Medianet : PeticionBase
{
    public string? Secuencia { get; set; }
    
    // Constructor que recibe los 6 parámetros y los pasa al constructor base
    private Medianet(string? adquiriente, string? proceso, decimal totalBase, decimal totalIva, decimal totalDescuento, decimal total)
        : base(adquiriente, proceso, totalBase, totalIva, totalDescuento, total)
    {
    }

    public static Medianet Create(PeticionBase peticion)
    {
        var medianet = new Medianet(
            peticion.Adquiriente,
            peticion.Proceso,
            peticion.TotalBase,
            peticion.totalIva,
            peticion.totalDescuento,
            peticion.Total
        );

        medianet.Secuencia = peticion.CamposAdicionales?["Secuencia"]?.ToString();
        return medianet;
    }
}
