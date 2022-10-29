namespace bART.Data.Entities
{
    public class Contact
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? AccountName { get; set; }
        public virtual Account? Account { get; set; }
    }
}
