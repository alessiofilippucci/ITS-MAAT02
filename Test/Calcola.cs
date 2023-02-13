namespace Test
{
    internal class Calcola
    {
        private List<int> numbers = new List<int>();

        public Calcola(int _numberCount = 25)
        {
            if (_numberCount <= 0)
                throw new ArgumentException("_numberCount must be positive");
            else if (_numberCount < 2)
                throw new Exception("almost two numbers");

            for (int i = 0; i < _numberCount; i++)
            {
                int num = ImpostaNumero();
                numbers.Add(num);
            }
        }

        private int ImpostaNumero()
        {
            Console.WriteLine($"Inserisci il {numbers.Count + 1}° numero:");

            string _num = Console.ReadLine();

            try
            {
                int num = int.Parse(_num);
                return num;
            }
            catch
            {
                Console.WriteLine($"Il {numbers.Count + 1}° ({_num}) numero errato");

                return ImpostaNumero();
            }
        }

        public int Somma()
        {
            return numbers[0] + numbers[1];
        }

        public int Sottrai()
        {
            return numbers[0] - numbers[1];
        }

        public int Moltiplica()
        {
            return numbers[0] * numbers[1];
        }

        public int Dividi()
        {
            return numbers[0] / numbers[1];
        }
    }
}
