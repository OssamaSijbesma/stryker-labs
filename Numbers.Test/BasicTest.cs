using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.Test
{
    [TestClass]
    public class BasicTest
    {
        [TestMethod]
        public void UnderLimit_InputIs6_LimitIs18_ReturnTrue()
        {
            var result = Basic.UnderLimit(6, 8);
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void NumbersEqual_InputIsTheSame_EpsilonIsBiggerThanDistance_ReturnTrue()
        {
            var result = Basic.NumbersEqual(3, 3, 5);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DivMod_InputIs3and9_Return0And3()
        {
            var result = Basic.DivMod(3, 9);
            Assert.AreEqual(result, new Tuple<decimal,decimal>(0,3));
        }
    }
}
