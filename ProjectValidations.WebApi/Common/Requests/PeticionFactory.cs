namespace ProjectValidations;

public static class PeticionFactory
{
    public static IPeticion CrearPeticion(PeticionBase peticion)
    {
        return peticion.Adquiriente switch
        {
            "Medianet" => Medianet.Create(peticion),
            _ => new PeticionBase()
        };
    }
}
