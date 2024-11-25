using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice
{
    class Calculatrice
    {
        public double Addition(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Soustraction(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiplication(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Division(double n1, double n2)
        {
            if(n2 == 0)
            {
                return 0;
            }else
            {
                return n1 / n2;
            }
        }
    }
}
