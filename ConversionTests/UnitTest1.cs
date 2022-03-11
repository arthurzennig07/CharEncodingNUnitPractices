using System.Diagnostics;
using CharEncodingNUnitPractices.Services;
using NUnit.Framework;

namespace ConversionTests
{
    public class Tests
    {
        private char sample;
        
        [SetUp]
        public void Setup()
        {
            sample = 'H';
        }

        [Test]
        public void Test1()
        {
            //Arrange
            var encodingUtils = new CharEncodeUtility();
            
            //Act
            int result = encodingUtils.intValue(sample);
            //Assert
            Assert.Equals(72, result);
        }
    }
}