﻿using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                Console.WriteLine("Please enter a name: (leave empty to exit): ");

                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }
                Employee currentEmployee = new Employee(input);
                employees.Add(currentEmployee);
            }
            return employees;
        }

        static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i].GetName());
            }
        }

        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            PrintEmployees(employees);
        }
    }
}
