using Agregator.Application.Common.Commands.AgregatorCommands;
using Agregator.Application.Common.Interfaces.AgregatorService;
using Agregator.Domain.Entities;
using Agregator.Infrastructure.Persistence;

namespace Agregator.Infrastructure.Common.AgregatorService;

public sealed class AgregatorService : IAgregatorService
{
    private readonly UnitOfWork _unitOfWork;

    public AgregatorService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Guid AddAgregator(CreateAgregatorCommand command)
    {
        var agregator = new RideAgregator()
        {
            Title = command.Title,
            TaxNumber = command.TaxNumber,
            Id = Guid.NewGuid(),
        };

        try
        {
            _unitOfWork.AgregatorRepository.Add(agregator);
            _unitOfWork.Save();
        }
        catch (Exception)
        {

            throw;
        }

        return agregator.Id;
    }

    public RideAgregator Find(Guid id)
    {
        return _unitOfWork.AgregatorRepository.Find(id);
    }

    public IEnumerable<RideAgregator> GetAll()
    {
        return _unitOfWork.AgregatorRepository.GetAll();
    }

    public void Update(RideAgregator rideAgregator)
    {
        try
        {
            _unitOfWork.AgregatorRepository.Update(rideAgregator);
            _unitOfWork.Save();
        }
        catch (Exception)
        {

            throw;
        }
    }
}
