using Domain.Common;

namespace  Domain.Entities
{
    public class UserProfile : BaseEntity
    {
        public Guid UserProfileId { get; init; } 
        public Guid UserId { get; set; } 
        public List<string> Hobbies { get; set; } = default!;
        public string Occupation { get; set; } = default!;
        public string Nationality { get; set; } = default!;
        public string Bio { get; set; } = default!;
        public User User { get; set; } = default!;
    }
}