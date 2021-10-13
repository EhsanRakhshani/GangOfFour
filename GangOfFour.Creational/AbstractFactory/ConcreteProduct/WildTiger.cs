﻿using GangOfFour.Creational.AbstractFactory.AbstractProducts;
using System;

namespace GangOfFour.Creational.AbstractFactory.ConcreteProduct
{
    public class WildTiger : ITiger
    {
        public void Speak()
        {
            Console.WriteLine("Wild Tiger says: Halum.");

        }
        public void Action()
        {
            Console.WriteLine("Wild Tigers prefer hunting in jungles.\n");
        }
    }
}
