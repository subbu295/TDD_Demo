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

        [TestMethod]
        public void ConvertToDecimal_VI_6()
        {
            var romanDecode = new RomanDecode();
            var roman = "VI";
            var expected = 6;

            // Act
            var result = romanDecode.ConvertToDecimal(roman);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertToDecimal_MDCLXVI_1666()
        {
            var romanDecode = new RomanDecode();
            var roman = "MDCLXVI";
            var expected = 1666;

            // Act
            var result = romanDecode.ConvertToDecimal(roman);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertToDecimal_IV_4()
        {
            var romanDecode = new RomanDecode();
            var roman = "IV";
            var expected = 4;

            // Act
            var result = romanDecode.ConvertToDecimal(roman);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertToDecimal_CMXCIX_999()
        {
            var romanDecode = new RomanDecode();
            var roman = "CMXCIX";
            var expected = 999;

            // Act
            var result = romanDecode.ConvertToDecimal(roman);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertToDecimal_MMMMCMXCIX_4999()
        {
            var romanDecode = new RomanDecode();
            var roman = "MMMMCMXCIX";
            var expected = 4999;

            // Act
            var result = romanDecode.ConvertToDecimal(roman);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Invalid roman string.")]
        public void ConvertToDecimal_NULL_Exception()
        {
            var romanDecode = new RomanDecode();
            string roman = null;
           
            // Act
            romanDecode.ConvertToDecimal(roman);
        }
    }
}
