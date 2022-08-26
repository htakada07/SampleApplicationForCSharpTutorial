using System;

namespace LoopingStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while loop
            int counter1 = 0;

            while (counter1 < 5) // The block inside the while will execute as long as the condition is true
            {
                Console.WriteLine(counter1); // Simply printing the value of counter
                counter1++; // This will increment the value of counter each time this line is executed
            }
            #endregion

            #region for loop
            //  (variable initialization; condition; increment/decrementing of the variable)
            for (int counter = 0; counter < 5; counter++)
            {
                Console.WriteLine(counter);
            }
            #endregion

            #region do while loop
            int n = 0; // The variable we will use in the condition

            do
            {
                // This will be executed before checking the condition
                Console.Write(n); // Prints n
                n++; // Iterates the value of n
            } while (n < 5); // Checks the condition; will execute the do { } while the condition is true.
            // Output:
            // 01234
            #endregion

            #region nested loop
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.WriteLine("I love loops!");
                }
            }

            int x = 1, y = 2;

            while (x < 4)
            {
                Console.WriteLine("Outer loop = {0}", x);
                x++;

                while (y < 4)
                {
                    Console.WriteLine("Inner loop = {0}", y);
                    y++;
                }
            }

            int p = 1;
            do
            {
                Console.WriteLine("Outer loop = {0}", p);
                int i = p;

                p++;

                do
                {
                    Console.WriteLine("Inner loop: {0}", i);
                    i++;
                } while (i < 4);

            } while (p < 4);
            #endregion

            #region break statement
            for (var ctr = 0; ctr < 5; ctr++)
            {
                Console.Write(ctr);
                if(ctr == 3)
                {
                    break; // If this line executes, the execution of loop will now stop.
                }
            }
            // Expected output: 0123
            #endregion

            #region continue statement
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Iteration {0}: ", i); // Prints the value of i

                if (i < 3)
                {
                    Console.WriteLine("skip");
                    continue; // If this line is executed, the loop will now proceed to its next iteration
                }

                Console.WriteLine("done");
            }

            // Output
            // Iteration 0: skip
            // Iteration 1: skip
            // Iteration 2: skip
            // Iteration 3: done
            // Iteration 4: done
            #endregion

            int foo = 1;
            while (foo > 0)
            {
                Console.WriteLine(foo++);
            }
        }
    }
}
