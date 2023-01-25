namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var restart = true;

            while (restart)
            {
                int? num1 = null;
                int? num2 = null;
                string operazione = "";
                int? result = null;

                // VERIFICA PRIMO NUMERO

                while (num1 == null)
                {
                    try
                    {
                        Console.WriteLine("Inserisci il primo numero:");
                        num1 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Il primo numero non è valido '" + num1 + "'");
                    }
                }

                // VERIFICA SECONDO NUMERO

                while (num2 == null)
                {
                    try
                    {
                        Console.WriteLine("Inserisci il secondo numero:");
                        num2 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Il secondo numero non è valido '" + num2 + "'");
                    }
                }

                // VERIFICA L'OPERAZIONE

                while (operazione != "+" && operazione != "-" && operazione != "*" && operazione != "/")
                {
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

                if (result != null)
                {
                    Console.WriteLine($"{num1} {operazione} {num2} = {result}");
                }


                Console.WriteLine($"Vuoi effettuare una nuova operazione? 1 = si, 2 = no");

                restart = Console.ReadLine() == "1";
            }
        }
    }
}