using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayManipulation;

namespace ArrayManipulationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOneArray()
        {
            //TDD Test Driven Development
            int[] myTestArray = { 5, 4, 6, 5, 3, 6, 8, 9 };
            Assert.AreEqual(46, CountingArrays.CountThisArray(myTestArray));

        }
        [TestMethod]
        public void TestOneArray2()
        {
            //TDD Test Driven Development
            int[] myTestArray = { 5, 4, 3, 2, 1  };
            Assert.AreEqual(15, CountingArrays.CountThisArray(myTestArray));

        }
        [TestMethod]
        public void TestOneArray3()
        {
            //TDD Test Driven Development
            int[] myTestArray = { 100, 400, 22, 67 };
            Assert.AreEqual(589, CountingArrays.CountThisArray(myTestArray));

        }

        [TestMethod]
        public void TestReverseArray()
        {
            //TDD Test Driven Development
            int[] myTestArray = { 100, 400, 22, 67 };
            int[] reverseTest = { 67, 22, 400, 100 };
            CollectionAssert.AreEqual(reverseTest, ReverseArrays.ReversedArray(myTestArray));

        }

        [TestMethod]
        public void TestReverseArray2()
        {
            //TDD Test Driven Development
            int[] myTestArray = { 2, 3, 5, 67, 334, 2, 1, 0 };
            int[] reverseTest = { 0, 1, 2, 334, 67, 5, 3, 2 };
            CollectionAssert.AreEqual(reverseTest, ReverseArrays.ReversedArray(myTestArray));

        }

        [TestMethod]
        public void TestRotateArray1()
        {
            //TDD Test Driven Development
            int[] myTestArray = { 100, 400, 22, 67 };
            int[] myRotatedArray = { 22, 67, 100, 400 };
            CollectionAssert.AreEqual(myRotatedArray, NewRotation.NewRotatedArray(myTestArray, "r", 2));

        }

        [TestMethod]
        public void TestRotateArray2()
        {
            //TDD Test Driven Development
            int[] myTestArray = { 100, 400, 22, 67, 66, 54, 45, 66, 32, 43 };
            int[] myRotatedArray = { 54, 45, 66, 32, 43, 100, 400, 22, 67, 66 };
            CollectionAssert.AreEqual(myRotatedArray, NewRotation.NewRotatedArray(myTestArray, "l", 5));

        }

    }
}
