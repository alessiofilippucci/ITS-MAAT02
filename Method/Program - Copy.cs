using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;

namespace Method
{
    internal class Program
    {
        static int counter = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("APPLICATION STARTED");

            Start();

            Console.WriteLine("APPLICATION ENDED");
        }

        static void Start()
        {
            counter++;

            Console.WriteLine($"Start {counter} opened");

            var text = Console.ReadLine();

            if (text == "")
                return;

            int lenght = CalcolaLunghezza(text);

            Console.WriteLine(lenght);

            Start();

            Console.WriteLine($"Start {counter} closed");
        }

        static int CalcolaLunghezza(string text)
        {
            return text.Length;
        }
    }
}