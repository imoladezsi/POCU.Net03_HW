using System;
using System.Collections.Generic;
using System.Text;

namespace POCU.NET03_HW
{
    /*  Week 02: 24 - 29 iunie
     *  Array Assignment 2 */
    class Week02_ArrayAssignment2<T>
    {
        /* Write a program in C# to find a particular value in an array in a for loop. 
         * The loop needs to exit the minute the searched for value is found. 
         * Write out the index of the array's element where the value is found.*/
        public static short GetElementIndex(T[] elements, T elementToFind) {
            short indexOfElem = -1; // the index of the element in the array
            for (short i = 0; i < elements.Length; i++) {
                if (elements[i].Equals(elementToFind)) {
                    indexOfElem = i;
                    break;
                }
            }
            return indexOfElem;
        }

        public static void RunExercise() {
            string[] fiveStrings = { "Ab", "Acbdefgh", "A", "Abc", "Abcd" };
            short index = Week02_ArrayAssignment2<string>.GetElementIndex(fiveStrings, "Abc");
            Console.WriteLine("The element's index is: {0}", index);
        }
    }
}
