using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        //Bronze Challenge - Write a method that determines whether a number is odd or even.
        int num1 = 2;

        public void OddOrEven1(int num1)
        {
            if (num1 % 2 == 0)
                Console.WriteLine("The number is even.");
            else
                Console.WriteLine("The number is odd.");
            Console.ReadLine();
        }

        //Silver Challenge - Write a method that can reverse a string ("Hello World" becomes "dlroW olleH")
        //https://msdn.microsoft.com/en-us/library/ezftk57x(v=vs.110).aspx

        string text = "Hello world";

        public string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();             //Copies each character in a string to a character array.
            string Reverse = String.Empty;                  //Sets our output string equal to an empty string.
            for (int i = cArray.Length - 1; i > -1; i--)    //Iterates through the array by starting at the end and working backwards.
            {
                Reverse += cArray[i];                       //Adds each character to our new array.
            }
            return Reverse;                                 //Returns our new array.
        }


        //--or--

        string s = "Hello world";

        public string Reverse1(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
