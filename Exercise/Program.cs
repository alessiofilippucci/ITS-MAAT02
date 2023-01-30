using System.Globalization;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

                    switch (operazione)
                    {
                        case "+":
                            {
                                result = num1 + num2;
                                break;
                            }
                        case "-":
                            {
                                result = num1 - num2;
                                break;
                            }
                        case "*":
                            {
                                result = num1 * num2;
                                break;
                            }
                        case "/":
                            {
                                result = num1 / num2;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Operazione '" + operazione + "' non gestita");
                                break;
                            }
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