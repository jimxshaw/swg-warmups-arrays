using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HasEven;
namespace HasEvenTests
{
    [TestFixture]
    public class HasEvenTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(new int[] { 2, 5 }, true)]
        [TestCase(new int[] { 4, 3 }, true)]
        [TestCase(new int[] { 7, 5 }, false)]
        public void HasEven_Array_ReturnBool(int[] numbers, bool expectedResult)
        {
            bool result = _class1.HasEven(numbers);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
