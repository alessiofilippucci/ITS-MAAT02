namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // taking two strings value
            string topic;
            string category;

            // taking topic name
            topic = "Inheritance";

            // using switch Statement
            switch (topic)
            {
                case "Introduction to C#":
                case "Variables":
                case "Data Types":

                    category = "Basic";
                    break;

                case "Loops":
                case "If Statements":
                case "Jump Statements":

                    category = "Control Flow";
                    break;

                case "Class & Object":
                case "Inheritance":
                case "Constructors":

                    category = "OOPS Concept";
                    break;

                // default case 
                default:
                    category = "Not Mentioned";
                    break;

            }

            System.Console.Write("Category is " + category);
        }
    }
}