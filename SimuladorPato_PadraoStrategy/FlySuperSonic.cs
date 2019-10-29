using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPato_PadraoStrategy
{
    class FlySuperSonic : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Super Sonic zzzooooommmmmmmmm...");
        }
    }
}
