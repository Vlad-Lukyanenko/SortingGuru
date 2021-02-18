using System;
using log4net;
using SortingGuru.Application;
using SortingGuru.Application.Enums;

namespace SortingGuru.UI
{
    internal class Program
    {
        private static readonly ILog log;

        static Program()
        {
            log = Logger.CreateInstance();
        }

        private static void Main()
        {
            const int n = 20;
            var sortingFactory = SortingFactory.CreateInstance(SortingType.BubbleSort);
            var original = Tools.RandomArray(n);

            Console.WriteLine("Original array: ");
            Tools.ShowArray(original);
            Console.WriteLine("\n");

            log.Debug($"Original array: {string.Join(" ", original)}");

            try
            {
                var sorted = sortingFactory.Sort(original, SortingOrder.Ascending);

                Console.WriteLine("Sorted array: ");
                Tools.ShowArray(sorted);

                log.Debug($"Sorted array: {string.Join(" ", sorted)}");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }

            Console.WriteLine();
        }
    }
}
