using NUnit.Framework;
using DesignPatterns.State;

namespace DesignPatternsTests.StateTests
{
    public class Example : Context
    {
        public string _stateName;
    }
    public class ConcreteStateA : IState
    {
        private readonly Example _context;

        public ConcreteStateA(Example example)
        {
            _context = example;
            _context._stateName = "A";
        }

        public void Handle()
        {
            _context.SetState(new ConcreteStateB(_context));
        }
    }
    public class ConcreteStateB : IState
    {
        private readonly Example _context;

        public ConcreteStateB(Example example)
        {
            _context = example;
            _context._stateName = "B";
        }

        public void Handle()
        {
            _context.SetState(new ConcreteStateC(_context));
        }
    }
    public class ConcreteStateC : IState
    {
        private readonly Example _context;

        public ConcreteStateC(Example example)
        {
            _context = example;
            _context._stateName = "C";
        }

        public void Handle()
        {
            _context.SetState(new ConcreteStateA(_context));
        }
    }

    [TestFixture]
    public class StateTest
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
            var context = new Example();

            Assert.NotNull(context);
        }
        [Test]
        public void ChangeState_ByContext_NotNull()
        {
            var context = new Example();

            context.SetState(new ConcreteStateA(context));

            Assert.NotNull(context.GetState());
        }
        [Test]
        public void ChangeState_ByContext_Succeed()
        {
            var context = new Example();

            context.SetState(new ConcreteStateA(context));
            Assert.AreEqual("A", context._stateName);

            context.SetState(new ConcreteStateB(context));
            Assert.AreEqual("B", context._stateName);
        }
        [Test]
        public void ChangeState_ByConcreteState_NotNull()
        {
            var context = new Example();
            context.SetState(new ConcreteStateA(context));

            context.Request();

            Assert.NotNull(context.GetState());
        }
        [Test]
        public void ChangeState_ByConcreteState_Succeed()
        {
            var context = new Example();
            context.SetState(new ConcreteStateA(context));

            context.Request();
            Assert.AreEqual("B", context._stateName);

            context.Request();
            Assert.AreEqual("C", context._stateName);

            context.Request();
            Assert.AreEqual("A", context._stateName);
        }
    }
}
