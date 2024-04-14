using System.IO;
using System;

namespace DevOpsTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World Abhirukth";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw =  new StringWriter ()) 
            {
                Console.SetOut (sw);
                DevOps.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual (Expected, result);
            }
        }
    }
}