using Agregator.Infrastructure.Persistence;
using Microsoft.AspNetCore.Components;

namespace Agregator.API.Controllers;

[Route("Users")]
public class UsersController : BaseController
{
    private readonly UnitOfWork _unitOfWork;

    public UsersController(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
}
