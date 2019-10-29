using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPato_PadraoStrategy
{
    abstract class Duck
    {
        IFlyBehavior flyBehavior;
        IQuackBehavior quackBehavior;
        IDanceBehavior danceBehavior;

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, IDanceBehavior danceBehavior)
        {
            this.flyBehavior = flyBehavior;
            this.quackBehavior = quackBehavior;
            this.danceBehavior = danceBehavior;
        }

        public abstract void Display();

        public void PerformFly()
        {
            this.flyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }

        public void PerformQuack()
        {
            this.quackBehavior.Quack();
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }

        public void PerformDance()
        {
            this.danceBehavior.Dance();
        }

        public void SetDanceBehavior(IDanceBehavior danceBehavior)
        {
            this.danceBehavior = danceBehavior;
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
