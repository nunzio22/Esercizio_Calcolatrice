using MyOperazioni;
using MyInserimento;
using System;

namespace Calcolatrici
{
    class Program
    {
        /*
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

        */
        static void Main(string[] args)
        {
            // Creazione oggeto Operazione 
            Operazione ris = new Operazione();
            //creazione variabile controllo che mi è neccesaria per le risposte del utete alla fine del operazione
            string risp = "";
            Console.WriteLine("Benvenuti in Umana Calculetor ");
            do
            {
                Console.WriteLine("scegli l'operazione che si vuole effetuare");
                //inserisco sulla variabile operatore del oggetto operazione
                ris.op = Inserimento.InsertOp();
                Console.WriteLine("L'operazione selezionata è la N:" + ris.op);
                //controllo se l'utente desidera recuperare il risultato della vecchia operazione è usarlo come primo operando
                if (risp == "Si" || risp == "si")
                {
                    ris.n1 = ris.ris;
                }
                else
                {
                    //Lancio la funzione di insermento del numero inserendo nella primo numero del oggetto ciò che l'utente digita nella funzione inserN
                    ris.n1 = Inserimento.insertN();
                }
                ris.n2 = Inserimento.insertN();
                //caso speciale se si sceglie la quinta opzione ovvero divisione con resto il codice mostrerà il risultato dentro la variabile ris del oggetto ed il resto dentro la sua varibiale del oggetto
                if (ris.op == 5)
                {
                    Console.WriteLine("Il risultato è:" + ris.ris+"\n Con il resto di : "+ris.rest);
                }
                else
                {
                    // stampa il risultato come spigato prima 
                    Console.WriteLine("Il risultato è:" + ris.ris);
                    Console.ReadLine();
                }
                //si chiede al utente se desidera fare altre operazioni 
                Console.WriteLine("Vuoi vare altre operazioni?");
                risp = Console.ReadLine();
                //se risponde di si il codice continua se risponde in altro modo tramite il brek esce dal do whille ponendo fine al esecuzione
                if ((risp == "Si") || (risp == "si"))
                    ;
                    else break;
                Console.WriteLine("Vuoi tenere in memoria il risultato?");
                risp = Console.ReadLine();
            } while (true);
        }



        }
    }
