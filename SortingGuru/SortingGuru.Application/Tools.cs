namespace SortingGuru.Application
{
    public class Tools
    {
        public static void Swap(ref int x, ref int y)
        {
            int c = y;
            y = x;
            x = c;
        }
    }
}
