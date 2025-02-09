namespace ProjectValidations;

public static class PeticionMapper
{
    public static IPeticion MapToPeticion(PeticionBase peticion)
    {
        return peticion.Adquiriente switch
        {
            "Medianet" => Medianet.Create(peticion),
            _ => new PeticionBase()
        };
    }
}
