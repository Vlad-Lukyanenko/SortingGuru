using System;

namespace SortingGuru.UI
{
    internal class Tools
    {
        private static readonly Random r = new Random();

        public static int[] RandomArray(int size, int from = 0, int to = 100)
        {
            var arr = new int[size];

            for (var i = 0; i < size; i++)
            {
                arr[i] = r.Next(from, to);
            }

            return arr;
        }

        public static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
