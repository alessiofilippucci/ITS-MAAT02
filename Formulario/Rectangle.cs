namespace Formulario
{
    public class Rectangle : Shape
    {
        private double _width;
        private double _height;

        public Rectangle(double width = 0, double height = 0)
        {
            _width = width;
            _height = height;
        }

        public override double Perimetro()
        {
            var result = _width * 2 + _height * 2;
            Console.WriteLine($"Perimetro of Rectangle: {result}");
            return result;
        }

        public override double Area()
        {
            var result = _width * _height;
            Console.WriteLine($"Area of Rectangle: {result}");
            return result;
        }
    }
}
