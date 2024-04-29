using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedArray
{
    /// <summary>
    /// Class to perform operations on a sorted array such as insertion, deletion, linear search, and binary search.
    /// </summary>
    public class SortedArrayOperations
    {
        private int[] array;
        private int size;
        private int capacity;

        /// <summary>
        /// Initializes a new instance of the <see cref="SortedArrayOperations"/> class with the specified capacity.
        /// </summary>
        /// <param name="capacity">The capacity of the sorted array.</param>
        public SortedArrayOperations(int capacity)
        {
            this.capacity = capacity;
            array = new int[capacity];
            size = 0;
        }

        /// <summary>
        /// Inserts an element into the sorted array while maintaining the order.
        /// </summary>
        /// <param name="element">The element to be inserted.</param>
        public void Insert(int element)
        {
            if (size == capacity)
            {
                Console.WriteLine("Array is full. Cannot insert more elements.");
                return;
            }

            int i;
            for (i = size - 1; i >= 0 && array[i] > element; i--)
            {
                array[i + 1] = array[i];
            }
            array[i + 1] = element;
            size++;
        }

        /// <summary>
        /// Deletes an element from the sorted array.
        /// </summary>
        /// <param name="element">The element to be deleted.</param>
        public void Delete(int element)
        {
            int index = LinearSearch(element);
            if (index == -1)
            {
                Console.WriteLine("Element not found. Cannot delete.");
                return;
            }

            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }
            size--;
        }

        /// <summary>
        /// Performs a linear search to find the index of the specified element in the sorted array.
        /// </summary>
        /// <param name="element">The element to search for.</param>
        /// <returns>The index of the element if found; otherwise, -1.</returns>
        public int LinearSearch(int element)
        {
            for (int i = 0; i < size; i++)
            {
                if (array[i] == element)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Performs a binary search to find the index of the specified element in the sorted array.
        /// </summary>
        /// <param name="element">The element to search for.</param>
        /// <returns>The index of the element if found; otherwise, -1.</returns>
        public int BinarySearch(int element)
        {
            int left = 0;
            int right = size - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == element)
                {
                    return mid;
                }
                else if (array[mid] < element)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

        /// <summary>
        /// Displays the elements of the sorted array.
        /// </summary>
        public void Display()
        {
            Console.Write("Sorted Array: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Measures the execution time of a search operation on the sorted array.
        /// </summary>
        /// <param name="searchFunction">The search function to be measured.</param>
        /// <param name="element">The element to search for.</param>
        /// <returns>The execution time of the search operation in milliseconds.</returns>
        public long MeasureSearchTime(Func<int, int> searchFunction, int element)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            var result = searchFunction(element);
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
    }


}
