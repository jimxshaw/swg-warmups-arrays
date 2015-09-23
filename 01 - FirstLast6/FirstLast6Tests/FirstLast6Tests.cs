using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FirstLast6;

namespace FirstLast6Tests
{
    [TestFixture]
    public class FirstLast6Tests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(new int[] { 1, 2, 6 }, true)]
        [TestCase(new int[] { 6, 1, 2, 3 }, true)]
        [TestCase(new int[] { 13, 6, 1, 2, 3 }, false)]
        public void FirstLast6_Array_ReturnBool(int[] numbers, bool expectedResult)
        {
            bool result = _class1.FirstLast6(numbers);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
