﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Rylkov
{
    public class Employee
    {
        private readonly int empid;
        private string name;
        private string address;

        public Employee(int empid, string name, string address)
        {
            this.empid = empid;
            this.address = address;
            this.name = name;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
        }
        public int EmpId
        {
            get { return empid; }
        }

        private PaymentClassification classification;
        private PaymentSchedule schedule; 
        private PaymentMethod method;
        private Affiliation affiliation;

        public PaymentClassification Classification
        {
            get { return classification; }
            set { classification = value; }
        }
        public PaymentSchedule Schedule
        {
            get { return schedule; }
            set { schedule = value; }
        }
        public PaymentMethod Method
        {
            get { return method; }
            set { method = value; }
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Emp#: ").Append(empid).Append("    ");
            builder.Append(name).Append("    ");
            builder.Append(address).Append("    ");
            builder.Append("Paid ").Append(classification).Append(" ");
            builder.Append(schedule);
            builder.Append(" by ").Append(method);
            return builder.ToString();

        } 


    }
}
