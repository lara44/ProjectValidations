
using Microsoft.AspNetCore.Mvc;

namespace ProjectValidations;

[ApiController]
[Route("api/[controller]")]
public class PeticionController : ControllerBase
{
    private readonly IPeticionFactory _peticionFactory;
    private readonly IOrquestadorService _orquestadorService;
    public PeticionController(
        IOrquestadorService orquestadorService,
        IPeticionFactory peticionFactory
    )
    {
        _peticionFactory = peticionFactory;
        _orquestadorService = orquestadorService;
    }

    [HttpPost("peticion")]
    public IActionResult peticion(
        [FromBody] PeticionBase peticionBase)
    {
        var peticion = _peticionFactory.CrearPeticion(peticionBase);

        _orquestadorService.procesarPeticion(peticion);
        return Ok( new { message = "Peticion procesada correctamente" });
    }
}
