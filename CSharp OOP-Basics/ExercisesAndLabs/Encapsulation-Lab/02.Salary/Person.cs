﻿namespace _02.Salary
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Person(string firstName, string lastName, int age, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public string FirstName { get => this.firstName; }

        public int Age { get => this.age; }

        public void IncreaseSalary(double bonus)
        {
            if (this.age <= 30)
            {
                this.salary += this.salary * bonus / 200;
            }
            else
            {
                this.salary += this.salary * bonus / 100;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.lastName} get {this.salary:f2} leva";
        }
    }
}