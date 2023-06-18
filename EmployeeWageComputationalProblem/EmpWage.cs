using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationalProblem
{
    internal class EmpWage
    {
        public static void GetAttendance()
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME) 
            {
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME) 
            {
                empWage = 8;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR ;
            Console.WriteLine( "empWage :"+empWage);
        }
    }
}
