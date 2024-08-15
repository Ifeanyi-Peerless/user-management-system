using Domain.Common;

namespace Domain.Entities
{
    public class Role : BaseEntity
    {
        public Guid RoleId { get; init; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Permission> Permissions { get; set; } = [];
        public ICollection<User> Users { get; set; } = [];
    }
}