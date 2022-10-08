using Agregator.Application.Common.Interfaces.Percsistence;
using Agregator.Application.Contracts;

namespace Agregator.Application.Services;

internal class AgregatorService : IAgregatorService
{
    private readonly IUnitOfWork _unitOfWork;

    public AgregatorService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;

    }

}
