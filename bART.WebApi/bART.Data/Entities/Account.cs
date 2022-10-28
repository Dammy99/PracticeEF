using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bART.Data.Entities
{
    public class Account
    {

        public string AccountName { get; set; } = null!;
        public string IncidentName { get; set; } = null!;

        //public virtual ICollection<Contact>? Contacts { get; set; }
        public Incident Incident { get; set; } = null!;

    }
}
