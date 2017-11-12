using System;

public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapaciity)
        : base(fuelQuantity, fuelConsumptionPerKm, tankCapaciity)
    {
    }

    public override void Driving(double kilometers)
    {
        if (base.FuelQuantity / (base.FuelConsumptionPerKm + 1.6) > kilometers)
        {
            base.FuelQuantity -= kilometers * (base.FuelConsumptionPerKm + 1.6);
            Console.WriteLine($"Truck travelled {kilometers} km");
        }
        else
        {
            Console.WriteLine("Truck needs refueling");
        }
    }

    public override void Refueling(double fuel)
    {
        if (fuel <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else
        {
            base.FuelQuantity += fuel * 0.95;
        }
    }
}