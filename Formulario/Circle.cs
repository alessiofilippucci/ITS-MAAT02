namespace Formulario
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double Perimetro()
        {
            var result = 2.0 * Math.PI * _radius;
            Console.WriteLine($"Perimetro of Triangle: {result}");
            return result;
        }

        public override double Area()
        {
            var result = Math.PI * Math.Pow(_radius, 2.0);
            Console.WriteLine($"Area of Triangle: {result}");
            return result;
        }
    }
}
