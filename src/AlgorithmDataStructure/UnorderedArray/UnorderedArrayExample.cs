using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnorderedArray
{
    /// <summary>
    /// Represents an unordered array data structure.
    /// </summary>
    public class UnorderedArrayExample
    {


        private int[] _array;
        private int _size;
        private int _capacity;




        /// <summary>
        /// Constructor to initialize the unordered array with a specified capacity.
        /// </summary>
        /// <param name="capacity">The initial capacity of the array</param>
        public UnorderedArrayExample(int capacity)
        {
            _capacity=capacity;
            _array = new int[capacity];
            _size = 0;
        }


        /// <summary>
        /// Inserts an element at the end of the array.
        /// </summary>
        /// <param name="element">The element to be inserted</param>
        public void Insert(int element)
        {
            // Check if array is full, if so, resize it
            if (_size == _capacity)
                ResizeArray();

            _array[_size]=element;
            _size++;
        }

        public void Remove(int element)
        {
            // Find the index of the element to be removed
            int index=IndexOf(element);

            // If element is found, remove it
            if (index != -1)
            {
                for(int i = index;i<_size-1;i++)
                    _array[i] = _array[i+1];

                _size--;
            }
        }

        /// <summary>
        /// Searches for the first occurrence of the specified element in the array.
        /// </summary>
        /// <param name="element">The element to search for</param>
        /// <returns>The index of the element if found; otherwise, -1</returns>
        public int IndexOf(int element)
        {
            for (int i = 0; i < _size; i++)
                if (_array[i] == element)
                    return i;

            return -1;
          
        }

        /// <summary>
        /// Prints the elements of the array.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Array: ");
            for(int i=0;i<_size;i++)
                Console.WriteLine(_array[i]+" ");

            Console.WriteLine();
        }


        /// <summary>
        /// Resizes the array to accommodate more elements.
        /// </summary>
        private void ResizeArray()
        {
            _capacity *= 2;
            int[] newArray=new int[_capacity];
            Array.Copy(_array, newArray, _size);
            _array = newArray;
        }


    }
}
