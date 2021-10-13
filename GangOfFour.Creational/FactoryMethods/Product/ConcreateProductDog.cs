using System;

namespace GangOfFour.Creational.FactoryMethods.Product
{
    public class ConcreateProductDog : IProductAnimal
    {
        public string Speak()
        {
            return "Dog";
        }
        public string Action()
        {
            return "Dog";
        }
    }
}
