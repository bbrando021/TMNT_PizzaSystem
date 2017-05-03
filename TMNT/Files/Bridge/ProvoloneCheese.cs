using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class ProvoloneCheese : ProxyCheese, ProvoloneIF
    {
        public ProvoloneCheese pc;

        public ProvoloneCheese()
        {
            price = 1.50;
            name = "Provolone Cheese";
        }
    }
}
