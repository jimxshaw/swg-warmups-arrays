using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Double23;

namespace Double23Tests
{
    [TestFixture]
    public class Double23Tests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(new int[] { 2, 2, 3 }, true)]
        [TestCase(new int[] { 3, 4, 5, 3 }, true)]
        [TestCase(new int[] { 2, 3, 2, 2 }, false)]
        public void Double23_Array_ReturnBool(int[] numbers, bool expectedResult)
        {
            bool result = _class1.Double23(numbers);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
