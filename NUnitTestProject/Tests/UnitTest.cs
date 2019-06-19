using NUnit.Framework;

namespace Tests
{
    public class UnitTest
    {
        #region Test Methods

        // The Test attribute is one way of marking a method inside a TestFixture class as a test.
        // It is normally used for simple (non-parameterized) tests but may also be applied to parameterized tests
        // without causing any extra test cases to be generated.
        // Source: https://github.com/nunit/docs/wiki/Test-Attribute
        [Test]
        public void PassingTest()
        {
            Assert.AreEqual(4, Add(2, 2));
        }

        [Test]
        public void FailingTest()
        {
            Assert.AreEqual(5, Add(2, 2));
        }

        // TestCaseAttribute serves the dual purpose of marking a method with parameters as a test method and providing
        // inline data to be used when invoking that method.
        // Source - https://github.com/nunit/docs/wiki/TestCase-Attribute
        [Test]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(6)]
        public void MyFirstTestCase(int value)
        {
            Assert.True(IsOdd(value));
        }

        #endregion Test Methods

        #region Utility Methods

        private int Add(int x, int y)
        {
            return x + y;
        }

        private bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

        #endregion Utility Methods
    }
}