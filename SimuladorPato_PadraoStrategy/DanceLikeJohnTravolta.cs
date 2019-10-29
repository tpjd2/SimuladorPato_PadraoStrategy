using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPato_PadraoStrategy
{
    class DanceLikeJohnTravolta : IDanceBehavior
    {
        public void Dance()
        {
            Console.WriteLine("Saturday Night Fever ....");
        }
    }
}
