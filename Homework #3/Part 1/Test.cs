using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__3.Part_1
{
    public class Test
    {
        /*
        -----------------------------------------------------------------------------------------------------
        Part 1
        -----------------------------------------------------------------------------------------------------
        */
        public int[] ArrayBuilder(int size)
        {
            Random random = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++) arr[i] = random.Next(0, 100);
            return arr;
        }
        public void ArrayTest(int arraysize)
        {
            Array array = new Array(ArrayBuilder(arraysize));
            array.Show();
            array.Show("Array of random numbers in range from 0 to 100: ");
        }
        /*
        -----------------------------------------------------------------------------------------------------
        Part 2
        -----------------------------------------------------------------------------------------------------
        */
        public void ArrayTest(int arraysize, int valueToSearch)
        {
            Array array = new Array(ArrayBuilder(arraysize));
            Console.WriteLine($"Max value in array: {array.Max()}");
            Console.WriteLine($"Min value in array: {array.Min()}");
            Console.WriteLine($"Avarege value of array: {array.Avg()}");
            if (array.Search(valueToSearch) == true)
            {
                Console.WriteLine($"There is {valueToSearch} in this array");
            }
            else
            {
                Console.WriteLine($"There isn`t {valueToSearch} in this array");
            }
        }
        
        /*
        -----------------------------------------------------------------------------------------------------
        Part 3
        -----------------------------------------------------------------------------------------------------
        */
        public void ArrayTest(int arraysize, bool isAsc)
        {
            Array array = new Array(ArrayBuilder(arraysize));
            array.Show("Array of random numbers in range from 0 to 100: ");
            array.SortByParam(isAsc);
            array.Show("Sorted array: ");
        }
    }
}
