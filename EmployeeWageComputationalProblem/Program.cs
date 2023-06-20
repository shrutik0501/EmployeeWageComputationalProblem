using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationalProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number to execute that UC");
            int UseCaseNumber =Convert.ToInt32(Console.ReadLine());
            switch (UseCaseNumber)
            {
                    case 1:
                    Console.WriteLine("UC1 Executing");
                    EmployeeAttendance.GetAttendenceint();
                    break;
                    case 2:
                    Console.WriteLine("UC2 Executing");
                    EmployeeWage.GetAttendance();
                    break;
                    case 3:
                    Console.WriteLine("UC3 Executing");
                    EmpWage.GetAttendance();
                    break;
                    case 4:
                    Console.WriteLine("UC4 Executing");
                    EmpWage_SwitchCase.EmpWageUsingSwitchCase();
                    break;
                    case 5:
                    Console.WriteLine("UC5 Executing");
                    EmpWage_ForLoop.EmpWageUsingForLoop();
                    break;
                    case 6:
                    Console.WriteLine("UC6 Executing");
                    EmpWage_WhileLoop.EmpWageUsingWhileLoop();
                    break;
                    case 7:
                    Console.WriteLine("UC7 Executing");
                    EmpWage_Compute.ComputeEmpWage("Wipro", 10, 10, 10);
                    break;
                    default: Console.WriteLine("Invalid Input");
                    break;
            }
            //  EmployeeAttendance.GetAttendenceint();
            //EmployeeWage.GetAttendance();
            //EmpWage.GetAttendance();
            //EmpWage_SwitchCase.EmpWageUsingSwitchCase();
            //EmpWage_ForLoop.EmpWageUsingForLoop();
            //EmpWage_WhileLoop.EmpWageUsingWhileLoop();
           //EmpWage_Compute.ComputeEmpWage("Wipro",10,10,10);
        }
                 
    }
}
