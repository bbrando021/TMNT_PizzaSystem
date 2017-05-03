using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class KraftProvolone : KraftCheese, ProvoloneIF
    {
        public KraftProvolone()
        {
            price = 2.00;
            name = "Kraft Provolone";
        }
    }
}
