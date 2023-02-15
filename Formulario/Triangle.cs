namespace Formulario
{
    public class Triangle : Shape
    {
        private double _side1;
        private double _side2;
        private double _side3;
        private double _height;

        public Triangle(double side1 = 0, double side2 = 0, double side3 = 0, double height = 0)
        {
            Console.WriteLine($"*(First side will be used as width)");
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
            _height = height;
        }

        public override double Perimetro()
        {
            var result = _side1+ _side2 + _side3;
            Console.WriteLine($"Perimetro of Triangle: {result}");
            return result;
        }

        public override double Area()
        {
            var result = _side1 * _height / 2;
            Console.WriteLine($"Area of Triangle: {result}");
            return result;
        }
    }
}
