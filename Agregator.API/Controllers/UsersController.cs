using Agregator.Application.Common.Commands.UserCommands;
using Agregator.Application.Common.Interfaces.UserService;
using Agregator.Domain.Entities;
using Agregator.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Agregator.API.Controllers;

[Route("Users")]
public class UsersController : BaseController
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("AddUser")]
    public IActionResult AddUser(CreateUserCommand command)
    {
        var result = _userService.AddUser(command);
        if (result != Guid.Empty)
        {
            return Ok(result);
        }
        return Problem(title: "Unable to create user");
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        return Ok(_userService.GetAll());
    }

    [HttpPut("Update")]
    public IActionResult Update(User user)
    {
        _userService.Update(user);

        return Ok();
    }

    [HttpGet("GetById/{id}")]
    public IActionResult GetById(Guid id)
    {
        var user = _userService.Find(id);
        if (user != null)
        {
            return Ok(user);
        }
        return Problem(title: "Unanle to find user");
    }
}
