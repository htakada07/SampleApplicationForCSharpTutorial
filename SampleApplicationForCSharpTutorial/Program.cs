//using directive is used when you want to use a types under a specific namespace without typing the namespace everything
using System;

//namespace is used to organize classes
namespace SampleApplicationForCSharpTutorial
{
    //this is a class
    internal class Program
    {
        //this is a method
        //Main method is the method that always gets executed first
        static void Main(string[] args)
        {
            //Console.WriteLine() lets you print in a console application
            Console.WriteLine("Hello World!");

            //In this case, Console is a class under the System namespace. WriteLine is one of the many methods that you can use under Console class
        }
    }
}
