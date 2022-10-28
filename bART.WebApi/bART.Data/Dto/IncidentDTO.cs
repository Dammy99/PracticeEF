using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bART.Data.Dto
{
    public class IncidentDTO
    {
        public string IncidentName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public virtual ICollection<AccountDTO> Accounts { get; set; } = null!;
    }
}
