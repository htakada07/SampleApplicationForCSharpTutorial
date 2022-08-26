namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion 
            //directly assigning a smaller range data type to a larger one (int to long in this case)
            int num1 = 1;
            long num2 = num1;

            //Explicit Conversion
            //In the example below, num2 is a long and a cast operator is used (int)<variable> to assign its value to an int variable
            int num3 = (int)num2;
        }
    }
}
