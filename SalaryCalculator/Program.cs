using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float grossSalary = 0f;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter total gross salary");
            float salary = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter married status (e / E: evli, b / B: subay, d / D: dul)");
            char marriedStatus  = char.Parse(Console.ReadLine().ToLower());
            int childCount = 0;
            if (marriedStatus=='e'||marriedStatus=='d')
            {
                childCount= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter disabled status (e / E: bəli, x / X: yox))");
            char disabledStatus = char.Parse(Console.ReadLine().ToLower());

            if (marriedStatus=='e')
            {
                grossSalary = grossSalary + 50;
            }
            switch (childCount)
            {
                case 1:
                    grossSalary = grossSalary + 30;
                    break;
                default:
                    break;
            }
        }
    }
}
