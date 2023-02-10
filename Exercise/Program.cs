using System;

namespace Exercise
{
    internal class Program
    {
        static List<string> allowedOps = new List<string>() {
                "+",
                "-",
                "*",
                "/"
            };

        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            int? result = null;

            List<int> numbers = GetNumbers();
            string operazione = GetOperation();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == 0)
                {
                    result = numbers[i];
                    continue;
                }

                if (!Calculate(operazione, numbers[i], ref result))
                {
                    goto DivNotValid;
                }
            }

            if (result != null)
            {
                Console.WriteLine($"Result: {result}");
            }

        DivNotValid:
            {
                result = null;
                Console.WriteLine("Divisione non valida");
            }

            Console.WriteLine($"Vuoi effettuare una nuova operazione? 1 = si, 2 = no");

            if (Console.ReadLine() == "1")
                Start();
        }

        static List<int> GetNumbers()
        {
            List<int> nums = new List<int>();

            bool ended = false;

            Console.WriteLine("Inserisci dei numeri.");

            while (!ended)
            {
                int? num = null;

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

                        num = int.Parse(value);
                        nums.Add(num.Value);
                    }
                    catch
                    {
                        Console.WriteLine("Il numero inserito non è valido");
                    }
                }
                while (num == null);
            }

            return nums;
        }

        static string GetOperation()
        {
            string operazione;

            do
            {
                Console.WriteLine("Inserisci il l'operazione: (+, -, *, /)");
                operazione = Console.ReadLine();
            }
            while (!allowedOps.Contains(operazione));

            return operazione;
        }

        static bool Calculate(string operazione, int num, ref int? result)
        {
            bool completed = true;

            switch (operazione)
            {
                case "+":
                    {
                        result = Sum(result.Value, num);
                        break;
                    }
                case "-":
                    {
                        result = result - num;
                        break;
                    }
                case "*":
                    {
                        result = result * num;
                        break;
                    }
                case "/":
                    {
                        if ((result == 0 && num == 0) || num == 0)
                        {
                            completed = false;
                            break;
                        }

                        result = result / num;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Operazione '" + operazione + "' non gestita");
                        break;
                    }
            }


            return completed;
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}