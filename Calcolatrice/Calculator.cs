namespace Calcolatrice
{
    public class Calculator
    {
        int num1;
        int num2;
        string operationSymbol;

        private double result;

        public Calculator()
        {
            Reset();

            num1 = SetNumber();
            num2 = SetNumber();
        }

        public double GetResult()
        {
            return result;
        }

        public void PrintResult()
        {
            Console.WriteLine($"\n{num1} {operationSymbol} {num2} = {result}");
        }

        public void Reset()
        {
            num1 = 0;
            num2 = 0;
            operationSymbol = "";
        }

        private int SetNumber()
        {
            Console.WriteLine($"\nInserisci un numero intero:");

            string _num = Console.ReadLine();

            try
            {
                int num = int.Parse(_num);
                return num;
            }
            catch
            {
                PrintError($"Il numero inserito non è valido ({_num})");
                return SetNumber();
            }
        }

        private int Addizione()
        {
            return num1 + num2;
        }

        private int Sottrazione()
        {
            return num1 - num2;
        }

        private int Moltiplicazione()
        {
            return num1 * num2;
        }

        private int Divisione()
        {
            return num1 / num2;
        }

        private double DivisioneConResto()
        {
            return num1 / (double)num2;
        }

        public void Calculate()
        {
            Console.WriteLine($"\nQuale operazione si vuole effettuare");
            Console.WriteLine($"1 - Addizione");
            Console.WriteLine($"2 - Sottrazione");
            Console.WriteLine($"3 - Moltiplicazione");
            Console.WriteLine($"4 - Divisione");

            Console.WriteLine();

            string operazione = Console.ReadLine();

            switch (operazione)
            {
                case "1":
                    {
                        operationSymbol = "+";
                        result = Addizione();
                        break;
                    }
                case "2":
                    {
                        operationSymbol = "-";
                        result = Sottrazione();
                        break;
                    }
                case "3":
                    {
                        operationSymbol = "*";
                        result = Moltiplicazione();
                        break;
                    }
                case "4":
                    {
                        if (num2 == 0)
                        {
                            if (num1 == 0)
                                PrintError("\nIl dividendo e il divisore non possono essere uguali a 0");
                            else
                                PrintError("\nIl divisore non può essere uguale a 0");
                            Calculate();
                        }
                        else
                        {
                            operationSymbol = "/";
                            Console.WriteLine($"\nVisualizzare il resto? (y = si, n = No)");

                            bool resto = Console.ReadLine() == "y";

                            if (resto)
                                result = DivisioneConResto();
                            else
                                result = Divisione();
                        }

                        break;
                    }
                default:
                    {
                        PrintError("\nOpzione scelta non valida");
                        Calculate();
                        break;
                    }
            }
        }

        private void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
