using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInserimento
{
    class Inserimento
    {
        public static int InsertOp()
        {
            int op;
            string tem;
            //varibile che ci serve per uscire dal controllo
            bool controllo=true;
            do
            {

                Console.WriteLine("Puoi scegliere una delle seguenti operezioni \n" +
                                    "1 somma \n"+
                                    "2 sotrazione \n"+
                                    "3 moltiplicazione \n"+
                                    "4 divisione \n"+
                                    "5 divisione con resto");
                tem = Console.ReadLine();
                if (!Int32.TryParse(tem, out op))
                    Console.WriteLine("Il valore inserito non è corretto quindi rinserisci");
                if (op==1 || op==2||op==3||op==4||op==5)
                {
                   controllo=false;
                }
                else 
                {
                    Console.WriteLine("Hai sbagliato capra");
                }
            } while (controllo);
            

            return op;
        }
        public static int insertN()
        {
            //creazioni delle variabili necessarie per l'inserimento
            string temp;
            int num1;
            do
            {
                Console.WriteLine("Caro utente inserisci il numero e premi invio");
                temp = Console.ReadLine();
                //succes = Int32.TryParse(concatenazione, out num2);  volendo si puo usare questa istruzione inserendo 
                if (!Int32.TryParse(temp, out num1))
                    Console.WriteLine("Il valore inserito non è corretto quindi rinserisci");
            } while (!Int32.TryParse(temp, out num1));
            return num1;
        }
    }
}
