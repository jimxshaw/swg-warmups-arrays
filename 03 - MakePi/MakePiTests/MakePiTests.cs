using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MakePi;

namespace MakePiTests
{
    [TestFixture]
    public class MakePiTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(3, new int[] {3, 1, 4})]
        public void MakePi_Int_ReturnArray(int n, int[] expectedResult)
        {
            int[] result = _class1.MakePi(n);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
