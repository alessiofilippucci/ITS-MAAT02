using Formulario.Classes;

namespace Formulario
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Formulario Euclide & Co. 2023");

            Start();
        }

        static void Start()
        {
            MyFormulario formulario = new MyFormulario();

            formulario.ChooseShape();

            Console.WriteLine($"\nChiudere il formulario? (y = si, n = No)");

            bool close = Console.ReadLine() == "y";

            if(!close)
                Start();
        }
    }

}