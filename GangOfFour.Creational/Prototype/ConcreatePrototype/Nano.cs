using GangOfFour.Creational.Prototype.Prototype;

namespace GangOfFour.Creational.Prototype.ConcreatePrototype
{
    public class Nano : BasicCar
    {
        public Nano(string m)
        {
            ModelName = m;
        }
        public override BasicCar Clone()
        {
        return (Nano)this.MemberwiseClone();//shallow Clone
        }
    }
}
