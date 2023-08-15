using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeHierarchy
{
     abstract class Employee
    {
        protected string Name;
        protected int EmployeeID;
        protected int Salary;
        public  Employee(string name,int EmployeeId, int salary) {
            Name = name;    
            EmployeeID = EmployeeId;
            Salary = salary;
        }
        public abstract double CalculateBonus();
    }
    class Manager : Employee
    {

        public Manager(string name,int EmployeeId, int salary) : base(name, EmployeeId, salary) { }
        public override double CalculateBonus()
        {
            double bonus = Salary * 0.20;
            return bonus;
            
        }
    }
    class Developer : Employee
    {

        public Developer(string name, int EmployeeId, int salary) : base(name, EmployeeId, salary) {}
        public override double CalculateBonus()
        {
            double bonus = Salary * 0.50;
            return bonus;
        }
    }
    class Salesperson : Employee
    {

        public Salesperson(string name, int EmployeeId, int salary) : base(name, EmployeeId, salary){}
        public override double CalculateBonus()
        {
            double bonus = Salary * 0.40;
            return bonus;
        }
    }
}
