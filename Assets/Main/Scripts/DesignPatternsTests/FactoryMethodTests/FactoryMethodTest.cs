using NUnit.Framework;
using DesignPatterns.FactoryMethod;

namespace DesignPatternsTests.FactoryMethodTests
{
    internal class Factory : ICreator<Product>
    {
        public Product Create<U>() where U : Product, new()
        {
            Product product = new U();

            // Some progress...

            return product;
        }
    }
    internal abstract class Product 
    {
        public string _name;

        public Product() { }
    }
    internal class ConcreteProductA : Product
    {
        public ConcreteProductA()
        {
            _name = "A";
        }
    }
    internal class ConcreteProductB : Product
    {
        public ConcreteProductB()
        {
            _name = "B";
        }
    }

    [TestFixture]
    public class FactoryMethodTest
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
        public void ChangeCreator_Succeed()
        {
            var factory = new Factory();
            Product product;

            product = factory.Create<ConcreteProductA>();
            Assert.AreEqual("A", product._name);

            product = factory.Create<ConcreteProductB>();
            Assert.AreEqual("B", product._name);
        }
    }
}
