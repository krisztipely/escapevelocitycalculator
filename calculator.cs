using System;

namespace AstrophysicsEscapeVelocityCalculator
{
    public class EscapeVelocityCalculator
    {
        // Gravitational constant (m^3 kg^-1 s^-2)
        private const double GravitationalConstant = 6.67430e-11;

        /// <summary>
        /// Calculates the escape velocity for a celestial body.
        /// </summary>
        /// <param name="mass">Mass of the celestial body in kilograms.</param>
        /// <param name="radius">Radius of the celestial body in meters.</param>
        /// <returns>Escape velocity in meters per second.</returns>
        public static double CalculateEscapeVelocity(double mass, double radius)
        {
            if (mass <= 0 || radius <= 0)
            {
                throw new ArgumentException("Mass and radius must be positive values.");
            }

            return Math.Sqrt((2 * GravitationalConstant * mass) / radius);
        }
    }
}
