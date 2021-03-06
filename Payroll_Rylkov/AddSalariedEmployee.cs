﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Payroll_Rylkov
{
   public class AddSalariedEmployee : AddEmployeeTransaction
    {
        private readonly double salary;
        public AddSalariedEmployee(int id, string name, string address, double salary)
            : base(id, name, address)
        {
            this.salary = salary;
        }
        protected override PaymentClassification MakeClassification()
        {
            return new SalariedClassification(salary);

        }
        protected override PaymentSchedule MakeSchedule()
        {
            return new MonthlySchedule();
        }
        internal void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
