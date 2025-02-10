namespace ProjectValidations;

public interface IPeticion
{
    public string? Proveedor { get; set; }
    public string? Adquiriente { get; set; }
    public string? Proceso { get; set; }
    public decimal TotalBase { get; set; }
    public decimal totalIva { get; set; }  
    public decimal totalDescuento { get; set; }
    public decimal Total { get; set; }
    public Dictionary<string, object>? CamposAdicionales { get; set; }
}
