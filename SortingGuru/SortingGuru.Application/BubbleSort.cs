using SortingGuru.Application.Enums;

namespace SortingGuru.Application
{
    public class BubbleSort : ISort
    {
        public int[] Sort(int[] arr, SortingOrder sortOrder = SortingOrder.Ascending)
        {
            Validation.IsValid(arr);

            return SortArray(arr, sortOrder);
        }

        private int[] SortArray(int[] arr, SortingOrder sortOrder)
        {
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    Sort(sortOrder, ref arr[i], ref arr[j]);
                }
            }

            return arr;
        }

        private void Sort(SortingOrder sortingOrder, ref int x, ref int y)
        {
            if (sortingOrder == SortingOrder.Ascending)
            {
                SortAscending(ref x, ref y);
            }
            else if (sortingOrder == SortingOrder.Descending)
            {
                SortDescending(ref x, ref y);
            }
        }

        private void SortAscending(ref int x, ref int y)
        {
            if (x > y)
            {
                Tools.Swap(ref x, ref y);
            }
        }

        private void SortDescending(ref int x, ref int y)
        {
            if (x < y)
            {
                Tools.Swap(ref x, ref y);
            }
        }
    }
}
