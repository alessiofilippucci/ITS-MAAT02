namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "ciao";

            char[] text2 = new char[4];

            text2[0] = 'C';
            text2[1] = 'i';
            text2[2] = 'a';
            text2[3] = 'o';

            //Console.WriteLine(text[0]);

            int[] numbers = new int[5];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            //int[] numbers2 = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine($"L'array contiene {numbers.Length} elementi");

            Console.WriteLine($"Quale elemento vuoi conoscere? (indice)");

            var index = int.Parse(Console.ReadLine());

            if (index >= 0)
            {
                if (index < numbers.Length)
                    Console.WriteLine($"All'indice {index} il numero è {numbers[index]}");
                else
                    Console.WriteLine($"L'indice {index} non esiste");
            }
            else
                Console.WriteLine($"L'indice non può essere negativo");

            Console.WriteLine($"All'indice 0 il numero è {numbers[0]}");
            Console.WriteLine($"All'indice 1 il numero è {numbers[1]}");
            Console.WriteLine($"All'indice 2 il numero è {numbers[2]}");
            Console.WriteLine($"All'indice 3 il numero è {numbers[3]}");
            Console.WriteLine($"All'indice 4 il numero è {numbers[4]}");
        }
    }
}