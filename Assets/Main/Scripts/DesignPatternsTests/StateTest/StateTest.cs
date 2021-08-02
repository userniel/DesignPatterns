using DesignPatterns.State;
using NUnit.Framework;

namespace DesignPatternsTests.StateTests
{
    public class Example : IContext<Example>
    {
        private State<Example> _state;
        public string _stateName;

        public State<Example> State { get => _state; set => _state = value; }

        public void Request()
        {
            _state.Handle();
        }
    }
    public class ConcreteStateA : State<Example>
    {
        public ConcreteStateA(Example context) : base(context)
        {
            _context._stateName = "A";
        }

        public override void Handle()
        {
            _context.State = new ConcreteStateB(_context);
        }
    }
    public class ConcreteStateB : State<Example>
    {
        public ConcreteStateB(Example context) : base(context)
        {
            _context._stateName = "B";
        }

        public override void Handle()
        {
            _context.State = new ConcreteStateC(_context);
        }
    }
    public class ConcreteStateC : State<Example>
    {
        public ConcreteStateC(Example context) : base(context)
        {
            _context._stateName = "C";
        }

        public override void Handle()
        {
            _context.State = new ConcreteStateA(_context);
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
        public void ChangeState_NotNull()
        {
            var context = new Example();

            context.State = new ConcreteStateA(context);

            Assert.NotNull(context.State);
        }
        [Test]
        public void ChangeState_ByContext_Succeed()
        {
            var context = new Example();

            context.State = new ConcreteStateA(context);
            Assert.AreEqual("A", context._stateName);

            context.State = new ConcreteStateB(context);
            Assert.AreEqual("B", context._stateName);
        }
        [Test]
        public void ChangeState_ByConcreteState_Succeed()
        {
            var context = new Example();
            context.State = new ConcreteStateA(context);

            context.Request();
            Assert.AreEqual("B", context._stateName);

            context.Request();
            Assert.AreEqual("C", context._stateName);

            context.Request();
            Assert.AreEqual("A", context._stateName);
        }
    }
}
