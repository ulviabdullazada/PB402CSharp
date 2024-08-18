namespace Abstract_Interface;
/*
Vehicle asbtract classı:
 - FactoryName
 - Model
 - Color
 - DriveTime
 - DrivePath
 - AverageSpeed() - Ortalama sürəti hesablayır(m/saniye mentiqi ile yani path ve time dan istifade edirsiz)
 - GetInfo() virtual method yaradirsiz miras oturduyu classda override etdikde butun deyerleri ekrana cixarmalidir.
 - ToString() methodunu override edirsiz ekrana cixartdiqda FactoryName ile Model deyerlerini gostersin
 - DefineNatureHarmness() - abstract method-dur override etdikde benzinle ishleyenlerde high, 
elektrikle ishleyenlerde low, motorsuz ishleyen araclarda none cixarsin. 

Car classı :
 - DoorCount
 - IsElctricCar
Bicycle classı :
 - Type 


Program.cs de Car ve Bicycle classlarindan bir nece object yaradib hamisini bir arraya yigin 
ve foreach ile butun arraydaki objectleri   ekrana cixardin.
*/
public abstract class Vehicle
{
    public string FactoryName { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public float DriveTime { get; set; }
    public float DrivePath { get; set; }
    public float AverageSpeed()
    {
        return DrivePath / DriveTime;
    }
    public virtual string GetInfo()
    {
        return $"{FactoryName} {Model} {Color} {DriveTime} {DrivePath}";
    }
    public override string ToString()
    {
        return $"{FactoryName} {Model}";
    }

    public abstract void DefineNatureHarmness();
}

public class Car : Vehicle
{
    public int DoorCount { get; set; }
    public bool IsElectricCar { get; set; }
    public override void DefineNatureHarmness()
    {
        if (IsElectricCar)
        {
            Console.WriteLine("Low");
        }
        Console.WriteLine("High");
    }
    public override string GetInfo()
    {
        return base.GetInfo() + $" {DoorCount} {IsElectricCar}";
    }
}

public class Bicycle : Vehicle
{
    public int WheelCount { get; set; }
    public override void DefineNatureHarmness()
    {
        Console.WriteLine("None");
    }
    public override string GetInfo()
    {
        return base.GetInfo() + " " + WheelCount;
    }
}