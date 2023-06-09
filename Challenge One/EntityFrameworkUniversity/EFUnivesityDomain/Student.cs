﻿using EFUnivesityDomain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUnivesityDomain
{
    public class Student: PersonBaseDomain
    {
        public DateTime EnrollmentDate { get; set; }

        public virtual List<Enrollment> Enrollments { get; set; } //to have acces to all teams in a league
    }
}
