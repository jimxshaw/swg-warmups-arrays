using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Fix23;

namespace Fix23Tests
{
    [TestFixture]
    public class Fix23Tests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 0 })]
        [TestCase(new int[] { 2, 3, 5 }, new int[] { 2, 0, 5 })]
        [TestCase(new int[] { 1, 2, 1 }, new int[] { 1, 2, 1 })]
        public void Fix23_Array_ReturnArray(int[] numbers, int[] expectedResult)
        {
            int[] result = _class1.Fix23(numbers);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
