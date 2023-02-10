using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Shared.Domain
{
    public class MatchType : BaseDomainModel
    {
        public string Match { get; set; }
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }
    }
}
