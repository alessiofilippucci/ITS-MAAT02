using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class StaticConstructor
    {
        // It is invoked before the first
        // instance constructor is run.
        static StaticConstructor()
        {

            // The following statement produces
            // the first line of output,
            // and the line occurs only once.
            Console.WriteLine("Static Constructor");
        }

        // Instance constructor.
        public StaticConstructor(int i)
        {
            Console.WriteLine("Instance Constructor " + i);
        }

        // Instance method.
        public string Detail(string name, int id)
        {
            return "Name:" + name + " id:" + id;
        }
    }
}
