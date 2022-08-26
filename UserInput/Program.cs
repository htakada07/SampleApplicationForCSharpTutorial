using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring a variable name
            string name;
            int age;

            // To instruct the user to enter a name
            Console.WriteLine("Please enter your name: "); 
            // Console.ReadLine() is used to get the user entered value and assigning it to the variable name
            name = Console.ReadLine();

            // To instruct the user to enter an age
            Console.WriteLine("Please enter your age: ");
            // We will be using int.Parse() to convert the string into an int.
            // Note that if the user entered a non integer value, it will return an error
            age = int.Parse(Console.ReadLine());

            // We will reprint the variable name to show the user entered value
            Console.WriteLine("Your name is {0} and you are {1} years old", name, age);
        }
    }
}
