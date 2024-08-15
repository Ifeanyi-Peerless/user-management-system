using Domain.Common;

namespace Domain.Entities
{
    public class Permission : BaseEntity
    {
        public Guid PermissionId { get; init; } 
        public string Name {get; set; } = string.Empty;
        public ICollection<Role> Roles { get; set; } = [];
    }
}