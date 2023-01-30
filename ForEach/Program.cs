namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuaAggiuntaNumeri = true;

            List<int> numberList = new List<int>();

            Console.WriteLine("Inserisci dei numeri... (per uscire scrivi 'quit')");

            while (continuaAggiuntaNumeri)
            {
                int? num = null;

                while (num == null)
                {
                    try
                    {
                        var value = Console.ReadLine();

                        if (value == "quit")
                        {
                            continuaAggiuntaNumeri = false;
                            break;
                        }

                        num = int.Parse(value);
                        numberList.Add(num.Value);
                    }
                    catch
                    {
                        Console.WriteLine("Il numero inserito non è valido");
                    }
                };
            }

            numberList.Insert(0, 2);
            numberList.Insert(1, 8);


            List<int> numberList2 = new List<int>();

            numberList2.Add(888);
            numberList2.Add(999);

            numberList.InsertRange(2, numberList2);

            numberList.RemoveAt(0);


            var oper = Console.ReadLine();

            List<string> allowedOp = new List<string>() { "+", "-", "*", "/" };

            //allowedOp.Add("+");
            //allowedOp.Add("-");
            //allowedOp.Add("*");
            //allowedOp.Add("/");

            if (allowedOp.Contains(oper))
            {
                foreach (int num in numberList)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}