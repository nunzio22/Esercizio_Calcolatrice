using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrici
{

    class Operazione
    {
        public int n1 { get; set; }
        public int n2 { get; set; }
        public int op { get; set; }
        public int rest
        {
            get
            {
                int rest = 0;
                if (n2 == 0 || n2 > n1)
                {
                    rest = n2 % n1;
                }
                else rest = n1 % n2;
                return rest;
            }
        }
        public int ris
        {
            get
            {
                int ris = 0;

                    if (op == 1)
                    {
                        ris = somma(n1, n2);
                    }
                    else if (op == 2)
                    {
                        ris = sotrazione(n1, n2);
                    }
                    else if (op == 3)
                    {
                        ris = moltiplicazione(n1, n2);
                    }
                    else if (op == 4|| op == 5)
                    {
                        ris = divisione(n1, n2);
                    }
                    return ris;
            }
        }

        private int somma(int n1, int n2)
        {
            int ris = 0;
            ris = n1 + n2;
            return ris;
        }

        private int sotrazione(int n1, int n2)
        {
            int ris = 0;
            ris = n1 - n2;
            return ris;
        }

        private int moltiplicazione(int n1, int n2)
        {
            int ris = 0;
            ris = n1 * n2;
            return ris;
        }

        private int divisione(int n1, int n2)
        {
            int ris = 0;
            if (n2 == 0 || n2 > n1)
            {
                ris = n2 / n1;
            }
            else ris = n1 / n2;
            return ris;
        }

    }
}
