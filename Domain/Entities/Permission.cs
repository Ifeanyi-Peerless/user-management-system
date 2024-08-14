namespace Domain.Entities
{
    public class Permission
    {
        public Guid PermissionId { get; init; } 
        public string Name {get; set; } = string.Empty;
    }
}