using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sum;

namespace SumTests
{
    [TestFixture]
    public class SumTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(new int[] { 1, 2, 3 }, 6)]
        [TestCase(new int[] { 5, 11, 2 }, 18)]
        [TestCase(new int[] { 7, 0, 0 }, 7)]
        public void Sum_Array_ReturnInt(int[] numbers, int expectedResult)
        {
            int result = _class1.Sum(numbers);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
