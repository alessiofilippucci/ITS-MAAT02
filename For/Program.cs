namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

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
                    }
                    catch
                    {
                        Console.WriteLine("Il numero non è valido");
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"All'indice {i} il numero è {numbers[i]}");
            }
        }
    }
}