using NUnit.Framework;
using DesignPatterns.FactoryMethod;

namespace DesignPatternsTests.FactoryTests
{
    public class Factory : ICreator
    {
        public Product Create<T>() where T : Product, new()
        {
            return new T();
        }
    }
    public class ConcreteProductA : Product
    {
        public ConcreteProductA()
        {
            _name = "A";
        }
    }
    public class ConcreteProductB : Product
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
        public void ChangeCreator_ByClass_Succeed()
        {
            var creator = new Creator();
            Product product = null;

            product = creator.Create<ConcreteProductA>();
            Assert.AreEqual("A", product._name);

            product = creator.Create<ConcreteProductB>();
            Assert.AreEqual("B", product._name);
        }
        [Test]
        public void ChangeCreator_ByInterface_Succeed()
        {
            var factory = new Factory();
            Product product = null;

            product = factory.Create<ConcreteProductA>();
            Assert.AreEqual("A", product._name);

            product = factory.Create<ConcreteProductB>();
            Assert.AreEqual("B", product._name);
        }
    }
}
