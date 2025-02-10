namespace ProjectValidations;

public class PeticionFactory : IPeticionFactory
{
    private readonly IEnumerable<IProveedorCreator> _creadores;
    public PeticionFactory(IEnumerable<IProveedorCreator> creadores)
    {
        _creadores = creadores;
    }
    public IPeticion CrearPeticion(PeticionBase peticion)
    {
        var creador = _creadores.FirstOrDefault(c => c.PuedeCrear(peticion));
        if (creador != null) {
            return creador.CrearProveedor(peticion);
        }
        
        throw new NotSupportedException($"No se encontró un proveedor para la petición con Adquiriente: {peticion.Adquiriente}");
    }
}
