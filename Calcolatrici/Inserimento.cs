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
            int op=0;
            string tem;
            //varibile che ci serve per uscire dal controllo
            bool controllo=true;
            do
            {

                Console.WriteLine("Puoi scegliere una delle seguenti operezioni scrivendo uno dei vari metodi indicati \n" +
                                    "1 + somma "+ System.Environment.NewLine+
                                    "2 - sotrazione " + System.Environment.NewLine+
                                    "3 * moltiplicazione " + System.Environment.NewLine+
                                    "4 / divisione " + System.Environment.NewLine+
                                    "5 % divisione con resto ");
                Console.WriteLine("Selezionare il numero del operazione che si desidera fare : ");
                tem = Console.ReadLine();
                tem = tem.ToUpper();
                //controllo se la varibile op è tra le possibili scelte ho fatto questa serie di or perchè cosi lutente puo anche srcrivere in vari metodi
                if (tem == "1" || tem == "+"|| tem == "SOMMA")
                {
                    op = 1;
                   controllo=false;
                }
                else if (tem == "2" || tem == "-" || tem == "SOTRAZIONE" )
                {
                    op = 2;
                    controllo = false;
                }
                else if (tem == "3" || tem == "*" || tem == "MOLTIPLICAZIONE" )
                {
                    op = 3;
                    controllo = false;
                }
                else if (tem == "4" || tem == "/" || tem == "DIVISIONE" )
                {
                    op = 4;
                    controllo = false;
                }
                else if (tem == "5" || tem == "%" || tem == "DIVISIONE CON RESTO" )
                {
                    op = 5;
                    controllo = false;
                }
                else 
                {
                    Console.WriteLine("Il valore inserito non è corretto quindi rinserisci ");
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
                Console.WriteLine("Inserisci il numero e premi invio");
                temp = Console.ReadLine();
                if (!Int32.TryParse(temp, out num1))
                    Console.WriteLine("Il valore inserito non è corretto quindi rinserisci");
            } while (!Int32.TryParse(temp, out num1));
            return num1;
        }
    }
}
