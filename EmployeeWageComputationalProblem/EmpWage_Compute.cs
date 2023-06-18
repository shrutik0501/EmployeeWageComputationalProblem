using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationalProblem
{
    internal class EmpWage_Compute
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static void ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;
            while(totalEmpHrs <= maxHourPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random .Next(0,3);
                switch (empcheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empWage = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:" + totalWorkingDays + "Emp Hrs :" +empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);


        }
    }
}
