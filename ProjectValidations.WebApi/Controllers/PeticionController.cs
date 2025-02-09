
using FluentValidation;
using Microsoft.AspNetCore.Mvc;


namespace ProjectValidations;

[ApiController]
[Route("api/[controller]")]
public class PeticionController : ControllerBase
{
    private readonly IOrquestadorService _orquestadorService;
    public PeticionController(IOrquestadorService orquestadorService)
    {
        _orquestadorService = orquestadorService;
    }

    [HttpPost("peticion")]
    public IActionResult peticion(
        [FromBody] PeticionBase peticionBase)
    {
        var peticion = PeticionFactory.CrearPeticion(peticionBase);

        _orquestadorService.procesarPeticion(peticion);
        return Ok( new { message = "Peticion procesada correctamente" });
    }
}
