using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Wage : Employee
    {
        private double rate;
        private double hours;
        public Wage() { }

        public Wage(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours)
        {
            this.rate = rate;
            this.hours = hours;
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
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
            if (hours <= 40)
            {
                return this.rate * this.hours;
            }
            else
            {
                return (this.rate * 40) + (this.rate * ((this.hours - 40) * 1.5));
            }
            
        }
        public override string ToString()
        {
            return base.ToString() + ":" + this.rate + ":" + this.hours;
        }
    }
}
