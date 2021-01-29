using System;
using System.Collections.Generic;
using System.Text;
using TestExersize.Interfaces;

namespace TestExersize.Models
{
    class Worker : IEmployee, IEmployeeWork
    {
        private string fullName;
        private double workExperience;

        public string FullName 
        { 
            get => fullName; 
            set
            {
                if (!string.IsNullOrEmpty(value))
                    fullName = value;
            }
        }
        public double WorkExperience
        {
            get => workExperience;
            set
            {
                if (value >=0)
                {
                    workExperience = value;
                }
            }
        }

        public Worker(string fullname, double workExperience)
        {
            FullName = fullname;
            WorkExperience = workExperience;
        }

        public void Work()
        {
            Console.WriteLine("Выпуск продукции");
        }
    }
}
