namespace Formulario.Classes.Shapes
{
    public class Triangle : Shape
    {
        private double _side1;
        private double _side2;
        private double _side3;
        private double _height;

        public Triangle()
        {
            Console.WriteLine($"*(Il primo lato verrà utilizzato come base)");

            _side1 = Utils.GetNumber("\nInserisci il primo lato:");
            _side2 = Utils.GetNumber("\nInserisci il secondo lato:");
            _side3 = Utils.GetNumber("\nInserisci il terzo lato:");
            _height = Utils.GetNumber("\nInserisci l'altezza:");
        }

        public override void Perimetro()
        {
            var result = _side1 + _side2 + _side3;
            Utils.PrintResult($"\nIl perimetro è: {result}");
        }

        public override void Area()
        {
            var result = _side1 * _height / 2;
            Utils.PrintResult($"\nL'area è: {result}");
        }
    }
}
