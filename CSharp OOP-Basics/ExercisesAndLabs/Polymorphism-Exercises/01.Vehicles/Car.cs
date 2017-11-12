using System;

public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumptionPerKm)
        : base(fuelQuantity, fuelConsumptionPerKm)
    {
    }

    public override void Driving(double kilometers)
    {
        if (base.FuelQuantity / (base.FuelConsumptionPerKm + 0.9) > kilometers)
        {
            base.FuelQuantity -= kilometers * (base.FuelConsumptionPerKm + 0.9);
            Console.WriteLine($"Car travelled {kilometers} km");
        }
        else
        {
            Console.WriteLine("Car needs refueling");
        }
    }

    public override void Refueling(double fuel)
    {
        base.FuelQuantity += fuel;
    }
}