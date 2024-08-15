using Microsoft.EntityFrameworkCore;

using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; }
        DbSet<Permission> Permissions { get; }

        DbSet<Role> Roles { get; }
        DbSet<UserProfile> UserProfiles { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}