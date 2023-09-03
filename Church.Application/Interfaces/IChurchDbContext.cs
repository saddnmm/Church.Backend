using Church.Domain;
using Microsoft.EntityFrameworkCore;

namespace Church.Application.Interfaces
{
    public interface IChurchDbContext
    {
        DbSet<Tbsystem> Tbsystem { get; set; }

        DbSet<Tbemployee> Tbemployees { get; set; }
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
