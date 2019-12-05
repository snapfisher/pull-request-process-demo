using System;
using BTRun;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BTTests
{
    [TestClass]
    public class GetValuesTests
    {
        [TestMethod]
        public void GetThreeTest()
        {
            GetValues gv = new GetValues();
            int res = gv.GetThree();

            Assert.IsTrue(res == 3);
        }
    }
}
