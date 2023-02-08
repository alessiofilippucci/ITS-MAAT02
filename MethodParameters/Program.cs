namespace MethodParameters
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //var string1 = "Hello";
            //var string2 = ",";
            //var string3 = "World!";

            //AddStr(string1, string2, string3);

            //string valA = "Ciao";

            //CompareValue(ref valA);

            //int counter = 0;
            //int counter2 = 10;

            //IncreaseDecreaseValue(ref counter, ref counter2);
            //IncreaseDecreaseValue(ref counter, ref counter2);
            //IncreaseDecreaseValue(ref counter, ref counter2);
            //IncreaseDecreaseValue(ref counter, ref counter2);
            //IncreaseDecreaseValue(ref counter, ref counter2);

            //counter = IncreaseValue(counter);
            //counter = IncreaseValue(counter);
            //counter = IncreaseValue(counter);
            //counter = IncreaseValue(counter);
            //counter = IncreaseValue(counter);

            //counter2 = DecreaseValue(counter2);
            //counter2 = DecreaseValue(counter2);
            //counter2 = DecreaseValue(counter2);
            //counter2 = DecreaseValue(counter2);
            //counter2 = DecreaseValue(counter2);

            //int numA = 10;
            //int numB = 15;
            //int sum;
            //int diff;
            //int prod;
            //int div;

            //Calculate(numA, numB, out sum, out diff, out prod, out div);

            //var dept = Console.ReadLine();

            //Detail("Alessio", 550, dept: dept);

            //MultipleValueType(5);
            //MultipleValueType("ciao");
            //MultipleValueType(DateTime.Now);

            //int[] numbers = { 1, 2, 3, 4, 5 };

            //MultipleValuesArray(numbers);
            //MultipleValues(1, 2, 3, 4, 5);

            Console.ReadLine();
        }

        // named parameters and value parameters
        static void AddStr(string s1, string s2, string s3)
        {
            s1 = "Ciao";
            s2 = ",";
            s3 = "Mondo!";

            string result = s1 + s2 + s3;
            Console.WriteLine("Final string is: " + result);
        }

        static int IncreaseValue(int num)
        {
            return num++;
        }

        static int DecreaseValue(int num)
        {
            return num--;
        }

        // ref parameter
        static void IncreaseDecreaseValue(ref int num, ref int num2)
        {
            num++;
            num2--;
        }

        // ref parameter
        static void CompareValue(ref string val1)
        {
            // Compare the value
            if (val1 == "Dog")
            {
                Console.WriteLine("Matched!");
            }

            // Assigning new value
            val1 = "Cat";
        }

        // out parameter
        static void Calculate(int num1, int num2, out int sum, out int diff, out int prod, out int div)
        {
            sum = num1 + num2;
            diff = num1 - num2;
            prod = num1 * num2;
            div = num1 / num2;
        }

        // optional parameters
        static void Detail(string ename, int eid, string bgrp = "A+", string dept = "")
        {
            Console.WriteLine("Employee name: {0}", ename);
            Console.WriteLine("Employee ID: {0}", eid);
            Console.WriteLine("Blood Group: {0}", bgrp);

            if (dept != "")
                Console.WriteLine("Department: {0}", dept);
        }

        // dynamic parameters
        public static void MultipleValueType(dynamic val)
        {
            val *= val;
            Console.WriteLine(val);
        }

        public static int MultipleValuesArray(int[] num)
        {
            int res = 1;

            // foreach loop
            foreach (int j in num)
            {
                res *= j;
            }

            return res;
        }

        // params
        public static int MultipleValues(params int[] num)
        {
            int res = 1;

            // foreach loop
            foreach (int j in num)
            {
                res *= j;
            }

            return res;
        }
    }
}