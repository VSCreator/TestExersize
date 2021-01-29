using System;
using System.Collections.Generic;
using System.Text;
using TestExersize.Interfaces;
using System.Linq;
using TestExersize.Models;

namespace TestExersize.Extensions
{
    public static class FirmExtension
    {
        public static bool IsHaveType(this Firm firm, string type)
        {
            return firm.Employees.Any(emp => emp.GetType().ToString() == type);
        }

        //- Реализовать дженерик методы для получения всех сотрудников типа дженерик
        public static IEnumerable<TEmployee> GetEmployesWithSelectedType<TEmployee>
            (this Firm firm) where TEmployee : IEmployee
        {
            var selectedEmployees = new List<TEmployee>();

            foreach (var employee in firm.Employees)
            {
                if (employee is TEmployee selectedTypeEmployee)
                {
                    selectedEmployees.Add(selectedTypeEmployee);
                }
            }

            return selectedEmployees;
        }

        //- Реализовать получение кол-ва сотрудников типа дженерик 
        public static int GetCountEmployesWithSelectedType<TEmployee>
            (this Firm firm) where TEmployee : IEmployee
        {
            int selectedEmployeeCounter = 0;

            foreach (var employee in firm.Employees)
            {
                if (employee is TEmployee)
                {
                    selectedEmployeeCounter++;
                }
            }

            return selectedEmployeeCounter;
        }

        public static void PrintEmployees (this Firm firm)
        {
            foreach (var employee in firm.Employees)
            {
                Console.WriteLine($"ФИО - {employee.FullName}| Стаж - {employee.WorkExperience}");
            }
        }
    }
}
