namespace  Domain.Entities
{
    public class User
    {
        public Guid UserId { get; init; } 
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? Bio { get; set; } = string.Empty;
    }
}