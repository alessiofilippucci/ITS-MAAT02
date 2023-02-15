namespace Calcolatrice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Calcolatrice (c)Sharp Inc. 2023");

            Start();
        }

        static void Start()
        {
            Calculator calcolatrice = new Calculator();

            calcolatrice.Calculate();

            calcolatrice.PrintResult();

            Console.WriteLine($"\nChiudere la calcolatrice? (y = si, n = No)");

            bool close = Console.ReadLine() == "y";

            if(!close)
                Start();
        }
    }

}