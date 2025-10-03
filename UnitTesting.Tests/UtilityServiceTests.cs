using NUnit.Framework;
using System;
using UnitTesting.Services;

namespace YourProject.Tests
{
    [TestFixture]
    public class UtilityServiceTests
    {
        private UtilityService _service = null!;

        [SetUp]
        public void SetUp()
        {
            // Arrange (test fixture-level): create instance for each test
            _service = new UtilityService();
        }

        // -------------------------
        // CountVowels tests (>= 8 cases)
        // -------------------------
        [TestCase("hello", 2)]
        [TestCase("AEIOU", 5)]
        [TestCase("xyz", 0)]
        [TestCase("Hello World!", 3)]
        [TestCase("", 0)]
        [TestCase("Where? Because.", 6)]
        [TestCase("bcd-fg123!@", 0)]
        [TestCase("A quick brown fox.", 5)]
        public void CountVowels_ReturnsExpected(string input, int expected)
        {
            // Arrange (nothing else to set up)

            // Act
            var result = _service.CountVowels(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // -------------------------
        // IsLeapYear tests (>= 10 cases covering branches + exceptions)
        // -------------------------
        [TestCase(2024, true)]
        [TestCase(2023, false)]
        [TestCase(2000, true)]
        [TestCase(1900, false)]
        [TestCase(2100, false)]
        [TestCase(1600, true)]
        [TestCase(4, true)]
        [TestCase(1, false)]
        [TestCase(2400, true)]
        [TestCase(100, false)]
        public void IsLeapYear_ReturnsExpected_ForValidYears(int year, bool expected)
        {
            // Arrange (already done in SetUp)

            // Act
            var result = _service.IsLeapYear(year);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsLeapYear_YearZero_ThrowsArgumentException()
        {
            // Arrange
            int year = 0;

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => _service.IsLeapYear(year));
            Assert.That(ex?.ParamName, Is.EqualTo("year"));
        }

        [Test]
        public void IsLeapYear_NegativeYear_ThrowsArgumentException()
        {
            // Arrange
            int year = -5;

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => _service.IsLeapYear(year));
            Assert.That(ex?.ParamName, Is.EqualTo("year"));
        }

        // -------------------------
        // IsPalindromeNumber tests (>= 12 cases)
        // -------------------------
        [TestCase(121, true)]
        [TestCase(-121, false)]
        [TestCase(10, false)]
        [TestCase(12321, true)]
        [TestCase(0, true)]
        [TestCase(7, true)]
        [TestCase(1001, true)]
        [TestCase(12345, false)]
        [TestCase(1221, true)]
        [TestCase(1, true)]
        [TestCase(11, true)]
        [TestCase(123454321, true)]
        [TestCase(2147447412, true)] // large palindrome within int range
        [TestCase(2147483647, false)] // max int, not a palindrome
        public void IsPalindromeNumber_ReturnsExpected(int number, bool expected)
        {
            // Arrange (instance prepared in SetUp)

            // Act
            var result = _service.IsPalindromeNumber(number);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}