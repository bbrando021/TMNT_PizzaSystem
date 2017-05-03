using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class KraftMozzarella : KraftCheese, MozzarellaIF
    {
        public KraftMozzarella()
        {
            price = 2.75;
            name = "Kraft Mozzarella";
        }
    }
}
