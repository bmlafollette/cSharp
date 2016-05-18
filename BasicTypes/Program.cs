using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /**** Fiddle Challenge - Types ****/

            /* REFERENCE: https://msdn.microsoft.com/en-us/library/ms173104.aspx
            BRONZE CHALLENGE:
                Create a list of value types. (int, string, bool, float, double, decimal)
                Create two examples for each type. One is a declaration only. The other is a declaration with initializer.
                Print a view of the values in the console.

            SILVER CHALLENGE:
                Use those types to concatenate a string. 

            GOLD CHALLENGE: 
                Declare the year you were born as a string. 
                Convert it to an integer and print it with a message in the console.
                For instance, "I was born in 1976."   */

            /*******    Possible Answer:   ****    */

            int myLuckyNumber;
            int yearGraduatedHighSchool = 1998;

            string fbPost;
            string reTweet = "Yes, I'll retweet that";

            bool isMarried;
            bool isHappy = true;

            decimal studentLoanAmount;
            decimal bankAccount = 100;  //More expensive than a double.

            float amountOfSnow;
            float temperature = 57.5f;

            double latitude;
            double oneThird = 3.33333333d;

            myLuckyNumber = 7;
            fbPost = "The Patriots are terrible!";
            studentLoanAmount = 5000;
            amountOfSnow = 2;
            latitude = 132.5;

            Console.WriteLine(yearGraduatedHighSchool);
            Console.WriteLine(temperature);
            Console.WriteLine(oneThird);
            Console.WriteLine(bankAccount);
            Console.WriteLine(studentLoanAmount);
            Console.WriteLine(amountOfSnow);
            Console.WriteLine(latitude);


            /* SILVER */
            Console.WriteLine("{0} {1}", fbPost, reTweet);
            Console.WriteLine("My lucky number is {0} and I graduated high school in {1}.", myLuckyNumber, yearGraduatedHighSchool);


            isMarried = false;
            Console.WriteLine("Am I married? {0}", isMarried);
            Console.WriteLine("Am I happy? {0}", isHappy);

            /* GOLD */
            int yearBorn = Int32.Parse("1979");
            Console.WriteLine("I was born in {0}.", yearBorn);

            Console.WriteLine("Stop");
            Console.ReadLine();
            //REF: https://msdn.microsoft.com/en-us/library/bb397679.aspx
        }
    }
}
