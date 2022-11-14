using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.Test
{
    [TestClass]
    public class PrimeTest
    {
        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            bool result = Prime.IsPrime(value);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DivMod_InputIs3_ReturnTrue()
        {
            bool result = Prime.IsPrime(3);

            Assert.IsTrue(result);
        }
    }
}
