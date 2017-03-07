﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClassDemo
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get;set ; }
    }

    public class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee { EmployeeId = 1, Name = "Ram",Gender="Male" });
            listEmployees.Add(new Employee
            { EmployeeId = 2, Name = "Pam", Gender = "Female" });
            listEmployees.Add(new Employee
            { EmployeeId = 3, Name = "John", Gender = "Male" });
            listEmployees.Add(new Employee
            { EmployeeId = 4, Name = "Maxine", Gender = "Female" });
            listEmployees.Add(new Employee
            { EmployeeId = 5, Name = "Emiliy", Gender = "Female" });
            listEmployees.Add(new Employee
            { EmployeeId = 6, Name = "Scott", Gender = "Male" });
            listEmployees.Add(new Employee
            { EmployeeId = 7, Name = "Todd", Gender = "Male" });
            listEmployees.Add(new Employee
            { EmployeeId = 8, Name = "Ben", Gender = "Male" });
        }
        
        ////indexer.. it is created using "this" keyword
        public string this[int employeeId]
        {
            get
            {
                return listEmployees.FirstOrDefault(Emp => Emp.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployees.FirstOrDefault(Emp => Emp.EmployeeId == employeeId).Name = value;
            }
        }

        //overloading indexers
        public string this[string gender]
        {
            get {

                return listEmployees.Count(emp => emp.Gender == gender).ToString();
            }

            set
            {
                foreach(Employee emp in listEmployees)
                {

                    if (emp.Gender == gender)
                    {
                        emp.Gender = value;
                    }
                }
            }
        }
    }
}