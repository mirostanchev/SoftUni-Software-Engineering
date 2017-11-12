using System;

public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumptionPerKm, double tankCapaciity)
        : base(fuelQuantity, fuelConsumptionPerKm, tankCapaciity)
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
        if (fuel <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else if (base.FuelQuantity + fuel > base.TankCapaciity)
        {
            Console.WriteLine("Cannot fit fuel in tank");
        }
        else
        {
            base.FuelQuantity += fuel;
        }
    }
}