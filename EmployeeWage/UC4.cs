using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{

    class UC4
    {
        public void switchCase()
        {
            Console.WriteLine("Welcome to Employee Wage computation program!");

            int empwageperhrs = 20;
            int emphrs = 0;
            Random CheckempAttandance = new Random();
            int ispresent = CheckempAttandance.Next(0, 3);
            Console.WriteLine(ispresent);

            if (ispresent == 1)
            {
                Console.WriteLine("Employee is present!");
                Console.WriteLine("Employee is Full Time");
                emphrs = 8;
            }
            else if (ispresent == 2)
            {
                Console.WriteLine("Employee is Present!");
                Console.WriteLine("Employee is Part Time");
                emphrs = 4;
            }

            else
            {
                Console.WriteLine("Employee is Absent!");
                emphrs = 0;
            }



            switch (ispresent)
            {
                case 1:
                    Console.WriteLine("Employee is present!");
                    Console.WriteLine("Employee is Full Time");
                    emphrs = 8;
                    break;
                case 2:
                    Console.WriteLine("Employee is present!");
                    Console.WriteLine("Employee is Part Time");
                    emphrs = 4;
                    break;
                default:
                    emphrs = 0;
                    break;

            }
            int Salary = emphrs * empwageperhrs;
            Console.WriteLine("Employee Salary = " + Salary);
        }
    }
}