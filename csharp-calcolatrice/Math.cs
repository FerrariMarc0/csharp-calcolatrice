using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class MathHelperCalculator
    {
        public static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public static double Sum(double number1, double number2)
        {
            return number1 + number2;
        }

        public static int Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }

        public static double Subtraction(double number1, double number2)
        {
            return number1 - number2;
        }

        public static int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }

        public static double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }

        public static int Absolute(int number)
        {
            return Math.Abs(number); //number >= 0 ? number : - number
        }

        public static double Absolute(double number)
        {
            return Math.Abs(number); //number >= 0 ? number : - number
        }

        public static int MinValue(int number1 , int number2)
        {
            return Math.Min(number1, number2);
        }

        public static double MinValue(double number1 , double number2)
        {
            return Math.Min(number1, number2);
        }

        public static int MaxValue(int number1 , int number2)
        {
            return Math.Max(number1, number2);
        }

        public static double MaxValue(double number1 , double number2)
        {
            return Math.Max(number1, number2);
        }

        //Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi, applica nella pratica il PRINCIPIO DI LISKOV
        //poichè le istanze posso essere sostituite con altre istanze senza alterare il corretto funzionamento del programma.

        public static double Pow(double number, int exponent)
        {
            if (number == 0)
            {
                if (exponent == 0)
                    return 1;
                else
                    return 0;
            }
            else
                return Math.Pow(number, exponent);
        }
    }
        //In questo caso ci risulterebbero molto utili i Generics di C#, potendo eseguire le operazioni sia su numeri interi sia su numeri double.

}
