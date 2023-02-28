namespace ClassesAndObjects
{
    public class PrivateConstructor
    {
        // declare static variable field
        public static int counter;

        // declare private Constructor
        private PrivateConstructor()
        {
        }

        // declare static method
        public static int Increase()
        {
            return ++counter;
        }

        // declare static method
        public static int Decrease()
        {
            return --counter;
        }
    }
}
