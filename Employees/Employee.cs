using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Employee
    {
        protected string id;
        protected string name;
        protected string address;
        protected string phone;
        protected long sin;
        protected string dob;
        protected string dept;

        protected Employee()
        { }

        protected Employee(string id, string name, string address, string phone, long sin, string dob, string dept)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
        }
        public string GetId() { return this.id; }
        public string GetName() { return this.name; }   
        public string GetAddress() { return this.address; }
        public string GetPhone() { return this.phone; }
        public long GetSin() { return this.sin; }
        public string GetDOB() { return this.dob; }
        public string GetDept() { return this.dept; }

        public void SetId(string id) { this.id = id; }
        public void SetName(string name) { this.name = name;}
        public void SetAddress(string address) { this.address = address;}
        public void SetPhone(string phone) { this.phone = phone;}
        public void SetSin(long sin) { this.sin = sin;}
        public void SetDOB(string dob) { this.dob = dob;}
        public void SetDept(string dept) { this.dept = dept;}

        public override string ToString()
        {
            string employee = (this.id + ":" + this.name + ":" + this.address + ":" + this.phone + ":" + this.sin + ":" + this.dob + ":" + this.dept);
            return employee;
        }
    }
}
