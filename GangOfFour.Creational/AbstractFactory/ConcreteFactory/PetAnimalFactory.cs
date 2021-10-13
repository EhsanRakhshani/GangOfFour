using GangOfFour.Creational.AbstractFactory.AbstractFactory;
using GangOfFour.Creational.AbstractFactory.AbstractProducts;
using GangOfFour.Creational.AbstractFactory.ConcreteProduct;

namespace GangOfFour.Creational.AbstractFactory.ConcreteFactory
{
    public class PetAnimalFactory : IAnimalFactory
    {
        public IDog GetDog()
        {
            return new PetDog();
        }
        public ITiger GetTiger()
        {
            return new PetTiger();
        }
    }
}
