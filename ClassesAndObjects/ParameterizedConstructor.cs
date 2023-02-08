namespace ClassesAndObjects
{
    public class ParameterizedConstructor
    {
        // data members of the class.
        string name;
        int id;

        // parameterized constructor would
        // initialized data members with
        // the values of passed arguments
        // while object of that class created.
        public ParameterizedConstructor(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
