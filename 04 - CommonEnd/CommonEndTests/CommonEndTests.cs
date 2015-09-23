using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CommonEnd;

namespace CommonEndTests
{
    [TestFixture]
    public class CommonEndTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 7, 3 }, true)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 7, 3, 2 }, false)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 3 }, true)]
        public void CommonEnd_Arrays_ReturnBool(int[] a, int[] b, bool expectedResult)
        {
            bool result = _class1.CommonEnd(a, b);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
