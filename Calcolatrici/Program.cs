using MyOperazioni;
using MyInserimento;
using System;

namespace Calcolatrici
{
    class Program
    {
        enum Operazione
        {
            provaEnum,
            provaEnum2
        }
        static void Main(string[] args)
        {
            int Op;
            int n1;
            int n2;
            int ris=0;
            string risp="";
            Console.WriteLine("Benvenuti in Umana Calculetor ");
            do
            {
                Console.WriteLine("scegli l'operazione che si vuole effetuare");
                Op = Inserimento.InsertOp();
                Console.WriteLine("L'operazione selezionata è la N:" + Op);
                Console.WriteLine(Op);
                if (risp == "Si" || risp == "si")
                {
                    n1 = ris;
                }     
                else
                {
                    n1 = Inserimento.insertN();
                }
                n2 = Inserimento.insertN();
                if (Op == 5)
                {
                    Operazioni.resto(n1,
                                     n2);
                }
                else
                {
                    ris = Operazioni.op(n1, n2, Op);
                    Console.WriteLine("Il risultato è:" + ris);
                    Console.ReadLine();
                }
                Console.WriteLine("Vuoi vare altre operazioni?");
                risp = Console.ReadLine();

                if (risp == "Si" || risp == "si")
                    ;
                else
                    break;
                Console.WriteLine("Vuoi tenere in memoria il risultato?");
                risp = Console.ReadLine();


            } while (true);





        }
    }
}
