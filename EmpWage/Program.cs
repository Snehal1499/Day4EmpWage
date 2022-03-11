using System;
//UC3_Part Time Employee And Wage
namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            //Constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int Emp_RATE_PER_HOUR = 20;

            //Variables
            int empHrs = 0;
            int empwage = 0;
            //It is using to generate random numbers
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)

            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empwage = empHrs * Emp_RATE_PER_HOUR ;

            Console.WriteLine("EmpWage : " + empwage);
        }
    }
}


