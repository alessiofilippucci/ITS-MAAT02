namespace Formulario.Classes
{
    public static class Utils
    {
        public static int GetNumber(string message = "\nInserisci un numero intero:")
        {
            if (!string.IsNullOrEmpty(message))
                Console.WriteLine(message);

            string _num = Console.ReadLine();

            try
            {
                int num = int.Parse(_num);
                return num;
            }
            catch
            {
                PrintError($"Il valore inserito non è valido ({_num})");
                return GetNumber();
            }
        }

        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void PrintResult(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void PrintMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(message);
        }
    }
}
