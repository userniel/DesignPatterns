using NUnit.Framework;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Builder;

namespace DesignPatternsTests.BuilderTests
{
    internal class ConcreteProduct1 : Product
    {
        public string _parts;
    }
    internal class ConcreteProduct2 : Product
    {
        public string _parts;
    }
    internal class ConcreteBuilder1 : Builder<ConcreteProduct1>
    {
        public override void Reset()
        {
            _result = new ConcreteProduct1();
        }
        public override void AddPartA()
        {
            _result._parts += "a";
        }
        public override void AddPartB()
        {
            _result._parts += "B";
        }
        public override void AddPartC()
        {

        }
    }
    internal class ConcreteBuilder2 : Builder<ConcreteProduct2>
    {
        public override void Reset()
        {
            _result = new ConcreteProduct2();
        }
        public override void AddPartA()
        {
            _result._parts += "A";
        }
        public override void AddPartB()
        {
            _result._parts += "b";
        }
        public override void AddPartC()
        {
            _result._parts += "C";
        }
    }

    [TestFixture]
    public class BuilderTest
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
        public void ChangeBuilder_Succeed()
        {
            var director = new Director();
            var builder1 = new ConcreteBuilder1();
            var builder2 = new ConcreteBuilder2();
            ConcreteProduct1 product1;
            ConcreteProduct2 product2;

            director.Construct(builder1);
            product1 = builder1.GetResult();
            Assert.AreEqual("aB", product1._parts);

            director.Construct(builder2);
            product2 = builder2.GetResult();
            Assert.AreEqual("AbC", product2._parts);
        }
    }
}
