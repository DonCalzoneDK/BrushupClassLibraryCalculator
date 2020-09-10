using System;
using System.Threading.Channels;

namespace ClassLibraryCalculator
{
    public class Calculator
    {
        /// <summary>
        /// Simple method to get the square of a number
        /// </summary>
        /// <param name="num"></param>
        /// <returns>num * num</returns>
        public static int Square(int num)
        {
            return num * num;
        }


        /// <summary>
        /// Simple multiply method
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num1 * num2</returns>
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// Simple Division method
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num1 / num2</returns>
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        /// <summary>
        /// Simple Add method
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num1 + num2</returns>
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// Simple Subtract method
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num1 - num2</returns>
        public static int Subtract(int num1, int num2)
        {
            {
                return num1 - num2;
            }
        }


        /// <summary>
        /// Simple Multiplication method for numbers with decimals
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num1 * num2</returns>
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// Simple Division method for numbers with decimals
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num1 / num2</returns>
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        /// <summary>
        /// Simple Addition method for numbers with decimals
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num1 + num2</returns>
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// Simple Subtraction method for numbers with decimals
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num1 - num2</returns>
        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        

    }
}
