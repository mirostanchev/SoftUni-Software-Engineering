using System;

public abstract class Vehicle
{
    private double fuelQuantity;
    private double fuelConsumptionPerKm;
    private double tankCapaciity;

    protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapaciity)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        this.TankCapaciity = tankCapaciity;
    }

    public double TankCapaciity
    {
        get { return this.tankCapaciity; }
        set { this.tankCapaciity = value; }
    }
    
    public double FuelConsumptionPerKm
    {
        get { return this.fuelConsumptionPerKm; }
        set { this.fuelConsumptionPerKm = value; }
    }

    public double FuelQuantity
    {
        get { return this.fuelQuantity; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.fuelQuantity = value;
        }
    }
    

    public abstract void Driving(double kilometers);
    public abstract void Refueling(double fuel);

    public virtual void DriveEmpty(double kilometers)
    {
        
    }
}