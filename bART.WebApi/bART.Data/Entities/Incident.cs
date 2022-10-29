//using bART.Data.Validations;

namespace bART.Data.Entities
{
    public class Incident
    {
        public string IncidentName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public virtual ICollection<Account> Accounts { get; set; } = null!;
    }
}
