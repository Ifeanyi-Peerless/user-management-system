namespace Domain.Entities
{
    public class Role
    {
        public Guid RoleId { get; init; }
        public string Name { get; set; } = string.Empty;
        public List<Permission> Permissions { get; set; } = new();
    }
}