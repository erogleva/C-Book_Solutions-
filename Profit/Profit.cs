using System;

namespace Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            int workdays = int.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double currencyRate = double.Parse(Console.ReadLine());

            double monthSalary = workdays * moneyPerDay;
            double moneyPerYear = (monthSalary * 12) + (monthSalary * 2.5);
            double taxes = 0.25 * moneyPerYear;
            double netSalary = moneyPerYear - taxes;
            double salaryInLeva = netSalary * currencyRate;

            double average = salaryInLeva / 365;
            Console.WriteLine("{0:f2}", average);
        }
    }
}
