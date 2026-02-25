using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Verifica_Tedesco
{
    internal class Program
    {

        //Esercizio A
        //Data una stringa, progettare e implementare una funzione
        //che consenta di valutare se contiene tutte lettere diverse 
        static bool verifica(string parola)
        {
            for (int i = 0; i < parola.Length; i++)
            {
                for (int j = i + 1; j < parola.Length; j++)
                {
                    if (parola[i] == parola[j])
                    {
                        Console.WriteLine("La stringa contiene lettere duplicate.");
                        return false;
                    }
                }
            }
            Console.WriteLine("La stringa contiene lettere diverse.");
            return true;
        }


        //Esercizio B
      //Progettare e implementare una funzione che consenta di generare
     //una nuova stringa costituita esclusivamente dalle lettere diverse della seguente stringa

        static string Genera(string parola) 
        { 
          
        
        }
        static void Main(string[] args)
        {
            string parola;
            Console.WriteLine("Inserisci una parola:");
             parola = Console.ReadLine();

            Console.WriteLine(verifica(parola));
            
        }
    }
}
