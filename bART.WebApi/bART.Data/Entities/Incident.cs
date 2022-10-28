using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bART.Data.Entities
{
    public class Incident
    {
        //public string IncidentName { get; set; }
        // public int Id { get; set; }
        public string IncidentName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public virtual ICollection<Account> Accounts { get; set; } = null!;
    }
}
