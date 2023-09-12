namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int number1 = 3;
                int number2 = 7;
                double number3 = 5.1;
                double number4 = 8.3;

                int intSum = MathHelperCalculator.Sum(number1, number2);
                double doubleSum = MathHelperCalculator.Sum(number3, number4);

                int intDifference = MathHelperCalculator.Subtraction(number1, number2);
                double doubleDifference = MathHelperCalculator.Subtraction(number3, number4);

                int intMultiplier = MathHelperCalculator.Multiplication(number1, number2);
                double doubleMultiplier = MathHelperCalculator.Multiplication(number3, number4);

                int intAbsolutify = MathHelperCalculator.Absolute(-number2);
                int doubleAbsolutify = MathHelperCalculator.Absolute((int)number4);

                int intMin = MathHelperCalculator.MinValue(number1, number2);
                double doubleMin = MathHelperCalculator.MinValue(number3, number4);

                int intMax = MathHelperCalculator.MaxValue(number1, number2);
                double doubleMax = MathHelperCalculator.MaxValue(number3, number4);

                double pow = MathHelperCalculator.Pow(number4, number2);

                Console.WriteLine($"1: { intSum}\n2: {doubleSum}\n3: {intDifference}\n4: {doubleDifference}\n5: {intMultiplier}\n6: {doubleMultiplier}\n7: {intAbsolutify}\n8: {doubleAbsolutify}\n9: {intMin}\n10: {doubleMin}\n11: {intMax}\n12: {doubleMax}\nBONUS: {pow}");
            }
        }
    }
}