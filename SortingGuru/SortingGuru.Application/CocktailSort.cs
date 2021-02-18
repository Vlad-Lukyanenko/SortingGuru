using SortingGuru.Application.Enums;

namespace SortingGuru.Application
{
    public class CocktailSort : ISort
    {
        public int[] Sort(int[] arr, SortingOrder sortOrder = SortingOrder.Ascending)
        {
            Validation.IsValid(arr);

            return SortArray(arr, sortOrder);
        }

        private int[] SortArray(int[] arr, SortingOrder sortOrder)
        {
            bool swapped = true;
            int start = 0;
            int end = arr.Length;

            while (swapped == true)
            {
                swapped = false;

                for (int i = start; i < end - 1; ++i)
                {
                    Sort(sortOrder, ref arr[i], ref arr[i + 1], ref swapped);
                }

                if (swapped == false)
                {
                    break;
                }

                swapped = false;
                end -= 1;

                for (int i = end - 1; i >= start; i--)
                {
                    Sort(sortOrder, ref arr[i], ref arr[i + 1], ref swapped);
                }

                start += 1;
            }

            return arr;
        }

        private void Sort(SortingOrder sortingOrder, ref int x, ref int y, ref bool swapped)
        {
            if (sortingOrder == SortingOrder.Ascending)
            {
                SortAscending(ref x, ref y, ref swapped);
            }
            else if (sortingOrder == SortingOrder.Descending)
            {
                SortDescending(ref x, ref y, ref swapped);
            }
        }

        private void SortDescending(ref int x, ref int y, ref bool swapped)
        {
            if (x < y)
            {
                Tools.Swap(ref x, ref y);
                swapped = true;
            }
        }

        private void SortAscending(ref int x, ref int y, ref bool swapped)
        {
            if (x > y)
            {
                Tools.Swap(ref x, ref y);
                swapped = true;
            }
        }
    }
}
