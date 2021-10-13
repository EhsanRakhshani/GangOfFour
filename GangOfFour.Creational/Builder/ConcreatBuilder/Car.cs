using GangOfFour.Creational.Builder.Builder;

namespace GangOfFour.Creational.Builder.ConcreatBuilder
{
    public class Car : IBuilder
    {
        private string brandName;
        private Product.Product product;
        public Car(string brand)
        {
            product = new Product.Product();
            this.brandName = brand;
        }
        public void StartUpOperations()
        { //Starting with brandname
            product.Add(string.Format("Car Model name :{0}", this.
            brandName));
        }
        public void BuildBody()
        {
            product.Add("This is a body of a Car");
        }
        public void InsertWheels()
        {
            product.Add("4 wheels are added");
        }
        public void AddHeadlights()
        {
            product.Add("2 Headlights are added");
        }
        public void EndOperations()
        { //Nothing in this case
        }
        public Product.Product GetVehicle()
        {
            return product;
        }
    }
}