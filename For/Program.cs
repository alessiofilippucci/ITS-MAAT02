using static System.Runtime.InteropServices.JavaScript.JSType;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            int?[] numbersPari = new int?[numbers.Length];
            int?[] numbersDispari = new int?[numbers.Length];

            int counterPari = 0;
            int counterDispari = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int? num = null;

                while (num == null)
                {
                    try
                    {
                        Console.WriteLine("Inserisci un numero:");
                        num = int.Parse(Console.ReadLine());
                        numbers[i] = num.Value;

                        if (num % 2 == 0)
                        {
                            numbersPari[i] = num.Value;
                            counterPari++;
                        }
                        else
                        {
                            numbersDispari[i] = num.Value;
                            counterDispari++;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Il numero non è valido");
                    }
                }
            }

            //Console.WriteLine("Ci sono " + counterPari + " numeri PARI e sono:");
            //Console.WriteLine("Ci sono {0} numeri PARI e sono", counterPari);
            Console.WriteLine($"Ci sono {counterPari} numeri PARI e sono:");

            for (int i = 0; i < numbersPari.Length; i++)
            {
                if (numbersPari[i] != null)
                {
                    Console.WriteLine($"{numbersPari[i]}");
                }
            }

            Console.WriteLine($"Ci sono {counterDispari} numeri DISPARI e sono:");

            for (int i = 0; i < numbersDispari.Length; i++)
                if (numbersDispari[i] != null)
                    Console.WriteLine($"{numbersDispari[i]}");





            // STATEMENT continue

            //string text = "Ciao, sono Alessio!";

            //for (int i = 0; i < text.Length; i++)
            //{
            //    var character = text[i];

            //    if (i >= 8 && i <= 10)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(character);
            //}
        }
    }
}