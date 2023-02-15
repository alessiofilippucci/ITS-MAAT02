namespace Formulario
{
    public class Square : Shape
    {
        private double _side;

        public Square(double side = 0)
        {
            _side = side;
        }

        public override double Perimetro()
        {
            var result = _side * 4;
            Console.WriteLine($"Perimetro of Square: {result}");
            return result;
        }

        public override double Area()
        {
            var result = _side * _side;
            Console.WriteLine($"Area of Square: {result}");
            return result;
        }
    }
}
