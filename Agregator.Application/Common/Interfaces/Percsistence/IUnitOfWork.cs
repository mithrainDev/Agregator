using Agregator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregator.Application.Common.Interfaces.Percsistence
{
    public interface IUnitOfWork
    {
        IRepository<User> UserRepository { get; }
        IRepository<RideAgregator> AgregatorRepository { get; }
        IRepository<Order> OrderRepository { get; }
        void Save();

    }
}
