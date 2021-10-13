using GangOfFour.Creational.AbstractFactory.AbstractProducts;
using System;

namespace GangOfFour.Creational.AbstractFactory.ConcreteProduct
{
    public class PetDog : IDog
    {
        public void Speak()
        {
            Console.WriteLine("Pet Dog says: Bow-Wow.");
        }
        public void Action()
        {
            Console.WriteLine("Pet Dogs prefer to stay at home.\n");
        }
    }
}
