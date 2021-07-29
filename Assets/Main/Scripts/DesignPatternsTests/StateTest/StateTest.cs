using System;
using NUnit.Framework;
using DesignPatterns.State;

namespace DesignPatternsTests.StateTests
{
    public class ExampleContext : Context
    {
        public override void Request()
        {
            base.Request();
        }
    }
    public class ConcreteStateA : State
    {
        public ConcreteStateA(Context context) : base(context) { }

        public override void Handle()
        {
            throw new NotImplementedException();
        }
    }
    public class ConcreteStateB : State
    {
        public ConcreteStateB(Context context) : base(context) { }

        public override void Handle()
        {
            throw new NotImplementedException();
        }
    }
    public class ConcreteStateC : State
    {
        public ConcreteStateC(Context context) : base(context) { }

        public override void Handle()
        {
            throw new NotImplementedException();
        }
    }

    [TestFixture]
    public class StateTest
    {
        //public void FunctionName_Scenario_ExpectedBehavior() { }

        [Test]
        public void CreateContext_NotNull()
        {
            // Arrange
            var context = new ExampleContext();

            // Act

            // Assert
            Assert.IsNotNull(context);
        }

        [Test]
        public void ChangeState_Succeed()
        {
            // Arrange

            // Act

            // Assert

        }
    }
}
