using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Reverse;
namespace ReverseTests
{
    [TestFixture]
    public class ReverseTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1})]
        public void Reverse_Array_ReturnArray(int[] numbers, int[] expectedResult)
        {
            int[] result = _class1.Reverse(numbers);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
