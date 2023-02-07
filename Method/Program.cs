namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;

            var result = Sum(num1, num2);

            Console.WriteLine(result);

            PrintSentence();

            result = Add(num1, num2);

            Console.WriteLine(result);

            int num3 = 5;

            result = Add(num1, num2, num3);

            Console.WriteLine(result);

            double num4 = 6;
            double num5 = 7;
            double num6 = 7;

            var result2 = Add(num4, num5, num6);

            Console.WriteLine(result2);

        }

        // Here Sum() method asks for two
        // parameters from the user and
        // calculates the sum of these
        // and finally returns the result.
        static int Sum(int x, int y)
        {

            // there are two local variables
            // 'a' and 'b' where 'a' is assigned
            // the value of parameter 'x' and
            // 'b' is assigned the value of
            // parameter 'y'
            int a = x;
            int b = y;

            // The local variable calculates
            // the sum of 'a' and 'b'
            // and returns the result
            // which is of 'int' type.
            int result = a + b;

            return result;
        }

        // Here the method 'PrintSentence()'
        // neither takes any parameter nor
        // returns any value. It simply performs
        // the required operations and prints
        // the result within it.
        static void PrintSentence()
        {

            Console.WriteLine("No parameters and return type void");
        }

        // adding two integer values.
        static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        // adding three integer values.
        static int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        // adding three double values.
        static double Add(double a, double b, double c)
        {
            double sum = a + b + c;
            return sum;
        }
    }
}