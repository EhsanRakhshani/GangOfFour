using GangOfFour.Creational.AbstractFactory.AbstractProducts;

namespace GangOfFour.Creational.AbstractFactory.AbstractFactory
{
    public interface IAnimalFactory
    {
        IDog GetDog();
        ITiger GetTiger();
    }
}
