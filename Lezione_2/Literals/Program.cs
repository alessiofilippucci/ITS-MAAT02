using System.Drawing;

namespace Literals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // decimal-form literal
            int decimalFormLiteral = 101;

            // octal-form literal
            int octalFormLiteral = 0145;

            // Hexa-decimal form literal
            int hexaDecimalFormLiteral = 0xFace;

            // binary-form literal
            int binaryFormLiteral = 0b101;

            // floating-point literal
            double floatingPointLiteral = 101.230;

            // It also acts as floating-point literal
            double floatingPointLiteral2 = 0123.222;

            // character literal within single quote
            char characterFormLiteral = 'a';

            // Unicode representation
            char characterUnicodeFormLiteral = '\u0061';

            // Escape character literal
            string characterEscapeFormLiteral = "Hello,\nWorld!";

            // boolean literal
            bool booleanLiteral = true;
            bool booleanLiteral2 = false;

            // these will give compile time error
            // bool booleanLiteral3 = 0;
            // bool booleanLiteral4 = 1;
            // Console.WriteLine(booleanLiteral3);
            // Console.WriteLine(booleanLiteral4);

            Console.WriteLine(decimalFormLiteral);
            Console.WriteLine(octalFormLiteral);
            Console.WriteLine(hexaDecimalFormLiteral);
            Console.WriteLine(binaryFormLiteral);
            Console.WriteLine(floatingPointLiteral);
            Console.WriteLine(floatingPointLiteral2);
            Console.WriteLine(characterFormLiteral);
            Console.WriteLine(characterUnicodeFormLiteral);
            Console.WriteLine(characterEscapeFormLiteral);
            Console.WriteLine(booleanLiteral);
            Console.WriteLine(booleanLiteral2);
        }
    }
}