using System;

public class Bus : Vehicle
{
    public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapaciity)
        : base(fuelQuantity, fuelConsumptionPerKm, tankCapaciity)
    {
    }

    public override void Driving(double kilometers)
    {
        if (base.FuelQuantity / (base.FuelConsumptionPerKm + 1.4) > kilometers)
        {
            base.FuelQuantity -= kilometers * (base.FuelConsumptionPerKm + 1.4);
            Console.WriteLine($"Bus travelled {kilometers} km");
        }
        else
        {
            Console.WriteLine("Bus needs refueling");
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

    public override void DriveEmpty(double kilometers)
    {
        if (base.FuelQuantity / base.FuelConsumptionPerKm > kilometers)
        {
            base.FuelQuantity -= kilometers * base.FuelConsumptionPerKm;
            Console.WriteLine($"Bus travelled {kilometers} km");
        }
        else
        {
            Console.WriteLine("Bus needs refueling");
        }
    }
}