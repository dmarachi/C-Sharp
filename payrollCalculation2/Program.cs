// Program Name:    PayrollCalculation
//
// Description:     
//                  Prompts the user for the employee name, the number of hours worked by the employee, their rate of pay, and the percentage 
//                  of their gross pay that is deducted for benefits, income taxes in the calculationo of net pay. Once the application has 
//                  collected the information from the user, it will calculate the employee's Gross Pay, Deductions, and Net Pay.
//                  After the values have been calculated, they are presented, along with the employee's name, hours worked and pay rate 
//                  in an organized manner.
//                  Decimal numbers can be used in this program
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payrollCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string employeeName;        // Askes the user to enter the employee name
            decimal hoursWorked;        // Askes the user to enter the number of hours worked
            decimal hourlyWage;         // Askes the user to enter the hourly wage
            int deductionPercentage;    // Askes the user to enter the percentage of their gross pay that is deducted for benefits, income taxes in the calculation of net pay
            decimal grossPay;           // Gets the value for the gross pay which is calculated as "number of hours" * "rate of pay"
            decimal amountOfDeduction;  // Gets the calculated value for the deduction amount that is going to apply
            decimal netPay;             // Gets the calculated value for the net pay

            //Information about the program
            Console.WriteLine("Decimal numbers can be used in this program");
            
            //Asking the user to enter the employee name
            Console.Write("\n\nEnter the employee full name as written on the ID card: ");
            employeeName = Console.ReadLine();
            
            //Asking the user to enter the number of hours worked
            Console.Write("Enter the number of hours worked: ");
            input = Console.ReadLine();
            hoursWorked = decimal.Parse(input);

            //Asking the user to enter the hourly wage / the rate of pay per hour
            Console.Write("Enter the rate of pay per hour: ");
            input = Console.ReadLine();
            hourlyWage = decimal.Parse(input);

            //Asking the user to enter the deduction percentage of their gross pay that is deducted for benefits, income taxes
            Console.Write("Enter the deduction percentage: ");
            input = Console.ReadLine();
            deductionPercentage = int.Parse(input);
           // string percentag = deductionPercentage.ToString("p0");

           //Calculating the Gross pay
            grossPay = hoursWorked * hourlyWage;

            //Calculating the Dollar amount of deduction 
            amountOfDeduction = grossPay * deductionPercentage / 100;

            //Calculating the  Net pay
            netPay = grossPay - amountOfDeduction; 

            //printing the employee name on the console and the hours worked and the wage per hour
            Console.WriteLine("\n\nThe employee name is: " + employeeName);
            Console.WriteLine("The hours worked for " + employeeName + " is: " + hoursWorked + " hours at a $" + hourlyWage + " per hour.");

            //printing the gross pay, printing the deductions, printing the net pay
            Console.WriteLine("\n\n  Gross Pay is: " + grossPay.ToString("C"));
            Console.WriteLine(" Deductions is: -" + amountOfDeduction.ToString("C2"));
            Console.WriteLine("               -----------");
            Console.WriteLine("The Net Pay is: " + netPay.ToString("C") + " \n\n");

        }
    }
}
