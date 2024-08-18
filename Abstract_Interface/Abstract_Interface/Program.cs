using Abstract_Interface;
using System.Globalization;
#region Const,Init,Readonly
//Person person = new Person()
//{
//    Id = 2
//};
//person.Name = "Salam";
//person.Surname = "Salalmov";
////Console.WriteLine(person.Id);
////person.Id = 4;
////person.Test = "123123";
////Person.A = "asdasd
////person.Id = 3;
//Console.WriteLine(Person.A);
#endregion

#region Abstract, Interface
//Cat garflied = new Cat();
//Shark balaeli = new Shark();
//Parrot par = new Parrot();
//Chicken kfc = new Chicken();
//Dog spike = new Dog();
//Animal[] animals = { garflied, balaeli, par };

//foreach (Animal animal in animals)
//{
//    animal.Eat();
//}
//ISwim[] swimmers = { spike, balaeli };

//foreach (var animal in swimmers)
//{
//    animal.Swim();
//}
//ISwim it = new Dog();
//it.Test();
//garflied.Eat();

//Bird[] birds = {par, kfc};
//foreach (var bird in birds)
//{
//    bird.Fly();
//}
//Person p = new Person()
//{
//    Name = "Fuad",
//    Surname = "Sultanli",
//    Id = 1
//};
//Console.WriteLine(p);
#endregion

#region Homework
//Console.WriteLine("Enter username");
//User user = new User(Console.ReadLine());

//while (string.IsNullOrEmpty(user.Username))
//{
//    Console.WriteLine("Username must be greater than 5 and less than 26");
//    user.Username = Console.ReadLine();
//}

//do
//{
//    Console.WriteLine("Enter password");
//    user.Password = Console.ReadLine();
//} while (String.IsNullOrEmpty(user.Password));
//Console.WriteLine(user);
#endregion

#region Task

Vehicle[] vehicles =
{
    new Car()
    {
        Color = "red",
        DoorCount = 2,
        DrivePath = 4000,
        DriveTime = 352,
        FactoryName = "BMW",
        Model = "F30",
        IsElectricCar = false
    },
    new Bicycle
    {
        Color = "white",
        DriveTime = 500,
        Model = "Track",
        FactoryName = "BMX",
        DrivePath = 2000,
        WheelCount = 2
    }
};
foreach (var vehicle in vehicles)
{
    Console.WriteLine(vehicle.ToString() + " " + Math.Round(vehicle.AverageSpeed(),1));
    //vehicle.DefineNatureHarmness();
}
#endregion