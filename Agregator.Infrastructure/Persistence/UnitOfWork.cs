using Agregator.Domain.Entities;
using Agregator.Infrastructure.Persistence.DataBase;
using Agregator.Infrastructure.Persistence.GenericRepository;

namespace Agregator.Infrastructure.Persistence;

public sealed class UnitOfWork : IDisposable
{
    private readonly ApplicationContext _context;
    private Repository<User> _userRepository = null!;

    private bool _disposed = false;

    public UnitOfWork(ApplicationContext context)
    {
        _context = context;
    }

    public Repository<User> UserRepository
    {
        get
        {
            if (_userRepository == null)
                _userRepository = new Repository<User>(_context);

            return _userRepository;
        }
    }

    private void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

        _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}
