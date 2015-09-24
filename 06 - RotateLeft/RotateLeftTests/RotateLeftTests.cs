using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RotateLeft;

namespace RotateLeftTests
{
    [TestFixture]
    public class RotateLeftTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3, 1 })]
        [TestCase(new int[] { 7, 8, 9 }, new int[] { 8, 9, 7 })]
        [TestCase(new int[] { 7, 0, 0 }, new int[] { 0, 0, 7 })]
        public void RotateLeft_Array_ReturnArray(int[] numbers, int[] expectedResult)
        {
            int[] result = _class1.RotateLeft(numbers);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
