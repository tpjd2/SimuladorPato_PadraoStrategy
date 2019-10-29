using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPato_PadraoStrategy
{
    class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< silence >>");
        }
    }
}
