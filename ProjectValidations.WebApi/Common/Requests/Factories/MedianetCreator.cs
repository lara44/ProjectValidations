namespace ProjectValidations;

public class MedianetCreator : IProveedorCreator
{
    public bool PuedeCrear(PeticionBase peticion)
    {
        return string.Equals(peticion.Adquiriente, "Medianet", StringComparison.InvariantCultureIgnoreCase);
    }
    public IPeticion CrearProveedor(PeticionBase peticion)
    {
        return Medianet.Create(peticion);
    }
}
