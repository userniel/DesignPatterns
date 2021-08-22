using NUnit.Framework;
using DesignPatterns.Strategy;

namespace DesignPatternsTests.StrategyTests
{
    internal class ConcreteStrategyA : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }
    internal class ConcreteStrategyB : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }
    internal class ConcreteStrategyC : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }

    [TestFixture]
    public class StrategyTest
    {
        #region Test Function Example
        //[Test]
        //public void FunctionName_Scenario_ExpectedBehavior()
        //{
        //    // Arrange
        //    // Act
        //    // Assert
        //}
        #endregion

        [Test]
        public void CreateContext_NotNull()
        {
            var context = new Context();

            Assert.NotNull(context);
        }
        [Test]
        public void ChangeStrategy_NotNull()
        {
            var context = new Context();

            context.SetStrategy(new ConcreteStrategyA());

            Assert.NotNull(context.GetStrategy());
        }
        [Test]
        public void ChangeStrategy_Succeed()
        {
            var context = new Context();

            context.SetStrategy(new ConcreteStrategyA());
            Assert.AreEqual(3, context.Request(1, 2));

            context.SetStrategy(new ConcreteStrategyB());
            Assert.AreEqual(-1, context.Request(1, 2));

            context.SetStrategy(new ConcreteStrategyC());
            Assert.AreEqual(2, context.Request(1, 2));
        }
    }
}
