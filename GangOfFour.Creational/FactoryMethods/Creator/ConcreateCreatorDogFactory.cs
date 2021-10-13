using GangOfFour.Creational.FactoryMethods.Product;

namespace GangOfFour.Creational.FactoryMethods.Creator
{
    public class ConcreateCreatorDogFactory : IConcreateCreatorAnimalFactory
    {
        public IProductAnimal CreateAnimal()
        {
            //Creating a Dog
            return new ConcreateProductDog();
        }
    }
}
