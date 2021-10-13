using GangOfFour.Creational.FactoryMethods.Product;

namespace GangOfFour.Creational.FactoryMethods.Creator
{
    public class ConcreateCreatorTigerFactory : IConcreateCreatorAnimalFactory
    {
        public IProductAnimal CreateAnimal()
        {
            //Creating a Tiger
            return new ConcreateProductTiger();
        }
    }
}
