﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyApi
{
    public class Company
    {
        private readonly List<Employee> employees = new List<Employee>();
        public Company()
        {
        }

        public Company(string name)
        {
            Name = name;
        }

        public int CompanyId { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees
        {
            get
            {
                return employees;
            }
        }

        public void AddEmployee(EmployeeUpdateModel employee)
        {
            var addEmployee = new Employee(employee.Name, employee.Salary);
            addEmployee.EmployeeID = employees.Count + 1;
            employees.Add(addEmployee);
        }
    }
}
