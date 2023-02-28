namespace Formulario.Classes
{
    public abstract class Shape
    {
        public virtual void MakeChoice()
        {
            Console.WriteLine($"\nQuale formula si vuole usare");
            Console.WriteLine($"1 - Area");
            Console.WriteLine($"2 - Perimetro");

            Console.WriteLine();

            string operazione = Console.ReadLine();

            switch (operazione)
            {
                case "1":
                    {
                        Area();
                        break;
                    }
                case "2":
                    {
                        Perimetro();
                        break;
                    }
                default:
                    {
                        Utils.PrintError("\nOpzione scelta non valida");
                        MakeChoice();
                        return;
                    }
            }

            Restart();
        }

        public void Restart()
        {
            Utils.PrintMessage("\nScelta nuova formula? (y = si, n = No)");

            bool restart = Console.ReadLine() == "y";

            if (restart)
                MakeChoice();
        }

        public abstract void Perimetro();
        public abstract void Area();
    }
}
