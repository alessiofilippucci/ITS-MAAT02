namespace Formulario.Classes.Shapes
{
    public class Rectangle : Shape
    {
        private double _width;
        private double _height;

        public Rectangle()
        {
            _width = Utils.GetNumber("\nInserisci la base:");
            _height = Utils.GetNumber("\nInserisci l'altezza:");
        }

        public override void Perimetro()
        {
            var result = (_width + _height) * 2;
            Utils.PrintResult($"\nIl perimetro è: {result}");
        }

        public override void Area()
        {
            var result = _width * _height;
            Utils.PrintResult($"\nL'area è: {result}");
        }
    }
}
