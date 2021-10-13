using GangOfFour.Creational.AbstractFactory.AbstractProducts;
using System;

namespace GangOfFour.Creational.AbstractFactory.ConcreteProduct
{
    public class WildDog : IDog
    {
        public void Speak()
        {
            Console.WriteLine("Wild Dog says: Bow-Wow.");
        }
        public void Action()
        {
            Console.WriteLine("Wild Dogs prefer to roam freely in jungles.\n");
        }
    }
}
