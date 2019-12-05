using System;
using BTRun;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BTTests.Integration
{
    [TestClass]
    public class SetValuesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            SetValues sv = new SetValues();
            sv.SetThreeToDatabase();
        }
    }
}
