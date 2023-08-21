using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program //a class is essentially a container where we can insert code
    {
        static void Main(string[] args) // this is a method/function.
        //Anything within the main function will be executes by the computer
        {
            string personName = "David";
            int personAge = 24;

            Console.WriteLine("There once was a man name is " + personName); 
            Console.WriteLine("He was " + personAge + " years old"); //concatenating a string
            Console.WriteLine("He really like the name " + personName);
            Console.WriteLine("But didn't like being " + personAge);

            Console.ReadLine(); // allows console to stay
        }
    }
}
