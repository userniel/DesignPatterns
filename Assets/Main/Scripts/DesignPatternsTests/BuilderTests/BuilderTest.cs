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
    internal class ConcreteBuilder1 : Builder
    {
        private ConcreteProduct1 _product;

        public override void Reset()
        {
            _product = new ConcreteProduct1();
        }
        public override void AddPartA()
        {
            _product._parts += "a";
        }
        public override void AddPartB()
        {
            _product._parts += "B";
        }
        public override void AddPartC()
        {

        }

        public ConcreteProduct1 GetProduct() => _product;
    }
    internal class ConcreteBuilder2 : Builder
    {
        private ConcreteProduct2 _product;

        public override void Reset()
        {
            _product = new ConcreteProduct2();
        }
        public override void AddPartA()
        {
            _product._parts += "A";
        }
        public override void AddPartB()
        {
            _product._parts += "b";
        }
        public override void AddPartC()
        {
            _product._parts += "C";
        }

        public ConcreteProduct2 GetProduct() => _product;
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
            product1 = builder1.GetProduct();
            Assert.AreEqual("aB", product1._parts);

            director.Construct(builder2);
            product2 = builder2.GetProduct();
            Assert.AreEqual("AbC", product2._parts);
        }
    }
}
