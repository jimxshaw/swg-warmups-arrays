using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using KeepLast;

namespace KeepLastTests
{
    [TestFixture]
    public class KeepLasTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(new int[] { 4, 5, 6 }, new int[] { 0, 0, 0, 0, 0, 6 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 0, 0, 0, 2 })]
        [TestCase(new int[] { 3 }, new int[] { 0, 3 })]
        public void KeepLast_Array_ReturnArray(int[] numbers, int[] expectedResult)
        {
            int[] result = _class1.KeepLast(numbers);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
