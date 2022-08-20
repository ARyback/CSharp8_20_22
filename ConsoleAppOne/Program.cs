// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleAppOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string helloWorld = "Hello World!";
            Console.WriteLine(helloWorld);
            Console.WriteLine("Hi ho ");
            int x = 5;
            int y = 7;
            int z = x + y;
            Console.WriteLine(z);
            Console.WriteLine("Enter your username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userName + " is your username and your age is " + userAge);
            */
            string name = "Johnny Doe";
            int charPos = name.IndexOf("D");
            charPos = 8;
            string lastName = name.Substring(charPos);
            Console.WriteLine(lastName);
        }
    }
}
