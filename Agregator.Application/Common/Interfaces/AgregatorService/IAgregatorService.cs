using Agregator.Application.Common.Commands.AgregatorCommands;
using Agregator.Domain.Entities;

namespace Agregator.Application.Common.Interfaces.AgregatorService;

public interface IAgregatorService
{
    Guid AddAgregator(CreateAgregatorCommand command);
    IEnumerable<RideAgregator> GetAll();
    void Update(RideAgregator user);
    RideAgregator Find(Guid id);
}
