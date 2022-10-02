using Agregator.Application.Common.Commands.UserCommands;
using Agregator.Application.Common.Interfaces.UserService;
using Agregator.Domain.Entities;
using Agregator.Infrastructure.Persistence;

namespace Agregator.Infrastructure.Common.UserService;

public sealed class UserService : IUserService
{
    private readonly UnitOfWork _unitOfWork;

    public UserService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Guid AddUser(CreateUserCommand command)
    {
        var user = new User()
        {
            Email = command.Email,
            Name = command.Name,
            Phone = command.Phone,
            Id = Guid.NewGuid(),
        };


        try
        {
            _unitOfWork.UserRepository.Add(user);
            _unitOfWork.Save();
        }
        catch (Exception)
        {

            throw;
        }

        return user.Id;
    }

    public IEnumerable<User> GetAll()
    {
        return _unitOfWork.UserRepository.GetAll();
    }

    public void Update(User user)
    {
        try
        {
            _unitOfWork.UserRepository.Update(user);
            _unitOfWork.Save();
        }
        catch (Exception)
        {

            throw;
        }
    }

    public User Find(Guid id)
    {
        return _unitOfWork.UserRepository.Find(id);
    }
}
