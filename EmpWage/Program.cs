using System;
//Switch Case 
namespace EmpWage
{
    internal class Program
    {

        //Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int Emp_RATE_PER_TIME = 20;
        static void Main(string[] args)
        {
            //Variables
            int empHrs = 0;
            int empwage = 0;

            //It is using to generate random numbers
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);

            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;

            }

            empwage = empHrs * Emp_RATE_PER_TIME;
            Console.WriteLine("EmpWage : " + empwage);
        }

    }
}





