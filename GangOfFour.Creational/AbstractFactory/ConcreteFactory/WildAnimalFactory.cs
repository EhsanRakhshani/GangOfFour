using GangOfFour.Creational.AbstractFactory.AbstractFactory;
using GangOfFour.Creational.AbstractFactory.AbstractProducts;
using GangOfFour.Creational.AbstractFactory.ConcreteProduct;

namespace GangOfFour.Creational.AbstractFactory.ConcreteFactory
{
    public class WildAnimalFactory : IAnimalFactory
    {
        public IDog GetDog()
        {
            return new WildDog();
        }
        public ITiger GetTiger()
        {
            return new WildTiger();
        }
    }
}
