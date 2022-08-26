using System;

namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if statement
            int a = 10;
            if(a < 10) // Checks if the condition is true
            {
                // Will be executed if the condition above is true
                Console.WriteLine("The value of a is greater than 10"); 
            }
            #endregion

            #region if...else statement
            int b = 15;
            if(b == 20) // Checks if the condition is true
            {
                // Will be executed if the condition above is true
                Console.WriteLine("The value of b is equal to 20"); 
            }
            else if(b < 20) // This will trigger this line if the condition/s before this line did not meet the condition;
            {
                Console.WriteLine("The value of b is less than 20");
            }
            else // Will be executed if none of the conditions above meet their conditions
            {
                // Since we know b = 30 did not meet b == 20 and b < 20
                // It will then go inside the else condition
                Console.WriteLine("The value of b is greater than 20"); 
            }
            #endregion

            #region nested if condition
            int x = 100;
            int y = 200;

            if(x == 100) // Will check if x is equals to 100
            {
                if(y == 200) // Another if condition inside which will get executed if the condition above is true
                {
                    // {0} is a placeholder, the variables that are specified
                    // You can have as many {0} {1} {2} ... where you will place the variables in their specific order of your choice
                    // The variables that are specified after the comma will be used to fill those placeholders
                    Console.WriteLine("The value of x is {0}", x); 
                    Console.WriteLine("The value of y is {0}", y);
                }
            }
            #endregion

            #region switch statement
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            // Outputs "Thursday" (day 4)
            #endregion

            #region nested switch statement
            int e = 1, q = 2;

            // Outer Switch
            switch (e)
            {
                // If x == 1
                case 1:
                    // Nested Switch
                    switch (q)
                    {
                        // If y == 2
                        case 2:
                            Console.WriteLine("Choice is 2");
                            break;
                        // If y == 3
                        case 3:
                            Console.WriteLine("Choice is 3");
                            break;
                    }
                    break;
                // If x == 4
                case 4:
                    Console.WriteLine("Choice is 4");
                    break;
                // If x == 5
                case 5:
                    Console.WriteLine("Choice is 5");
                    break;
                default:
                    Console.WriteLine("Choice is other than 1, 2 3, 4, or 5");
                    break;
            }
            #endregion
        }
    }
}
