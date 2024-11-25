using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice
{
    class Calculatrice
    {
        private double resultat;
        private double n1;
        private double n2;

        public void Addition()
        {
            resultat = n1 + n2;
        }

        public void Soustraction()
        {
            resultat = n1 - n2;
        }

        public void Multiplication()
        {
            resultat = n1 * n2;
        }

        public void Division()
        {
            if(n2 == 0)
            {
                resultat = 0;
            }else
            {
                resultat = n1 / n2;
            }
        }

        public void Setn1(double n)
        {
            n1 = n;
        }

        public void Setn2(double n)
        {
            n1 = n;
        }

        public double GetResultat()
        {
            return resultat;
        }
    }
}
