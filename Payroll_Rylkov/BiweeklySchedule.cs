﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Rylkov
{
   public class BiweeklySchedule : PaymentSchedule
    {
       public override string ToString()
       {
           return "biweekly";
       }
    }
}
