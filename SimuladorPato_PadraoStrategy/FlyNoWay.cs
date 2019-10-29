﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPato_PadraoStrategy
{
    class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
