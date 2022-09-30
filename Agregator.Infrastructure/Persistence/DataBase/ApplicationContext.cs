using Microsoft.EntityFrameworkCore;

namespace Agregator.Infrastructure.Persistence.DataBase;

public sealed class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
    {

    }
}
