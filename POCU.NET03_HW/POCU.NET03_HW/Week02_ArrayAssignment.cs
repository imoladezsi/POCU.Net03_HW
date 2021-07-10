using System;
using System.Collections.Generic;
using System.Text;

namespace POCU.NET03_HW
{
    /* Week 02: 17 - 22 iunie
     * Array Assignment */
    class Week02_ArrayAssignment
    {
        /*Write a program in C# to find the element with the maximum and minimum length in an array of strings.*/
        public static Tuple<String, String> FindMinAndMaxElement(string[] strings) {
            string minLengthElem = strings[0];
            string maxLengthElem = strings[0]; //these will be the results. Initialize them with the first element
            foreach (string elem in strings) {
                if (elem.Length > maxLengthElem.Length)
                    maxLengthElem = elem;
                if (elem.Length < minLengthElem.Length)
                    minLengthElem = elem;
            }
            return Tuple.Create<String,String>(minLengthElem, maxLengthElem);
        }

        public static void RunExercise() {
            string[] fiveStrings = { "Abc", "Acbdefgh", "A", "Abc", "Abcd" };
            string[] tenStrings = { "Abc", "Acbdefgh", "A", "Abc", "Abcd" , "Acbdefghij", "Acbdefgh", "Abc", "Ab", "Acbdefghijk" }; ;

            Tuple<string,String> result = FindMinAndMaxElement(fiveStrings);
            Console.WriteLine("(min, max) elements are: {0}",result);
            result = FindMinAndMaxElement(tenStrings);
            Console.WriteLine("(min, max) elements are: {0}",result);
        }
    }
}
