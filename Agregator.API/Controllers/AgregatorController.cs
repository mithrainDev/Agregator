using Agregator.Application.Common.Commands.AgregatorCommands;
using Agregator.Application.Common.Interfaces.AgregatorService;
using Agregator.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Agregator.API.Controllers;

[Route("Agregator")]
public class AgregatorController : BaseController
{
    public readonly IAgregatorService _agregatorService;

    public AgregatorController(IAgregatorService agregatorService)
    {
        _agregatorService = agregatorService;
    }

    [HttpPost("AddAgregator")]
    public IActionResult AddAgregator(CreateAgregatorCommand command)
    {
        var result = _agregatorService.AddAgregator(command);
        if (result != Guid.Empty)
        {
            return Ok(result);
        }
        return Problem(title: "Unable to create agregator");
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        return Ok(_agregatorService.GetAll());
    }

    [HttpPut("Update")]
    public IActionResult Update(RideAgregator agregator)
    {
        _agregatorService.Update(agregator);

        return Ok();
    }

    [HttpGet("GetById/{id}")]
    public IActionResult GetById(Guid id)
    {
        var agregator = _agregatorService.Find(id);
        if (agregator != null)
        {
            return Ok(agregator);
        }
        return Problem(title: "Unable to find agregator");
    }
}
