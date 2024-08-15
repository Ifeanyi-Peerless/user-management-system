namespace Domain.Common
{
    public class BaseEntity
    {
        public string? CreatedBy { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTimeOffset TimeCreated { get; set; } = DateTimeOffset.Now;
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTimeOffset? LastModifiedTime { get; set; }
        public string? ApprovedBy { get; set; }
        public DateOnly? DateApproved { get; set; }
        public DateTime? TimeApproved { get; set; }
        public bool Status { get; set; }
        public string? HashValue { get; set; }
        public bool DeletedFlag { get; set; }
        public string? DeletedBy { get; set; } = string.Empty;
        public DateOnly? DateDeleted { get; set; }
        public DateTime? TimeDeleted { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}