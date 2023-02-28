using Formulario.Classes.Shapes;

namespace Formulario.Classes
{
    public class MyFormulario
    {
        Shape shape;

        public MyFormulario()
        {
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
                        Utils.PrintError("\nOpzione scelta non valida");
                        ChooseShape();
                        return;
                    }
            }
            
            shape.MakeChoice();
        }
    }
}
