﻿namespace _08.RawData
{
    public class Tire
    {
        private int age;
        private double pressure;

        public Tire(double pressure, int age)
        {
            this.pressure = pressure;
            this.age = age;
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public double Pressure
        {
            get { return this.pressure; }
            set { this.pressure = value; }
        }
    }
}