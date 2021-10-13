namespace GangOfFour.Creational.Builder.Builder
{
    // Builders common interface
    public interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void InsertWheels();
        void AddHeadlights();
        void EndOperations();
        Product.Product GetVehicle();
    }

}
