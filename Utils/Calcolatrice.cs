namespace Utils
{
    public class Calcolatrice
    {
        static public int StaticMethod(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Addizione(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sottrazione(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Moltiplicazione(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divisione(int num1, int num2)
        {
            if (num2 == 0)
                throw new Exception("Divisione non fattibile");

            return num1 / num2;
        }

        public int Modulo(int num1, int num2)
        {
            return num1 % num2;
        }
    }
}
