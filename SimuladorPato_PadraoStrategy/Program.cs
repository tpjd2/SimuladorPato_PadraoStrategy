using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPato_PadraoStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard =
                new MallardDuck(
                    new FlyWithWings(),
                    new QuackSound(),
                    new DanceLikeJohnTravolta()
                );
            mallard.PerformFly();
            mallard.PerformQuack();
            mallard.PerformDance();

            Console.WriteLine();
            Console.WriteLine();

            mallard.SetFlyBehavior(new FlyNoWay());
            mallard.PerformFly();

            mallard.SetFlyBehavior(new FlySuperSonic());
            mallard.PerformFly();


            Console.ReadKey();
        }
    }
}
