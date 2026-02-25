using System;
using System.Diagnostics;
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
                        return true;
                    }
                }
            }
            Console.WriteLine("La stringa contiene lettere diverse.");
            return false;
        }


        //Esercizio B
        //Progettare e implementare una funzione che consenta di generare
        //una nuova stringa costituita esclusivamente dalle lettere diverse della seguente stringa


        static string Genera(string frase)
        {
            //  Rimuovo gli spazi con un for
            string fraseSenzaSpazi = "";

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ')
                {
                    fraseSenzaSpazi = fraseSenzaSpazi + frase[i];
                }
            }

            frase = fraseSenzaSpazi;

            string nuovastringa;
            for (int i = 0; i < frase.Length; i++)
            {
                if(nuovastringa.IndexOf(frase[i]) == -1)
                {
                    nuovastringa = nuovastringa + frase[i];
                }

            }

            //Esercizio C
            //E’ data una stringa contenente 20 cifre che rappresentano i lanci di un dado
            //Progettare e implementare un algoritmo che consenta di generare e visualizzare un
            //array di interi che contenga nella posizione 0 il numero di volte che è uscito 1, nella posizione 1
            //il numero di volte che è uscito 2 e così via fino alla posizione 5 che contiene il numero di volte che è uscito 6.


            static int[] ContaDadi(string lanci)
            {
                int[] contatore = new int[6];
                for (int i = 0; i < lanci.Length; i++)
                {
                    int dado = lanci[i];
                    if (dado >= 1 && dado <= 6)
                    {
                        int c = dado - 1;
                        contatore[c]++;
                    }
                }
                return contatore;
            }
            static void Main(string[] args)
            {

                //es1
                string parola;
                Console.WriteLine("Inserisci una parola:");
                parola = Console.ReadLine();

                Console.WriteLine(verifica(parola));



                //es2

                Console.WriteLine("inserisci una parola");
                string frase = Console.ReadLine();
                Console.WriteLine(Genera(frase));

                //es3

                Console.WriteLine(ContaDadi);

            }
        }
    }
}
