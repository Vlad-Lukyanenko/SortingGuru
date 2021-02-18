using System;

namespace SortingGuru.Application
{
    internal class Validation
    {
        public static void IsValid(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Array is null");
            }

            if (arr.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }
        }
    }
}
