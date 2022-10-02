using Agregator.Application.Common.Commands.UserCommands;
using Agregator.Domain.Entities;


namespace Agregator.Application.Common.Interfaces.UserService;

public interface IUserService
{
    Guid AddUser(CreateUserCommand command);
    IEnumerable<User> GetAll();
    void Update(User user);
    User Find(Guid id);
}
