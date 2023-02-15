using Formulario;
using System;

namespace Calcolatrice
{
    public class Formulario
    {
        Shape shape = new Shape();

        public Formulario()
        {
        }

        private int SetNumber()
        {
            Console.WriteLine($"\nInserisci un numero intero:");

            string _num = Console.ReadLine();

            try
            {
                int num = int.Parse(_num);
                return num;
            }
            catch
            {
                PrintError($"Il numero inserito non è valido ({_num})");
                return SetNumber();
            }
        }

        public void ChooseShape()
        {
            Console.WriteLine($"\nQuale figura si vuole usare");
            Console.WriteLine($"1 - Triangolo");
            Console.WriteLine($"2 - Quadrato");
            Console.WriteLine($"3 - Rettangolo");
            Console.WriteLine($"4 - Cerchio");

            Console.WriteLine();

            string operazione = Console.ReadLine();

            switch (operazione)
            {
                case "1":
                    {
                        shape = new Triangle();
                        break;
                    }
                case "2":
                    {
                        shape = new Square();
                        break;
                    }
                case "3":
                    {
                        shape = new Rectangle();
                        break;
                    }
                case "4":
                    {
                        shape = new Circle();
                        break;
                    }
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpzione scelta non valida");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        ChooseShape();
                        break;
                    }
            }
        }

        private void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
