namespace Formulario.Classes.Shapes
{
    public class Square : Shape
    {
        private double _side;

        public Square()
        {
            _side = Utils.GetNumber("\nInserisci il lato:");
        }

        public override void Perimetro()
        {
            var result = _side * 4;
            Utils.PrintResult($"\nIl perimetro è: {result}");
        }

        public override void Area()
        {
            var result = Math.Pow(_side, 2);
            Utils.PrintResult($"\nL'area è: {result}");
        }
    }
}