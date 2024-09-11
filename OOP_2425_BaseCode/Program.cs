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

            for (int x = 0; x < 100; x++)
            {
                list = AddToArray(list, rnd.Next(20));
                DisplayArray(list);
            }

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
    }
}
