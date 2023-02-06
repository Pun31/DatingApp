using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Shared.Domain
{
    public class Consultation : BaseDomainModel
    {
        public string ConsultName { get; set; }
        public DateTime ConsultDate { get; set; }
        public string ConsultReport { get; set; }
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }
    }
}
