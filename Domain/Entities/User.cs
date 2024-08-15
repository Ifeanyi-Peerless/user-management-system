using Domain.Common;

namespace  Domain.Entities
{
    public class User : BaseEntity
    {
        public Guid UserId { get; init; } 
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public ICollection<Role> Roles { get; set; } = [];
        public UserProfile Profile { get; set; } = default!;
    }
}