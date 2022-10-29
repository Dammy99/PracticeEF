namespace bART.Data.Entities
{
    public class Account
    {

        public string AccountName { get; set; } = null!;
        public string? IncidentName { get; set; }
        public virtual ICollection<Contact>? Contacts { get; set; }
        public Incident Incident { get; set; } = null!;

    }
}
