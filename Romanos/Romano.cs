using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanos
{
    class Romano
    {
        public int X = 10;
        Romano I = new Romano(1);
        Romano C = new Romano(100);
        Romano D = new Romano(500);
        Romano L = new Romano(50);
        Romano M = new Romano(1000);
        
        
        public Romano(string numero)
        {

        }
        public Romano(int numero)
        {

        }

        public int calculo()
        {
            int resulta;
            resulta = X + X;
            return resulta;


        }

        public Romano()
        {

        }
    }
}
