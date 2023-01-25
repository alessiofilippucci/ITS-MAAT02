namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"All'indice {i} il numero è {numbers[i]}");
            }
        }
    }
}