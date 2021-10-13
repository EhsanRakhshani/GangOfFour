﻿using GangOfFour.Creational.AbstractFactory.AbstractProducts;
using System;

namespace GangOfFour.Creational.AbstractFactory.ConcreteProduct
{
    public class PetTiger : ITiger
    {
        public void Speak()
        {
            Console.WriteLine("Pet Tiger says: Halum.");
        }
        public void Action()
        {
            Console.WriteLine("Pet Tigers play in an animal circus.\n");
        }
    }
}
