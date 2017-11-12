namespace _06.CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                var lineArgs = Console.ReadLine().Split();

                var name = lineArgs[0];
                var salary = decimal.Parse(lineArgs[1]);
                var position = lineArgs[2];
                var department = lineArgs[3];
                var email = "n/a";
                var age = -1;

                if (lineArgs.Length == 6)
                {
                    email = lineArgs[4];
                    age = int.Parse(lineArgs[5]);
                }
                else if (lineArgs.Length == 5)
                {
                    int res;
                    var isNumber = int.TryParse(lineArgs[4], out res);

                    if (!isNumber)
                    {
                        email = lineArgs[4];
                    }
                    else
                    {
                        age = res;
                    }
                }

                var employee = new Employee(name, salary, position, department, email, age);
                employees.Add(employee);
            }

            var result = employees
                .GroupBy(e => e.Department)
                .OrderByDescending(x => x.Average(y => y.Salary));

            Console.WriteLine($"Highest Average Salary: {result.First().Key}");

            foreach (var employee in result.First().OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}