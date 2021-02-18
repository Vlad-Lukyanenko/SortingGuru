using SortingGuru.Application.Enums;
using System;

namespace SortingGuru.Application
{
    public abstract class SortingFactory
    {
        public static ISort CreateInstance(SortingType sortingType)
        {
            return sortingType switch
            {
                SortingType.BubbleSort => new BubbleSort(),
                SortingType.CocktailSort => new CocktailSort(),
                _ => throw new ArgumentException($"Such type: {sortingType} doesn't exist"),
            };            
        }
    }
}
