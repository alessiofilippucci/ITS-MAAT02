using Utils;

namespace Exercise
{
    public class Program
    {
        //static void Main(string[] args)
        //{
        //    Calcolatrice calculator = new Calcolatrice();

        //    Calcolatrice.StaticMethod(10, 2);

        //    var result = calculator.Addizione(5, 8);

        //    if (result == 13)
        //        ConsoleExtension.WriteSuccess("Add OK");
        //    else
        //        ConsoleExtension.WriteError("Add Failed");

        //    result = calculator.Sottrazione(10, 8);

        //    if (result == 2)
        //        ConsoleExtension.WriteSuccess("Sott OK");
        //    else
        //        ConsoleExtension.WriteError("Sott Failed");

        //    result = calculator.Moltiplicazione(3, 4);

        //    if (result == 12)
        //        ConsoleExtension.WriteSuccess("Molt OK");
        //    else
        //        ConsoleExtension.WriteError("Molt Failed");

        //    result = calculator.Divisione(20, 5);

        //    if (result == 4)
        //        ConsoleExtension.WriteSuccess("Div OK");
        //    else
        //        ConsoleExtension.WriteError("Div Failed");

        //    result = calculator.Divisione(0, 5);

        //    if (result == 0)
        //        ConsoleExtension.WriteSuccess("Div divisore 0 OK");
        //    else
        //        ConsoleExtension.WriteError("Div divisore 0 Failed");

        //    try
        //    {
        //        result = calculator.Divisione(5, 0);

        //        ConsoleExtension.WriteError("Div dividendo 0 Failed");
        //    }
        //    catch
        //    {
        //        ConsoleExtension.WriteSuccess("Div dividendo 0 OK");
        //    }

        //    try
        //    {
        //        result = calculator.Divisione(0, 0);

        //        ConsoleExtension.WriteError("Div entrambi 0 Failed");
        //    }
        //    catch
        //    {
        //        ConsoleExtension.WriteSuccess("Div entrambi 0 OK");
        //    }

        //    result = calculator.Modulo(20, 5);

        //    if (result == 0)
        //        ConsoleExtension.WriteSuccess("Modulo OK");
        //    else
        //        ConsoleExtension.WriteError("Modulo Failed");

        //}


        static void Main(string[] args)
        {
            //Palla nuova = new Palla();
            //Palla nuova2 = new Palla("stoffa");
            //Palla nuova3 = new Palla(_diametro: 15);
            //Palla nuova4 = new Palla("stoffa", 10);

            //double[] actualCoordinates = nuova.GetCoordinate();

            //Console.WriteLine($"{actualCoordinates[0]}, {actualCoordinates[1]}");

            //nuova.Rotola(10);

            //Console.WriteLine($"{actualCoordinates[0]}, {actualCoordinates[1]}");

            int[] numbers = new int[5];

            try
            {
                string testo = File.ReadAllText("habitatList.txt", null);

                numbers[5] = 100;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("ENDED TRY-CATCH");
            }
        }
    }

}