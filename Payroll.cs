using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalRegister
{
    class Payroll
    {
        private List<Employee> payroll;

        public Payroll()
        {
            payroll = new List<Employee>();
        }
        public Employee[] GetEmployees()
        {
            return payroll.ToArray();
        }
        internal void AddEmployee(string name, int salary)
        {
            Employee temp = new Employee(name, salary);
            payroll.Add(temp);
        }
    }
}
