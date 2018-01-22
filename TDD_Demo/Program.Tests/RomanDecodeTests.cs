using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Program.Tests
{
    [TestClass]
    public class RomanDecodeTests
    {
        //Function Name Patterns : MentodName_StateUnderTest_ExpectedBehavior
        [TestMethod]
        public void ConvertToDecimal_I_1()
        {
            var romanDecode = new RomanDecode();
            var roman = "I";
            var expected = 1;

            // Act
            var result = romanDecode.ConvertToDecimal(roman);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertToDecimal_V_5()
        {
            var romanDecode = new RomanDecode();
            var roman = "V";
            var expected = 5;

            // Act
            var result = romanDecode.ConvertToDecimal(roman);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
