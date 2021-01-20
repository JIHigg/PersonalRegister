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
            int count = 0;
            SeedData();//Data set down below
            Employee[] employees = payroll.GetEmployees();// Builds list of employees.

            foreach (Employee employee in employees)//Displays the Data set from above
            {
                Console.WriteLine($"Name: {employee.Name}  Salary: {employee.Salary}");
            }


            

            while (input != "X")
            {
                //Needs an input loop that actually works. -Fixed.
                Console.WriteLine("\nPlease enter Employee name/Ange anställdas namn." +
                    " Enter 'X' to exit. : ");
                input = Console.ReadLine();
                if(input == "X")//Input to exit loop.
                {
                    break;
                }
                names.Add(input);//Saves input name to list.

                Console.WriteLine("\nPlease enter Employee salary/Ange anställdas lön: ");
                salary = int.Parse(Console.ReadLine());
                pay.Add(salary); //Saves input salary to list.
            }

            Console.WriteLine("\nCurrent Employees/Personal");
            Console.WriteLine("-----------------------------");//Header for list

            foreach (string name in names)//Displays names and salaries
            {
                Console.WriteLine("\nEmployee Name/Anställd Namn: {0}", names[count]);
                Console.WriteLine("Employee Salary/Anställd Lön: {0}", pay[count]);
                count++;
            }
        }
        private static void SeedData()
        {
            payroll.AddEmployee("Max", 10000);
            payroll.AddEmployee("Colin", 50000);
            payroll.AddEmployee("Liz", 20000);
        }
        static Payroll payroll = new Payroll();
    }
}
