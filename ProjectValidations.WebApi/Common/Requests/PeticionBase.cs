namespace ProjectValidations;

public class PeticionBase : IPeticion
{
    public string? Proveedor { get; set; }
    public string? Adquiriente { get; set; }
    public string? Proceso { get; set; }
    public decimal TotalBase { get; set; }
    public decimal totalIva { get; set; }  
    public decimal totalDescuento { get; set; }
    public decimal Total { get; set; }
    public Dictionary<string, object>? CamposAdicionales { get; set; }

    public PeticionBase(
        string? proveedor,
        string? adquiriente,
        string? proceso,
        decimal totalBase, 
        decimal totalIva, 
        decimal totalDescuento, 
        decimal total)
    {
        Proveedor = proveedor;
        Adquiriente = adquiriente;
        Proceso = proceso;
        TotalBase = totalBase;
        this.totalIva = totalIva;
        this.totalDescuento = totalDescuento;
        Total = total;
    }
    
    public PeticionBase() { }
}
