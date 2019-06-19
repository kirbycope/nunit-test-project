using NUnit.Framework;

namespace NUnitTestProject.Tests
{
    public class Ordering
    {
        // The OrderAttribute may be placed on a test method or fixture to specify the order in which tests are run.
        // Ordering is given by the required order argument to the attribute, an int.
        // Source - https://github.com/nunit/docs/wiki/Order-Attribute

        public static bool Test1Called;
        public static bool Test2ACalled;
        public static bool Test2BCalled;
        public static bool Test3Called;

        #region Test Methods

        [Test, Order(4)]
        public void Test3()
        {
            Test3Called = true;

            Assert.True(Test1Called);
            Assert.True(Test2ACalled);
            Assert.True(Test2BCalled);
        }

        [Test, Order(3)]
        public void Test2B()
        {
            Test2BCalled = true;

            Assert.True(Test1Called);
            Assert.True(Test2ACalled);
            Assert.False(Test3Called);
        }

        [Test, Order(2)]
        public void Test2A()
        {
            Test2ACalled = true;

            Assert.True(Test1Called);
            Assert.False(Test2BCalled);
            Assert.False(Test3Called);
        }

        [Test, Order(0)]
        public void Test1()
        {
            Test1Called = true;

            Assert.False(Test2ACalled);
            Assert.False(Test2BCalled);
            Assert.False(Test3Called);
        }

        #endregion Test Methods
    }
}
