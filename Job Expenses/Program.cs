using System;
using System.Collections.Generic;

namespace Job_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            int totalexpenses = 0;

            string input = Console.ReadLine();

            string[] incomeandexpenses = input.Split(" ");

            List<string> allexpenses = new List<string>();


            foreach (var incexp in incomeandexpenses)
            {
                if (incexp.Contains('-'))
                {
                    allexpenses.Add(incexp);
                }
            }

            foreach (var expense in allexpenses)
            {
                totalexpenses += int.Parse(expense);
            }

            Console.WriteLine(Math.Abs(totalexpenses));
        }
    }
}
