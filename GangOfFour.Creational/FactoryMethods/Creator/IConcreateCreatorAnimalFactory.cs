using GangOfFour.Creational.FactoryMethods.Product;

namespace GangOfFour.Creational.FactoryMethods.Creator
{
    public interface IConcreateCreatorAnimalFactory
    {
        //Remember the GoF definition which says "....Factory method lets a class
        //defer instantiation to subclasses." Following method will create a Tiger
        //or Dog But at this point it does not know whether it will get a Dog or a
        //Tiger. It will be decided by the subclasses i.e.DogFactory or TigerFactory.
        //So, the following method is acting like a factory (of creation).
        public abstract IProductAnimal CreateAnimal();
    }
}
