namespace GangOfFour.Creational.FactoryMethods.Product
{
    public class ConcreateProductTiger : IProductAnimal
    {
        public string Speak()
        {
            return "tiger spoken";
        }
        public string Action()
        {
            return "tiger";
        }
    }
}
