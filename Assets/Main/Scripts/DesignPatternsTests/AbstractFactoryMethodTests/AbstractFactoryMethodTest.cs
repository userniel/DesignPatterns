using NUnit.Framework;
using DesignPatterns.AbstractFactoryMethod;

namespace DesignPatternsTests.AbstractFactoryMethodTests
{
    internal class ConcreteFactory1 : Factory
    {
        public override ProductA CreateA<T>()
        {
            ProductA productA = new T();

            // Some progress...
            productA._name += "1";

            return productA;
        }
        public override ProductB CreateB<T>()
        {
            ProductB productB = new T();

            // Some progress...
            productB._name += "1";

            return productB;
        }
    }
    internal class ConcreteFactory2 : Factory
    {
        public override ProductA CreateA<T>()
        {
            ProductA productA = new T();

            // Some progress...
            productA._name += "2";

            return productA;
        }
        public override ProductB CreateB<T>()
        {
            ProductB productB = new T();

            // Some progress...
            productB._name += "2";

            return productB;
        }
    }
    internal class ConcreteProductA : ProductA
    {
        public ConcreteProductA()
        {
            _name = "A";
        }
    }
    internal class ConcreteProductB : ProductB
    {
        public ConcreteProductB()
        {
            _name = "B";
        }
    }

    [TestFixture]
    public class AbstractFactoryMethodTest
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
        public void ChangeFactory_Succeed()
        {
            Factory factory;
            ProductA productA;
            ProductB productB;

            factory = new ConcreteFactory1();
            productA = factory.CreateA<ConcreteProductA>();
            productB = factory.CreateB<ConcreteProductB>();

            Assert.AreEqual("A1", productA._name);
            Assert.AreEqual("B1", productB._name);

            factory = new ConcreteFactory2();
            productA = factory.CreateA<ConcreteProductA>();
            productB = factory.CreateB<ConcreteProductB>();

            Assert.AreEqual("A2", productA._name);
            Assert.AreEqual("B2", productB._name);
        }
    }
}
