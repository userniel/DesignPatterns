using NUnit.Framework;
using DesignPatterns.FactoryMethod;

namespace DesignPatternsTests.FactoryMethodTests
{
    internal class Factory : ICreator
    {
        public Product Create<T>() where T : Product, new()
        {
            Product product = new T();

            // Some progress...

            return product;
        }
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
        public void ChangeCreator_UsingClass_Succeed()
        {
            var creator = new Creator();
            Product product;

            product = creator.Create<ConcreteProductA>();
            Assert.AreEqual("A", product._name);

            product = creator.Create<ConcreteProductB>();
            Assert.AreEqual("B", product._name);
        }
        [Test]
        public void ChangeCreator_UsingInterface_Succeed()
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
