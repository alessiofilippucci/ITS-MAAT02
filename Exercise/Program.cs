using System.Globalization;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Inserisci il tuo nome");

            //string nome;

            //nome = Console.ReadLine();

            //if (nome == "Alessio")
            //{
            //    Console.WriteLine("Ehi ciao, bentornato!!");

            //    Console.WriteLine("Adesso inserisci la tua data di nascita");

            //    DateTime dob;

            //    // formato gg/mm/yyyy
            //    string dobText = Console.ReadLine();

            //    try
            //    {
            //        dob = DateTime.Parse(dobText);

            //        // DateTime.Now => data attuale

            //        if (scrivi condizione)
            //        {
            //            Console.WriteLine("Ok " + eta + ", puoi continuare...");
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Non è un numero valido '" + dobText + "'");
            //    }
            //}

            int num1 = 0;
            int num2 = 0;
            string operazione = "";
            int? result = null;

            try
            {
                Console.WriteLine("Inserisci il primo numero:");
                num1 = int.Parse(Console.ReadLine());

                try
                {
                    Console.WriteLine("Inserisci il secondo numero:");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Inserisci il l'operazione: (+, -, *, /)");
                    operazione = Console.ReadLine();

                    if (operazione == "+")
                    {
                        result = num1 + num2;
                    }
                    else if (operazione == "-")
                    {
                        result = num1 - num2;
                    }
                    else if (operazione == "*")
                    {
                        result = num1 * num2;
                    }
                    else if (operazione == "/")
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Operazione '" + operazione + "' non gestita");
                    }
                }
                catch
                {
                    Console.WriteLine("Il secondo numero non è valido '" + num2 + "'");
                }
            }
            catch
            {
                Console.WriteLine("Il primo numero non è valido '" + num1 + "'");
            }

            if(result != null)
            {
                Console.WriteLine($"{num1} {operazione} {num2} = {result}");
            }
        }
    }
}