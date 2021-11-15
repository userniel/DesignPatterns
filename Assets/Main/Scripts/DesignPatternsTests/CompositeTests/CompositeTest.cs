using NUnit.Framework;
using DesignPatterns.Builder;
using DesignPatterns.Composite;

namespace DesignPatternsTests.CompositeTests
{
    internal class Product : Leaf
    {
        private int _price;

        public int GetPrice() => _price;
    }
    internal class Carton : Composite
    {
        private Product[] _products;
    }
    internal class TreeBuilder : Builder<IComponent>
    {
        public override void AddPartA()
        {
            throw new System.NotImplementedException();
        }
        public override void AddPartB()
        {
            throw new System.NotImplementedException();
        }
        public override void AddPartC()
        {
            throw new System.NotImplementedException();
        }
        public override void Reset()
        {
            
        }
    }

    [TestFixture]
    public class CompositeTest
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
        public void CompositeTestSimplePasses()
        {
            
        }
    }
}
