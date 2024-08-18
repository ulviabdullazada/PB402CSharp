namespace Abstract_Interface;
public abstract class Animal
{
    public string Name { get; set; }

    public abstract void Eat();

    //public void Eat()
    //{
    //    Console.WriteLine("Eat as animal");
    //}
}

public abstract class Bird : Animal
{
    //public abstract void Fly();
    public override void Eat()
    {
        Console.WriteLine("Bird eating wheat");
    }
    public virtual void Fly()
    {
        Console.WriteLine("Fly as bird");
    }
}
public class Chicken : Bird
{
    public override void Eat()
    {
        Console.WriteLine("asdasd");
    }
    public override void Fly()
    {
        Console.WriteLine("Chicken cannot fly :(");
    }
}
public class Parrot : Bird
{
    public void Talk()
    {
        Console.WriteLine("Parrot is talking");
    }
}

public abstract class Fish : Animal, ISwim
{
    public int MaxSwimTime { get; }

    public void Swim()
    {
        Console.WriteLine("Swim as fish");
    }
}

public class Shark : Fish
{
    public override void Eat()
    {
        Console.WriteLine("Shark eating little fish");
    }

    public void SayMeyxana()
    {
        Console.WriteLine("Akulalar oyagdilar yatmayir");
    }
}

public abstract class Pet : Animal
{
    public void Play()
    {
        Console.WriteLine("Play as pet");
    }
}

public class Cat : Pet
{
    public override void Eat()
    {
        Console.WriteLine("Cat eating lasania");
    }

    public void Sleep()
    {
        Console.WriteLine("zzZ");
    }
}
public class Dog : Pet, ISwim
{
    public int MaxSwimTime { get; }

    public override void Eat()
    {
        Console.WriteLine("Eating bone");
    }

    public void Swim()
    {
        Console.WriteLine("Swim as dog");
    }
}