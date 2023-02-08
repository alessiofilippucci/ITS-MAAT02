namespace ClassesAndObjects
{
    // Base class
    class Inheritance
    {
        // data members
        public string name;
        public string subject;

        // constructor of derived class
        public Inheritance()
        {
            Console.WriteLine("Inheritance");
        }

        // public method of base class 
        public void Detail(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My Favorite Subject is: " + subject);
        }
    }

    // Derived class
    // inheriting the Inheritance class using : 
    class InheritanceDerived : Inheritance
    {

        // constructor of derived class
        public InheritanceDerived()
        {
            Console.WriteLine("InheritanceDerived");
        }
    }
}
