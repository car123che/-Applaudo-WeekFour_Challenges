using EFUnivesityDomain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUnivesityDomain
{
    public class Instructor: PersonBaseDomain
    {
        public DateTime HireDate { get; set; }


        // for the one to one relationships
        public virtual Department Department { get; set; }

    }
}
