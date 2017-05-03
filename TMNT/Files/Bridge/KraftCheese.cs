using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class KraftCheese : ProxyCheese, CheeseIF
    {
        public KraftCheese()
        {
            price = 1.50;
            name = "Kraft Cheese";
        }
    }
}
