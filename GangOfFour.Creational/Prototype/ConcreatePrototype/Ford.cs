using GangOfFour.Creational.Prototype.Prototype;

namespace GangOfFour.Creational.Prototype.ConcreatePrototype
{
    public class Ford : BasicCar
    {
        public Ford(string m)
        {
            ModelName = m;
        }
        public override BasicCar Clone()
        {
            return (Ford)this.MemberwiseClone();
        }
    }
}
