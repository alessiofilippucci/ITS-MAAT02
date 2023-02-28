namespace Formulario.Classes.Shapes
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle()
        {
            _radius = Utils.GetNumber("\nInserisci il raggio:");
        }

        public override void MakeChoice()
        {
            Console.WriteLine($"\nQuale formula si vuole usare");
            Console.WriteLine($"1 - Area");
            Console.WriteLine($"2 - Circonferenza");

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

        public override void Perimetro()
        {
            var result = 2.0 * Math.PI * _radius;
            Utils.PrintResult($"\nLa circonferenza è: {result}");
        }

        public override void Area()
        {
            var result = Math.PI * Math.Pow(_radius, 2.0);
            Utils.PrintResult($"\nL'area è: {result}");
        }
    }
}
