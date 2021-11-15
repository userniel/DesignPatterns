using NUnit.Framework;
using DesignPatterns.Adapter;

namespace DesignPatternsTests.AdapterTests
{
    internal interface IProductA
    {
        public string FunctionA();
    }
    internal class ProductA : IProductA
    {
        public ProductA() { }

        public string FunctionA()
        {
            return "AAA";
        }
    }
    internal class ProductB 
    {
        public ProductB() { }

        public string FunctionB()
        {
            return "BBB";
        }
    }
    internal class ProductAAdapter : Adapter<ProductB>, IProductA
    {
        public ProductAAdapter(ProductB adaptee) : base(adaptee)
        {
            _adaptee = adaptee;
        }

        public string FunctionA()
        {
            return _adaptee.FunctionB();
        }
    }
    [TestFixture]
    public class AdapterTest
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
        public void ChangeFunction_Succeed()
        {
            IProductA productA;
            var product = new ProductA();
            var adapter = new ProductAAdapter(new ProductB());

            productA = product;
            Assert.AreNotEqual("BBB", productA.FunctionA());
            productA = adapter;
            Assert.AreEqual("BBB", productA.FunctionA());
        }
    }
}
