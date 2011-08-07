using System;
using HoiPolloi;
using NUnit.Framework;

namespace HoitPolloi.Test
{
    [TestFixture]
    public class TestStringExtensions
    {

        [Test]
        public void TestNullStringReturnsNull()
        {
            // Arrange
            string myString = null;

            // Act
            string result = myString.Truncate(5);

            // Assert
            Assert.That(result, Is.Null);
        }

        [Test]
        public void TestEmptyStringReturnsEmptyString()
        {
            // Arrange
            string myString = String.Empty;

            // Act
            string result = myString.Truncate(5);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void TestWhitespaceStringReturnsTruncated()
        {
            // Arrange
            string myString = "          ";

            // Act
            string result = myString.Truncate(3);

            // Assert
            Assert.That(result, Is.EqualTo("   "));
        }


        [Test]
        public void TestWhitespaceLedStringRetainsSpaces()
        {
            // Arrange
            string myString = "    Hello World";

            // Act
            string result = myString.Truncate(7);

            // Assert
            Assert.That(result, Is.EqualTo("    Hel"));
        }

        [Test]
        public void TestWhitespaceTrailedStringRetainsSpaces()
        {
            // Arrange
            string myString = "Hello World        ";

            // Act
            string result = myString.Truncate(14);

            // Assert
            Assert.That(result, Is.EqualTo("Hello World   "));
        }


        [Test]
        public void TestStringShorterThanLength()
        {
            // Arrange
            string myString = "Too Short";

            // Act
            string result = myString.Truncate(40);

            // Assert
            Assert.That(result, Is.EqualTo("Too Short"));
        }

        [Test]
        public void TestExactStringLength()
        {
            // Arrange
            string myString = "Same Length";

            // Act
            string result = myString.Truncate(myString.Length);

            // Assert
            Assert.That(result, Is.EqualTo("Same Length"));
        }

        [Test]
        public void TestTruncateToZeroReturnsEmptyString()
        {
            // Arrange
            string myString = "Some string";

            // Act
            string result = myString.Truncate(0);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void TestTruncateDownToSingleChar()
        {
            // Arrange
            string myString = "Some string";

            // Act
            string result = myString.Truncate(1);

            // Assert
            Assert.That(result, Is.EqualTo("S"));
        }

        [Test]
        public void TestTruncateDownToNormalRange()
        {
            // Arrange
            string myString = "My long string";

            // Act
            string result = myString.Truncate(10);

            // Assert
            Assert.That(result, Is.EqualTo("My long st"));
        }

        [Test]
        public void TestNegativeTruncateThrows()
        {
            // Arrange
            string myString = "Any string";

            // Act / Assert
            Assert.That(() => myString.Truncate(-1), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }
    }
}
