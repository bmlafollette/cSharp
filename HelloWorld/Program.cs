/**** Fiddle Challenge #! - "Hello World"  ****/

//TODO: With a partner or group, create comments that analyze a basic C# "Hello World".

//REFERENCES: https://msdn.microsoft.com/en-us/library/0d941h9d.aspx
//https://msdn.microsoft.com/en-us/library/x9afc042.aspx
//https://msdn.microsoft.com/en-us/library/79b3xss3.aspx

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* - 1 - */
//Allows you to import prebuilt stuff to access, bring in libraries you think you're going to use.
using System;

/* - 2 - */
namespace HelloWorld
{
    /* - 3 - */
    // Creating a class within this namespace.
    public class Program
    {
        /* - 4 - */
        //The Main function is where the program begins.
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }

    //1 The word Using is used so that the complete name is not required, as in System.Console.WriteLine()
    //2 The namespace keyword is used to declare a namespace, which can help control the scope of class and method names in larger programming projects.
    //3 Classes are declared by using the class keyword.  Because the word public is used, anyone can create objects from this class.
    //4 A static class can't be instantiated.  You access the members of a static class by using the class name itself.  Static classes are sealed and can't be inherited.
    //5 Console.WriteLine tells it to putput the string to the console.

}
