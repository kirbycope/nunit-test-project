using NUnit.Framework;

namespace NUnitTestProject.Tests
{
    public class TestContextExample
    {
        // Each NUnit test runs in an execution context, which includes information about the environment as well as the
        // test itself.
        // The TestContext class allows tests to access certain information about the execution context.
        // Source - https://github.com/nunit/docs/wiki/TestContext

        #region Test Methods

        [Test]
        public void PassingTest()
        {
            // Get the Test's method name
            string methodName = TestContext.CurrentContext.Test.MethodName;
            // Assert that the value is expected
            Assert.AreEqual("PassingTest", methodName);
        }

        [Test]
        public void FailingTest()
        {
            // Get the Test's method name
            string methodName = TestContext.CurrentContext.Test.MethodName;
            // Assert that the value is expected
            Assert.AreEqual("PassingTest", methodName);
        }

        #endregion Test Methods
    }
}
