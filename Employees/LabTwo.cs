/**
*Categorizes Three different Kinds of Employees
*Author:Thalia Munroe
*Version: January 9th, 2024 - V1.0
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class LabTwo
    {
        static void Main(string[] args)
        {
            var LO = new LabTwo();

            List<string> employeeList = LO.ReadFile();
            List<Employee> employees = LO.SortData(employeeList);

            double averagePay = LO.AveragePay(employees);
            Console.WriteLine("The average weekly pay for employees is: " + averagePay);

            Wage highestPaidWage = LO.HighestPaidWage(employees);

            Salaried lowestPaidSalary = LO.LowestPaidSalary(employees);

            Console.WriteLine(highestPaidWage.GetName() + " is the highest paid Wage employee, making: " + highestPaidWage.GetPay() + " a week.");
            Console.WriteLine(lowestPaidSalary.GetName() + " is the lowest paid Salary employee, making: " + lowestPaidSalary.GetSalary() + " a week.");

            Console.WriteLine("the percentage of Wage employees is: " + LO.PercentWage(employees));
            Console.WriteLine("the percentage of Part Time employees is: " + LO.PercentPT(employees));
            Console.WriteLine("the percentage of Salary employees is: " + LO.PercentSalaried(employees));
        }

        //puts lines from .txt into a list
        List<string> ReadFile()
        {
            List<string> employees = new List<string> { };
            StreamReader sr = new StreamReader("../../../../res/employees.txt");

            string line = sr.ReadLine();

            while (line != null)
            {
                employees.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
            return employees;
        }
        //sorts list into employee data
        List<Employee> SortData(List<string> employeeList)
        {
            List<Employee> employees = new List<Employee> { };
            foreach(string employee in employeeList) 
            {
                string[] employeeTemp = employee.Split(':');
                string employeeId = employeeTemp[0];
                employeeId = employeeId[0].ToString();
                if (int.Parse(employeeId) >= 0 && int.Parse(employeeId) <= 4)
                {
                    Salaried salary = new Salaried(employeeTemp[0], employeeTemp[1], employeeTemp[2], employeeTemp[3], long.Parse(employeeTemp[4]), employeeTemp[5], employeeTemp[6], double.Parse(employeeTemp[7]));
                    employees.Add(salary);
                }
                else if (int.Parse(employeeId) >= 5 && int.Parse(employeeId) <= 7)
                {
                    Wage wage = new Wage(employeeTemp[0], employeeTemp[1], employeeTemp[2], employeeTemp[3], long.Parse(employeeTemp[4]), employeeTemp[5], employeeTemp[6], double.Parse(employeeTemp[7]), double.Parse(employeeTemp[8]));
                    employees.Add(wage);
                }
                else if (int.Parse(employeeId) >= 8 && int.Parse(employeeId) < 10)
                {
                    PartTime PT = new PartTime(employeeTemp[0], employeeTemp[1], employeeTemp[2], employeeTemp[3], long.Parse(employeeTemp[4]), employeeTemp[5], employeeTemp[6], double.Parse(employeeTemp[7]), int.Parse(employeeTemp[8]));
                    employees.Add(PT);
                }
            }
            return employees;
        }
        //finds the highest Wage
        double AveragePay(List<Employee> employees)
        {
            double average = 0;
            foreach (Employee employee in employees)
            {
                if (employee is Wage)
                {
                    Wage wage = (Wage)employee;

                    average += wage.GetPay();
                }
                else if (employee is PartTime)
                {
                    PartTime pt = (PartTime)employee;

                    average += pt.GetPay();
                }
                else if (employee is Salaried)
                {
                    Salaried salary = (Salaried)employee;

                    average += salary.GetPay();
                }
            }
            average = average / employees.Count;
            return average;
        }
        Wage HighestPaidWage(List<Employee> employees)
        {
            Wage highestWage = new Wage();
            foreach(Employee employee in employees)
            {
                if (employee is Wage)
                {
                    Wage wage = (Wage)employee;

                    if (highestWage.GetPay() < wage.GetPay())
                    {
                        highestWage = wage;
                    }
                }
            }
            return highestWage;
        }
        //finds lowest paid Salary
        Salaried LowestPaidSalary(List<Employee> employees)
        {
            Salaried lowestSalary = new Salaried(null, null, null, null, 0, null, null, long.MaxValue);
            foreach (Employee employee in employees)
            {
                if (employee is Salaried)
                {
                    Salaried salary = (Salaried)employee;

                    if (lowestSalary.GetSalary() > salary.GetSalary())
                    {
                        lowestSalary = salary;
                    }
                }
            }
            return lowestSalary;
        }
        //calculates percentage of company that is Wage
        double PercentWage(List<Employee> employees)
        {
            int i = 0;
            foreach(Employee employee in employees)
            {
                if(employee is Wage)
                {
                    i ++;
                }
            }

            double percentage = ((double)i / (double)employees.Count()) * 100;
            return percentage;
        }
        //calculates percentage of company that is Part Time
        double PercentPT(List<Employee> employees)
        {
            int i = 0;
            foreach (Employee employee in employees)
            {
                if (employee is PartTime)
                {
                    i++;
                }
            }

            double percentage = ((double)i / (double)employees.Count()) * 100;
            return percentage;
        }
        //calculates percantage of company is Salary
        double PercentSalaried(List<Employee> employees)
        {
            int i = 0;
            foreach (Employee employee in employees)
            {
                if (employee is Salaried)
                {
                    i++;
                }
            }

            double percentage = ((double)i / (double)employees.Count()) * 100;
            return percentage;
        }
    }
}
