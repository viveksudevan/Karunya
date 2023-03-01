namespace MyFirstRestAPI.Models
{
    public class BaseAuditableEnitiy
    {
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

    }
}
