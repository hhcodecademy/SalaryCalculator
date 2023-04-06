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
            Console.WriteLine("Please enter married status (e / E: evli, s / S: subay, d / D: dul)");
            char marriedStatus  = char.Parse(Console.ReadLine().ToLower());
            int childCount = 0;
            if (marriedStatus=='e'||marriedStatus=='d')
            {
                childCount= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter disabled status (b / B: bəli, x / X: yox))");
            char disabledStatus = char.Parse(Console.ReadLine().ToLower());

            float marriedIncome = 0;
            if (marriedStatus=='e')
            {
                marriedIncome=50;
                grossSalary = grossSalary + marriedIncome;
            }
            
            float childIncome = 0;
            switch (childCount)
            {
                case 1:
                    childIncome =30;
                    break;
                case 2:
                    childIncome = 30+25;
                    break;
                case 4:
                    childIncome = 30+25+20;
                    break;
       
                default:
                    if (childCount > 3)
                    {
                        childIncome = 30 + 25 + 20 + (childCount - 3) * 15;
                    }
                    else {
                        childIncome = 0;
                    }
                    break;
            }
            grossSalary = grossSalary + childIncome;

            float taxAmount = 0f;
            float netSalary = 0;
            float taxRate = 0;
            if (grossSalary<=1000)
            {
                taxRate = 0.15f;
                taxAmount = grossSalary * taxRate;                
                netSalary = grossSalary * (1-taxRate);
            }
            else if (grossSalary > 1000 && grossSalary <= 2000)
            {
                taxRate = 0.2f;
                taxAmount = grossSalary * taxRate;
                netSalary = grossSalary * (1 - taxRate);
            }
            else if (grossSalary > 2000 && grossSalary <= 3000)
            {
                taxRate = 0.3f;
                taxAmount = grossSalary * taxRate;
                netSalary = grossSalary * (1 - taxRate);
            }
            if (disabledStatus=='b')
            {
                netSalary = netSalary + (taxAmount / 2);
                taxAmount = taxAmount / 2;
            }

        }
    }
}
