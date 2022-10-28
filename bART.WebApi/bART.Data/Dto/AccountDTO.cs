using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bART.Data.Dto
{
    public class AccountDTO
    {
        public string AccountName { get; set; } = null!;
        public string IncidentName { get; set; } = null!;

        //public virtual ICollection<Contact>? Contacts { get; set; }

        //public IncidentDTO Incident { get; set; } = null!;
    }
}
