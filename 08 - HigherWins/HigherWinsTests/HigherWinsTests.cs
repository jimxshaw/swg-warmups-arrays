using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HigherWins;

namespace HigherWinsTests
{
    [TestFixture]
    public class HigherWinsTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] {3, 3, 3})]
        [TestCase(new int[] { 11, 5, 9 }, new int[] {11, 11, 11})]
        [TestCase(new int[] { 2, 11, 3 }, new int[] {3, 3, 3})]
        public void HigherWins_Array_ReturnArray(int[] numbers, int[] expectedResult)
        {
            int[] result = _class1.HigherWins(numbers);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
