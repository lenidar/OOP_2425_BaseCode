using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2425_BaseCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[0];
            Random rnd = new Random();

            DisplayArray(list);

            //for (int x = 0; x < 100; x++)
            //{
            //    list = AddToArray(list, rnd.Next(20));
            //    DisplayArray(list);
            //}

            list = AddToArray(list, 1);
            list = AddToArray(list, 2);
            list = AddToArray(list, 1);
            list = AddToArray(list, 1);
            list = AddToArray(list, 5);
            list = AddToArray(list, 1);
            list = AddToArray(list, 1);
            list = AddToArray(list, 1);
            list = AddToArray(list, 1);
            list = AddToArray(list, 1);

            DisplayArray(list);

            Console.WriteLine(Contains(list,5));

            //list = RemoveAt(list, 4);
            list = Remove(list, 6);

            DisplayArray(list);

            Console.ReadKey();
        }

        /// <summary>
        /// This should be the only method used to display the array
        /// </summary>
        /// <param name="array"></param>
        static void DisplayArray(int[] array)
        {
            Console.WriteLine("The current length of the array is " + array.Length);
            Console.WriteLine("It contains the following values:");

            foreach (int i in array)
                Console.Write(i + "\t");

            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// This method a value into the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns>returns the array with the added value</returns>
        static int[] AddToArray(int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];

            for (int x = 0; x < array.Length; x++)
                newArray[x] = array[x];

            newArray[array.Length] = value;

            return newArray;
        }

        #region The four
        static bool Contains(int[] array, int value)
        {
            foreach (int i in array)
            {
                if (i == value)
                {
                    return true;
                }
            }
            return false;
        }

        static int Find(int[] array, int value)
        {
            if (Contains(array, value))
            {
                for (int x = 0; x < array.Length; x++)
                {
                    if (array[x] == value)
                    {
                        return x;
                    }
                }
            }

            return -1;
        }

        static int[] RemoveAt(int[] array, int index)
        {
            int[] newArray = { };
            bool skip = false;

            if (index > -1)
                newArray = new int[array.Length - 1];
            else
                newArray = array;

            if (array.Length > newArray.Length)
            {
                for (int x = 0; x < newArray.Length; x++)
                {
                    if (x == index)
                        skip = true;

                    if (skip)
                        newArray[x] = array[x + 1];
                    else
                        newArray[x] = array[x];
                }
            }

            return newArray;
        }

        static int[] Remove(int[] array, int value)
        {
            return RemoveAt(array, Find(array, value));
        } 
        #endregion
    }
}
