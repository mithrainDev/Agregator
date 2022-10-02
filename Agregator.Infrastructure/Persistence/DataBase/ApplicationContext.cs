using Agregator.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Agregator.Infrastructure.Persistence.DataBase;

public sealed class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
    {

    }

    public DbSet<User> Users { get; set; }
    public DbSet<RideAgregator> RideAgregators { get; set; }
}
