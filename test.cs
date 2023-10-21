using System;
using NUnit.Framework;

namespace AstrophysicsEscapeVelocityCalculator.Tests
{
    [TestFixture]
    public class EscapeVelocityCalculatorTests
    {
        [Test]
        public void CalculateEscapeVelocity_ValidInput_ReturnsCorrectValue()
        {
            // Arrange
            double mass = 5.972e24; // Earth mass in kilograms
            double radius = 6.371e6; // Earth radius in meters

            // Act
            double escapeVelocity = EscapeVelocityCalculator.CalculateEscapeVelocity(mass, radius);

            // Assert
            Assert.AreEqual(11184.9, escapeVelocity, 0.1); // Earth escape velocity in m/s
        }

        [Test]
        public void CalculateEscapeVelocity_InvalidInput_ThrowsArgumentException()
        {
            // Arrange
            double invalidMass = -1;
            double validRadius = 6.371e6;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => EscapeVelocityCalculator.CalculateEscapeVelocity(invalidMass, validRadius));
        }
    }
}
