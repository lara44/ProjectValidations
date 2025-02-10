
namespace ProjectValidations;

public interface IProveedorCreator
{
    bool PuedeCrear(PeticionBase peticion);
    public IPeticion CrearProveedor(PeticionBase peticion);
}
