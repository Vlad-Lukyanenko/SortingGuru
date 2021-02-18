using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using SortingGuru.Application;
using SortingGuru.Application.Enums;
using System;

namespace SortingGuru.Tests
{
    public class CocktailSortTests
    {
        private ISort _bubbleMaster;
        private ServiceProvider _serviceProvider;

        [SetUp]
        public void Setup()
        {
            _serviceProvider = new ServiceCollection()
                .AddSingleton<ISort, CocktailSort>()
                .BuildServiceProvider();
            
            _bubbleMaster = _serviceProvider.GetService<ISort>();
        }

        [Test]
        public void SortArrayAscendingTest()
        {
            var arr = new int[] { 1, 4, 3, 5, 6, 2 };

            var actualResult = _bubbleMaster.Sort(arr, SortingOrder.Ascending);
            var expectedResult = new int[] { 1, 2, 3, 4, 5, 6 };

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void SortArrayDescendingTest()
        {
            var arr = new int[] { 1, 4, 3, 5, 6, 2 };

            var actualResult = _bubbleMaster.Sort(arr, SortingOrder.Descending);
            var expectedResult = new int[] { 6, 5, 4, 3, 2, 1 };

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void EmptyArrayTest()
        {
            var arr = new int[] { };
            bool callFailed = false;

            try
            {
                var actualResult = _bubbleMaster.Sort(arr);
            }
            catch (ArgumentException)
            {
                callFailed = true;
            }

            Assert.IsTrue(callFailed, "Expected call to Sort to fail with ArgumentException");
        }

        [Test]
        public void ArrayIsNullTest()
        {
            int[] arr = null;

            bool callFailed = false;

            try
            {
                var actualResult = _bubbleMaster.Sort(arr);
            }
            catch (ArgumentNullException)
            {
                callFailed = true;
            }

            Assert.IsTrue(callFailed, "Expected call to Sort to fail with ArgumentNullException");
        }
    }
}