using SortingGuru.Application.Enums;

namespace SortingGuru.Application
{
    public interface ISort
    {
        int[] Sort(int[] arr, SortingOrder sortOrder = SortingOrder.Ascending);
    }
}
