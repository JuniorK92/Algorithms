using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum1Test()
        {
            var result = new Program().Sum_1(2, 2);
            Assert.AreEqual(result, 12);
        }
        [TestMethod]
        public void AbsoluteDifferenceTest()
        {
            int[] values = new int[] { 53, 30, 51 };
            int[] expected = new int[] { 6, 21, 0 };

            var result = new Program().AbsoluteDifference(values[1]);
            Assert.AreEqual(expected[1], result);
        }
        [TestMethod]
        public void NumberCheckTest()
        {
            var result = new Program().NumberCheck(20, 25);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void IfStringInserterTest()
        {
            var result = new Program().IfStringInserter("");
            Assert.AreEqual("if else", result);
        }
        [TestMethod]
        public void Test1()
        {
            var values = new string[] { "abcd", "a", "xy" };
            var expected = new string[] { "dbca", "a", "yx" };
            var result = new string[3];

            for (int i = 0; i < 3; i++)
            {
                result[i] = Program.CharacterExchanger(values[i]);
            }

            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]        
        public void AlgoTest()
        {
            //Assert.AreEqual(23, Program.Algo(1000));
            Assert.AreEqual(1, Program.Algo(new[] { 1, 2, 2, 2 }));
            Assert.AreEqual(-2, Program.Algo(new[] { -2, 2, 2, 2 }));
            Assert.AreEqual(14, Program.Algo(new[] { 11, 11, 14, 11, 11 }));
        }
    }
}
