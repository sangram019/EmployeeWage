using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{

    class UC5
    {
        public void month()
        {
            Console.WriteLine("Welcome to Employee Wage computation program!");

            int empwageperhrs = 20;
            int emphrs = 0;
            int workingdays = 20;
            Random CheckempAttandance = new Random();
            int ispresent = CheckempAttandance.Next(0, 4);
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
                case 0:
                    Console.WriteLine("Employee is Absent!");

                    emphrs = 0;
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }
            int Salary = emphrs * empwageperhrs;
            int monthsalary = Salary * workingdays;
            Console.WriteLine("Employee Salary = " + Salary);
            Console.WriteLine("Finalmonthsalary = " + monthsalary);
        }
    }
}