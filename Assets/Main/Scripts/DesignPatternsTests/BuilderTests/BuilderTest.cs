using NUnit.Framework;
using DesignPatterns.Builder;

namespace DesignPatternsTests.BuilderTests
{
    internal class Product1
    {
        public string _parts;

        public Product1() { }
    }
    internal class Product2
    {
        public string _parts;

        public Product2() { }
    }
    internal class ConcreteBuilder1 : Builder<Product1>
    {
        public override void Reset()
        {
            _result = new Product1();
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
    internal class ConcreteBuilder2 : Builder<Product2>
    {
        public override void Reset()
        {
            _result = new Product2();
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
            Product1 product1;
            Product2 product2;

            director.Construct(builder1);
            product1 = builder1.GetResult();
            Assert.AreEqual("aB", product1._parts);

            director.Construct(builder2);
            product2 = builder2.GetResult();
            Assert.AreEqual("AbC", product2._parts);
        }
    }
}
