namespace ClassesAndObjects
{
    public class DefaultConstructor
    {
        int num;
        string name;

        // this would be invoked while the
        // object of that class created.
        public DefaultConstructor()
        {
            Console.WriteLine("Constructor Called");
        }
    }
}
