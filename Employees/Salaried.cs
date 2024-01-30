using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Salaried : Employee
    {
        protected double salary;

        public Salaried() { }

        public Salaried(string id, string name, string address, string phone, long sin, string dob, string dept, double salary) 
        { 
            this.salary = salary;
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
        }

        public double GetSalary() { return this.salary;}
        public void SetSalary(double salary) { this.salary = salary;}

        public double GetPay() { return this.salary; }
        public override string ToString()
        {
            return base.ToString() + ":" + this.salary;
        }
    }
}
