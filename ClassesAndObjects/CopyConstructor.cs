using System;

namespace ClassesAndObjects
{
    public class CopyConstructor
    {
        // data members of the class.
        string name;
        int id;

        // declaring Copy constructor
        public CopyConstructor(CopyConstructor s)
        {
            name = s.name;
            id = s.id;
        }

        // Instance constructor
        public CopyConstructor(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
