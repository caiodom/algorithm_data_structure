using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigONotation
{
    public class BigOExamples
    {

        /// <summary>
        /// Demonstrates an algorithm with constant time complexity O(1).
        /// Retrieves the first element of the given array.
        /// </summary>
        /// <param name="array">An array of integers</param>
        /// <returns>The string representation of the first element of the array</returns>
        public string ExampleO1(int[] array)
        {
            // Directly accesses the first element of the array
            int firstElement = array[0];
            return $"O(1) - First element of the array: {firstElement}";
        }

        /// <summary>
        /// Demonstrates an algorithm with linear time complexity O(n).
        /// Sums all elements of the given array and returns the total.
        /// </summary>
        /// <param name="array">An array of integers</param>
        /// <returns>The string representation of the sum of all elements in the array</returns>
        public string ExampleOn(int[] array)
        {
            // Sums all elements of the array
            int sum = 0;
            foreach (var element in array)
            {
                sum += element;
            }
            return $"O(n) - Sum of all elements of the array: {sum}";
        }


        /// <summary>
        /// Demonstrates an algorithm with quadratic time complexity O(n^2).
        /// Builds a string representing an n x n matrix of asterisks.
        /// </summary>
        /// <param name="n">The size of the matrix (n x n)</param>
        /// <returns>The string representation of the n x n matrix of asterisks</returns>
        public string ExampleOn2(int n)
        {
            // Generates a matrix with quadratic complexity
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    sb.Append("* ");

                sb.AppendLine();
            }

            sb.AppendLine("O(n^2) - Printing an n x n matrix of asterisks.");
            return sb.ToString();

        }

        /// <summary>
        /// Demonstrates an algorithm with logarithmic time complexity O(log n).
        /// Builds a string representing values obtained by repeatedly dividing a number by 2 until reaching 1.
        /// </summary>
        /// <param name="n">The number to be divided</param>
        /// <returns>The string representation of values obtained by division</returns>
        public string ExampleOlogn(int n)
        {
            // Divides the number in half in each iteration
            StringBuilder sb = new StringBuilder();

            int value = n;

            while (value > 1)
            {
                value /= 2;
                sb.AppendLine(value.ToString());
            }

            sb.AppendLine("O(log n) - Division by two until reaching 1.");
            return sb.ToString();

        }


        /// <summary>
        /// Demonstrates an algorithm with linearithmic time complexity O(n log n).
        /// Builds a string representing values obtained by combining linear and logarithmic operations.
        /// </summary>
        /// <param name="n">The size of the problem</param>
        /// <returns>The string representation of values obtained by combination of operations</returns>
        public string ExampleOnlogn(int n)
        {
            // Combines linear and logarithmic operations
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                int value = n;
                while (value > 1)
                {
                    value /= 2;
                    sb.AppendLine(value.ToString());
                }

               
            }

            sb.AppendLine("O(n log n) - Combination of O(n) and O(log n) operations.");
            return sb.ToString();

        }

        /// <summary>
        /// Demonstrates an algorithm with exponential time complexity O(2^n).
        /// Computes the Fibonacci sequence recursively.
        /// </summary>
        /// <param name="n">The index of Fibonacci sequence</param>
        /// <returns>The string representation of the Fibonacci number at the specified index</returns>
        public string ExampleO2n(int n)
        {
            int fib = Fibonacci(n);
            return $"O(2^n) - Fibonacci of {n}: {fib}";
        }

        // Helper method to calculate Fibonacci sequence recursively
        private int Fibonacci(int n)
        {

            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
