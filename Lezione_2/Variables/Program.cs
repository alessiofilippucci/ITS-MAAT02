namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Syntax
             * 
             * type variable_name = value;
             * or
             * type variable_names;
            */

            // Compile Time Initialization

            char var = 'h'; // Declaring and Initializing character variable
            int a, b, c; // Declaring variables a, b and c of int type

            int y = 7; // Declaring and initializing the variable at same time
            int x; // Declaring variable x
            x = 5; // initializing x with value 5


            // Run Time Initialization

            // Value will be taken from user 
            // input and assigned to variable
            // num
            int num = Convert.ToInt32(Console.ReadLine());

            // printing the result
            Console.WriteLine("Value of num is " + num);
        }
    }
}