using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPato_PadraoStrategy
{
    class MallardDuck : Duck
    {
        public MallardDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, IDanceBehavior danceBehavior)
            : base(flyBehavior, quackBehavior, danceBehavior)
        {

        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck!");
        }
    }
}
