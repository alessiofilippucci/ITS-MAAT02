﻿using System.Globalization;

namespace ConditionalStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il tuo nome");

            string nome;

            nome = Console.ReadLine();

            if (nome == "Alessio")
            {
                Console.WriteLine("Ehi ciao, bentornato!!");

                Console.WriteLine("Adesso inserisci la tua data di nascita");

                DateTime dob;

                // formato gg/mm/yyyy
                string dobText = Console.ReadLine();

                try
                {
                    dob = DateTime.Parse(dobText);

                    // DateTime.Now => data attuale

                    if (scrivi condizione)
                    {
                        Console.WriteLine("Ok " + eta + ", puoi continuare...");
                    }
                }
                catch
                {
                    Console.WriteLine("Non è un numero valido '" + dobText + "'");
                }
            }
        }
    }
}