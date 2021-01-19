using System;
using System.Collections.Generic;


// 1) En Program klass att ta in input och visa allt, och
// en klass för Methodor.

// 2) I Program klassen, bör två listor för string och int input och två instanser
// av metoderna från den andra klassen. I den andra klass, bör en metod att loop att
// ta i input och spara till listor, och en andra metod att visa allt ut.

namespace PersonalRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pay = new List<int>();
            List<string> names = new List<string>();
            string input = "";
            int salary = 0;

            if (input != "Stop")
            {
                Console.WriteLine("Please enter Employee name/Ange anställdas namn: ");
                input = Console.ReadLine();
                names.Add(input);

                Console.WriteLine("Please enter Employee salary/Ange anställdas lön: ");
                salary = int.Parse(Console.ReadLine());
                pay.Add(salary);
            }
            for (int i = 0; i >= input.Length; i++)
            {
                Console.WriteLine("Employee Name/Anställd Namn: {0}", names[i]);
                Console.WriteLine("Employee Salary/Anställd Lön: {0}", pay[i]);
            }
        }
    }
}
