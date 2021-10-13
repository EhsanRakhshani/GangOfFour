using GangOfFour.Creational.AbstractFactory.AbstractFactory;
using GangOfFour.Creational.AbstractFactory.AbstractProducts;
using GangOfFour.Creational.AbstractFactory.ConcreteFactory;
using GangOfFour.Creational.Builder.Builder;
using GangOfFour.Creational.Builder.ConcreatBuilder;
using GangOfFour.Creational.Builder.Director;
using GangOfFour.Creational.Builder.Product;
using GangOfFour.Creational.FactoryMethods.Creator;
using GangOfFour.Creational.FactoryMethods.Product;
using GangOfFour.Creational.Prototype.ConcreatePrototype;
using GangOfFour.Creational.Prototype.Prototype;
using GangOfFour.Creational.Singletone;
using System;

namespace GangOfFour.View
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------------------Singleton Pattern Demo
            Console.WriteLine("***Singleton Pattern Demo***\n");
            Console.WriteLine("Trying to create instance s1.");
            Singleton s1 = Singleton.Instance;
            Console.WriteLine("Trying to create instance s2.");
            Singleton s2 = Singleton.Instance;
            if (s1 == s2)
                Console.WriteLine("Only one instance exists.");
            else
                Console.WriteLine("Different instances exist.");
            Console.Read();

            //------------------------------------------------------------------Prototype Pattern Demo
            Console.WriteLine("***Prototype Pattern Demo***\n");
            //Base or Original Copy
            BasicCar nano_base = new Nano("Green Nano") { Price = 100000 };
            BasicCar ford_base = new Ford("Ford Yellow") { Price = 500000 };
            BasicCar bc1;
            //Nano
            bc1 = nano_base.Clone();
            bc1.Price = nano_base.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1}", bc1.ModelName, bc1.Price);
            //Ford
            bc1 = ford_base.Clone();
            bc1.Price = ford_base.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1}", bc1.ModelName, bc1.Price);

            //------------------------------------------------------------------Builder Pattern Demo
            Console.WriteLine("***Builder Pattern Demo***");
            Director director = new Director();
            IBuilder b1 = new Car("Ford");
            IBuilder b2 = new MotorCycle("Honda");
            // Making Car
            director.Construct(b1);
            Product p1 = b1.GetVehicle();
            p1.Show();
            //Making MotorCycle
            director.Construct(b2);
            Product p2 = b2.GetVehicle();
            p2.Show();
            Console.ReadLine();

            //------------------------------------------------------------------Factory Pattern Demo
            Console.WriteLine("***Factory Pattern Demo***\n");
            IConcreateCreatorAnimalFactory tigerFactory = new ConcreateCreatorTigerFactory();// Creating a Tiger Factory
            IProductAnimal aTiger = tigerFactory.CreateAnimal();// Creating a tiger using the Factory Method
            aTiger.Speak(); aTiger.Action();
            IConcreateCreatorAnimalFactory dogFactory = new ConcreateCreatorDogFactory();// Creating a DogFactory
            IProductAnimal aDog = dogFactory.CreateAnimal();// Creating a dog using the Factory Method
            aDog.Speak(); aDog.Action();
            Console.ReadKey();


            //------------------------------------------------------------------ Abstract Factory Pattern Demo
            Console.WriteLine("***Abstract Factory Pattern Demo***\n");
            //Making a wild dog through WildAnimalFactory
            IAnimalFactory wildAnimalFactory = new WildAnimalFactory();
            IDog wildDog = wildAnimalFactory.GetDog();
            wildDog.Speak();
            wildDog.Action();
            //Making a wild tiger through WildAnimalFactory
            ITiger wildTiger = wildAnimalFactory.GetTiger();
            wildTiger.Speak();
            wildTiger.Action();
            Console.WriteLine("******************");
            //Making a pet dog through PetAnimalFactory
            IAnimalFactory petAnimalFactory = new PetAnimalFactory();
            IDog petDog = petAnimalFactory.GetDog();
            petDog.Speak();
            petDog.Action();
            //Making a pet tiger through PetAnimalFactory
            ITiger petTiger = petAnimalFactory.GetTiger();
            petTiger.Speak();
            petTiger.Action();
            Console.ReadLine();
        }
    }
}
