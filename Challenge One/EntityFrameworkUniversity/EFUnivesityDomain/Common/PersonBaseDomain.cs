using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUnivesityDomain.Common
{
    public abstract class PersonBaseDomain
    {
        public int Id { get; set; }
        public string LastName { get; set; } 
        public string FirstMidName { get; set; }

    }
}
