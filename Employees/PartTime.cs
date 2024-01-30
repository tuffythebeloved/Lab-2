using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class PartTime : Employee
    {
        private double rate;
        private double hours;
        public PartTime() { }

        public PartTime(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours)
        {
            this.rate = rate;
            this.hours = hours;
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
        }
        public double GetRate()
        {
            return rate;
        }

        public double GetHours()
        {
            return hours;
        }
        public double GetPay()
        {
            return this.rate * this.hours;
        }

        public override string ToString()
        {
            return base.ToString() + ":" + this.rate + ":" + this.hours;
        }
    }
}
