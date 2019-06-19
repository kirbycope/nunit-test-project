using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTestProject.Tests
{
    public class SetupAndTeardown
    {
        #region Test Setup and Teardown

        /// <summary>
        /// A example of a variable that is used in each [Test] but it's value is reset with each test.
        /// </summary>
        private Stack<int> stack;

        // This attribute is used inside a TestFixture to provide a common set of functions that are performed just
        // before each test method is called.
        // Source - https://github.com/nunit/docs/wiki/SetUp-Attribute
        [SetUp]
        public void SetUp()
        {
            // Instantiate the stack variable
            stack = new Stack<int>();
        }

        // This attribute is used inside a TestFixture to provide a common set of functions that are performed after
        // each test method.
        // Source - https://github.com/nunit/docs/wiki/TearDown-Attribute
        [TearDown]
        public void TearDown()
        {
            //stack.Dispose();
            stack.Clear();
        }

        #endregion Test Setup and Teardown

        #region Test Methods

        [Test]
        public void WithNoItems_CountShouldReturnZero()
        {
            // Get the count of objects in the stack
            var count = stack.Count;
            // Assert that the value is expected
            Assert.AreEqual(0, count);
        }

        [Test]
        public void AfterPushingItem_CountShouldReturnOne()
        {
            // Insert a value (42) at the top of the stack
            stack.Push(42);
            // Get the count of objects in the stack
            var count = stack.Count;
            // Assert that the value is expected
            Assert.AreEqual(1, count);
        }

        #endregion Test Methods
    }
}
