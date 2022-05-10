namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            UC2 wage = new UC2();
            wage.salary();
            UC3 part = new UC3();
            part.partTime();
            UC4 swich = new UC4();
            swich.switchCase();
            UC5 mont = new UC5();
            mont.month();
            UC6 employee = new UC6();
            employee.emp();
            UC7 emp = new UC7();
            emp.computeEmpWage();
            UC8 company = new UC8();
            company.multipleCompany();

            EmpWageBuilder dmart = new EmpWageBuilder("DMart", 20, 2, 10);
            EmpWageBuilder Reliance = new EmpWageBuilder("Reliance", 10, 4, 20);
            dmart.computeEmpWage();
            Console.WriteLine(dmart.toString());
            Reliance.computeEmpWage();
            Console.WriteLine(Reliance.toString());

            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();

            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total wage for DMart company : " + empWageBuilder.getTotalWage("DMart"));




        }
    }
}