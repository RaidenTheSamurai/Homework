using Homework__3.Part_2;
using Homework__3.Part_3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework__3
{
    public class Array : IOutput, IMath, ISort
    {

        public int[] ArrayElements { get; set; } 

        public Array(int[] array) => ArrayElements = array;

        /*
        -----------------------------------------------------------------------------------------------------
        Part 1
        -----------------------------------------------------------------------------------------------------
        */

        public void Show()
        {
            foreach (int element in ArrayElements) { Console.Write(element + " "); }
            Console.WriteLine();
        }
        public void Show(string info)
        {
            Console.WriteLine(info);
            foreach (int element in ArrayElements) { Console.Write(element + " "); }
            Console.WriteLine();
        }
        /*
        -----------------------------------------------------------------------------------------------------
        Part 2
        -----------------------------------------------------------------------------------------------------
        */
        public int Max()
        {
            int max = 0;
            foreach (int element in ArrayElements)
            {
                if (element > max) max = element;
            }
            return max;
        }
        public int Min()
        {
            int min = 100;
            foreach (int element in ArrayElements)
            {
                if (element < min) min = element;
            }
            return min;
        }
        public float Avg()
        {
            float sum = 0;
            float avg;
            foreach (int element in ArrayElements) sum += element;
            avg = sum / ArrayElements.Length;
            return avg;
        }
        public bool Search(int valueToSearch)
        {
            foreach (int element in ArrayElements)
            {
                if (element == valueToSearch) return true;
            }
            return false;
        }
        /*
        -----------------------------------------------------------------------------------------------------
        Part 3
        -----------------------------------------------------------------------------------------------------
        */
        public void SortAsc()
        {
            int temp = 0;
            for (int i = 0; i <= ArrayElements.Length; i++)
            {
                for (int j = i+1;  j < ArrayElements.Length; j++)
                {
                    if (ArrayElements[j] < ArrayElements[i])
                    {
                        temp = ArrayElements[i];
                        ArrayElements[i] = ArrayElements[j];
                        ArrayElements[j] = temp;
                    }
                }
            }
        }
        public void SortDesc()
        {
            int temp = 0;
            for (int i = ArrayElements.Length - 1; i > 0; i--)
            {
                for (int j = i - 1; j >=0; j--)
                {
                    if (ArrayElements[j] < ArrayElements[i])
                    {
                        temp = ArrayElements[i];
                        ArrayElements[i] = ArrayElements[j];
                        ArrayElements[j] = temp;
                    }
                }
            }
        }
        public void SortByParam(bool isAsc)
        {
            if (isAsc) SortAsc();
            else SortDesc();
        }
    }
}
