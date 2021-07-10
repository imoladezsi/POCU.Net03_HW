using System;
using System.Collections.Generic;
using System.Text;

namespace POCU.NET03_HW
{
    /*********************** 
     Week 04: 01 - 06 iulie
     String Assignment
    ************************/
    class Week04_StringAssignment
    {
        /* Research/experimentation you need to do before doing the challenges:
        We've already learned that chars can be treated like ints, let's see that applied to a for statement
        for (char c = 'p'; c <= 't'; c++) { Console.WriteLine("Char " + c + " has a value of " + (int)c); Console.WriteLine("Index of char " + c + " in string 'alphabet' is " + "alphabet".IndexOf(c)); }
        
        Assignment:
        Write a program to read a string from the input and compute its ROT3 equivalent 
        (please don't use string concatenation in a for loop, use the StringBuilder and its Append method). 
        ROT3 is a cipher used by ancient spies, it takes each letter of a string and substitutes it for the third one 
        after it in the alphabet: a -> d, e -> h, y -> b.
        You can check your result against https://rot13.com/ (select ROT3)
         */
        public static string FindROTEquivalent(string inputString, int ROTNumber) {
            StringBuilder sb = new StringBuilder(inputString.Length);
            foreach (char c in inputString) {
                /* a = 97
                 * z = 97 + 25
                 * A = 65
                 * Z = 65 + 25
                 * 
                 * y -> b
                 * y -> (int) y + 3 = (97 + 24) + 3 = 97 + 25 + 2 = (int) z + 2
                 * (int) z + 2 -> (int) a + 2 - 1 = b
                 * So in order to rotate, if the resulting number x is > z, we substract z from it and move x steps from a  
                 * that is, total - z + a - 1
                 */
                int minInt;
                int maxInt;
                if (c >= 'a' && c <= 'z') {
                    maxInt = (int)'z';
                    minInt = (int)'a';
                }
                else if (c >= 'A' && c <= 'Z') {
                    maxInt = (int)'Z';
                    minInt = (int)'A';
                }
                else {
                    sb.Append(c);
                    continue;
                }
            
                char charToAppend = (char)(((int)c + ROTNumber > maxInt) ? (int)c + ROTNumber - maxInt + minInt - 1 : c + ROTNumber);
                sb.Append(charToAppend);
            }
            return sb.ToString();
        }

        public static void RunExercise() {
            Console.Write("Please input te string: ");
            string inputString = Console.ReadLine();
            Console.WriteLine("Its ROT3 equivalent is: {0}", FindROTEquivalent(inputString, 3));   
        }
    }
}
