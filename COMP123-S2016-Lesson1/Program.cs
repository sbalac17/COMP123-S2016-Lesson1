using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* This is connected to github
 *
 * return a string that will print Hello World
 * 
 * 
 *  Made public so it is accessible in code/github. 
 *  
 * Calling HelloWorldToConsole in the main */
/**
 * Prints a HelloWorld message to the console and returns the same message
 * 
 * @method HelloWorldToConsole
 * @return {string} Returns the displayed message
 * */

namespace COMP123_S2016_Lesson1
{
    public class Program
    {
        static void Main(string[] args)
        {
            HelloWorldToConsole();

        }
        public static string HelloWorldToConsole()
        {
            string HelloWorldString = "Hello, World!";
            Console.WriteLine(HelloWorldString);
            return HelloWorldString;

        
        }
    }

}
