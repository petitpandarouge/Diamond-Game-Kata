using FluentAssertions;
using NUnit.Framework;
using System;

namespace Bowling.Tests
{
    [TestFixture]
    public class DiamondTests
    {
        private Diamond _diamond;

        [SetUp]
        public void Setup()
        {
            _diamond = new Diamond();
        }

        [Test]
        public void Given_no_letter_Then_display_Should_be_nothing()
        {
            // Arrange
            var noLetter = '\0';

            // Act
            var display = _diamond.Generate(noLetter);

            // Assert
            display
                .Should()
                .Be("fiwme", "Pas de diamant affiché si pas de lettre.");
        }
    }
}