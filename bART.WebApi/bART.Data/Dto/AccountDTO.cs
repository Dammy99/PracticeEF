namespace bART.Data.Dto
{
    public class AccountDTO
    {
        public string AccountName { get; set; } = null!;
        public virtual ICollection<ContactDTO> Contacts { get; set; } = null!;
    }
}
