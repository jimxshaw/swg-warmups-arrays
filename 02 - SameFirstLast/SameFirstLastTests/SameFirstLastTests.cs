using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SameFirstLast;

namespace SameFirstLastTests
{
    [TestFixture]
    public class SameFirstLastTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(new int[] { 1, 2, 3 }, false)]
        [TestCase(new int[] { 1, 2, 3, 1 }, true)]
        [TestCase(new int[] { 1, 2, 1 }, true)]
        public void SameFirstLast_Array_ReturnBool(int[] numbers, bool expectedResult)
        {
            bool result = _class1.SameFirstLast(numbers);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
