namespace BasicOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arithmetic Operators
            int num1 = 5;
            int num2 = 10;

            int sum = num1 + num2;
            int product = num1 * num2;
            int quotient = num1 / num2;
            int remainder = num1 % num2; //Modulus operator returns the remainder in division
            int difference = num1 - num2;

            // ++ is called an increment operator. When the execution hits this
            // line of the code, it will add 1 to the variable.
            num1++; //6

            // -- is called an increment operator. When the execution hits
            // this line of the code, it will add 1 to the variable.
            num2--; //11
            #endregion

            #region Logical Operators
            var x = true;
            var y = false;

            var result1 = x && y; //true AND false will return a value of false
            var result2 = x || y; //true OR false will return a value of true
            var result3 = !x; //this will negate the variable x, thus will return a false;
            #endregion

            #region Comparison Operators
            var i = 5;
            var o = 10;

            var result4 = i == o; //This will return a false since 5 and 10 are not equal
            var result5 = i != o; //Thjs will return a true since 5 and 10 are not equal
            var result6 = i > o; //This will return a false because 5 is not greater than 10
            var result7 = i < o; //This will return a true because 5 is less than 10
            var result8 = i >= o; //This operator checks if the value is greater than OR equal with the value on the right side
            var result9 = i <= o; //This operator checks if the value is less than OR equal with the value on the right side
            #endregion

            #region Assignment Operators
            var p = 20;
            int result11 = 0; //Initializing result11 to have a value of 0

            result11 = p; //Assigning the value of p to result11
            result11 += p; //This is equivalent result11 = result1 + p
            result11 -= p; //This is equivalent result11 = result1 - p
            result11 *= p; //This is equivalent result11 = result1 * p
            result11 /= p; //This is equivalent result11 = result1 / p
            result11 %= p; //This is equivalent result11 = result1 % p

            #endregion
        }
    }
}
