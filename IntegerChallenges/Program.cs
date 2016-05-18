using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerChallenges
{
	class Program
	{
		static void Main(string[] args)
		{

            /*
            BRONZE: 



            SILVER: 
            Using up to 4 different integers(a, b, c, d), show FOIL in the console. (x + y)(x - 7)
            Print out the answer. 

            GOLD: 
            Using 4 different integers(a, b, c, d), show four different operations to reach 100 or (e).  
            Print those operations to the console like this example: "The value of (a + b) * c / d is : 100"
            Resource: http://www.tutorialspoint.com/csharp/csharp_operators_precedence.htm
            */

            int a, b, c, d;

            a = 1;
            b = 2;
            c = 3;
            d = 4;

            // Show (a + b)(c + d)

            int foil = (a * c) + (a * d) + (b * c) + (b * d);
            Console.WriteLine(foil);

            a = 35;
            b = 15;
            c = 10;
            d = 5;

            int x = (a + b) * (c / d);
            Console.WriteLine("The value of ({0} + {1}) * ({2} / {3}) is {4}.", a, b, c, d, x);

            Console.ReadLine();

		}
	}
}
