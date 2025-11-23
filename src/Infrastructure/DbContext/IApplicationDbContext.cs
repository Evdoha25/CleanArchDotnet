using Microsoft.EntityFrameworkCore;

public interface IApplicationDbCotext
{
    public DbSet<User> Users { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}