using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOperazioni
{
    class Operazioni
    {
        public static int op(int num1,int num2,int op)
        {
            int ris=0;
            bool controllo = true;

            do
            { if (op == 1)
            {
                    ris = somma(num1, num2);
                    controllo = false;
            }
            else if (op == 2)
            {
                    ris = sotrazione(num1, num2);
                    controllo = false;
            }
            else if (op == 3)
            {
                    ris = moltiplicazione(num1, num2);
                    controllo = false;
            }
            else if (op == 4)
            {
                ris = divisione(num1,num2);
                controllo = false;
            }

        } while (controllo);
            return ris;
        }

        public static int somma(int n1, int n2)
        {
            int ris = 0;
            ris = n1 + n2;
            return ris;
        }
        public static int sotrazione(int n1, int n2)
        {
            int ris = 0;
            ris = n1 - n2;
            return ris;
        }
        public static int moltiplicazione(int n1, int n2)
        {
            int ris = 0;
            ris = n1 * n2;
            return ris;
        }
        public static int divisione(int n1, int n2)
        {
            int ris = 0;
            if (n2 == 0)
                Console.WriteLine("L'operazione è impossibile quindi il risultato sarà settato a 0");
            else ris = n1 / n2;
            return ris;
        }
        public static void resto(int n1,int n2)
        {
            Console.WriteLine(" Il risultato è:" + n1 / n2+"\n");
            Console.WriteLine(" con il resto di:" + n1 % n2);
            Console.ReadLine();
            return;
        }
    }
}
