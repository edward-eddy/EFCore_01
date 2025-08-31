using Demo.Contexts;
using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();

            //context.Employees.Where(E => E.EmpId == 0);
        }
    }
}
