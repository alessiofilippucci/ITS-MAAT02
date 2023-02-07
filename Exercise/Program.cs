namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> allowedOps = new List<string>() {
                "+",
                "-",
                "*",
                "/"
            };

            var restart = true;

            while (restart)
            {
                int? num1 = null;
                int? num2 = null;
                string operazione;
                int? result = null;

                List<int> nums = new List<int>();

                bool ended = false;

                Console.WriteLine("Inserisci dei numeri. Per finire l'inserimento non digitare nulla.");

                while (!ended)
                {
                    do
                    {
                        try
                        {
                            string value = Console.ReadLine();

                            if (value == "")
                            {
                                ended = true;
                                break;
                            }

                            num1 = int.Parse(value);
                            nums.Add(num1.Value);
                        }
                        catch
                        {
                            Console.WriteLine("Il numero inserito non è valido");
                        }
                    }
                    while (num1 == null);
                }

                // VERIFICA L'OPERAZIONE

                do
                {
                    Console.WriteLine("Inserisci il l'operazione: (+, -, *, /)");
                    operazione = Console.ReadLine();

                    if (allowedOps.Contains(operazione))
                    {
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

                }
                while (operazione != "+" && operazione != "-" && operazione != "*" && operazione != "/");


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