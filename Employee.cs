using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalRegister
{
    class Employee
    {
       

       public int Salary { get; }
       public string Name { get; }

       public Employee()
       {

       }

       public Employee(string name, int salary)
       {
           Name = name;
           Salary = salary;
       }
        
    }
}
