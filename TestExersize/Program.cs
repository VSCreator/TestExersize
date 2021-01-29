using System;
using TestExersize.Models;
using TestExersize.Extensions;

namespace TestExersize
{
    class Program
    {
        static void Main(string[] args)
        {
            TestTask();
        }

        private static void TestTask()
        {
            Firm someFirm = new Firm();

            someFirm.Employees.Add(new Manager("Tom Red", 10));
            someFirm.Employees.Add(new Foreman("Tom Green", 5.5));
            someFirm.Employees.Add(new Worker("Tom Blue", 2.2));
            someFirm += new Worker("Tom Imposter", 1);

            string type = typeof(Manager).ToString();
            Console.WriteLine($"Is Have type {type} = {someFirm.IsHaveType(type)}");

            var workers = someFirm.GetEmployesWithSelectedType<Worker>();

            Console.WriteLine("\n=============");
            Console.WriteLine("WORKERS");
            foreach (var worker in workers)
            {
                Console.WriteLine(worker.FullName);
            }

            Console.WriteLine($"Workers number - {someFirm.GetCountEmployesWithSelectedType<Worker>()}");

            Console.WriteLine("\n=============");
            Console.WriteLine("ALL EMPLOYES");
            someFirm.PrintEmployees();
        }
    }
}
