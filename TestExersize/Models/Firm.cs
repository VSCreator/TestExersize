using System;
using System.Collections.Generic;
using System.Text;
using TestExersize.Interfaces;

namespace TestExersize.Models
{
    public class Firm
    {
        private List<IEmployee> employees;

        public List<IEmployee> Employees
        {
            get => employees;

            set => employees = value;
        }

        public Firm(IEmployee[] employee) : this()
        {
            employees.AddRange(employee);
        }

        public Firm() 
        {
            employees = new List<IEmployee>();
        }

        public static Firm operator +(Firm firm,IEmployee employee)
        {
            firm.Employees.Add(employee);
            return firm;
        }

        public static Firm operator -(Firm firm, IEmployee employee)
        {
            firm.Employees.Remove(employee);
            return firm;
        }

    }
}
