# escapevelocitycalculator
This C# project, the Astrophysics Escape Velocity Calculator, enables users to compute the escape velocity for celestial bodies.The calculator utilizes the gravitational constant, mass, and radius of the celestial body to provide accurate escape velocity calculations.
Escape velocity is the minimum speed needed for an object to "break free" from the gravitational influence of a massive body. 

## Features

**Scientific Accuracy:**

Utilizes the gravitational constant and principles of astrophysics to calculate escape velocity accurately.

**Easy-to-Use API:**

The EscapeVelocityCalculator class provides a simple API to calculate escape velocity based on mass and radius.

**Unit Testing:**

The code includes NUnit tests to validate the correctness of the escape velocity calculation.

## How to Use

**Clone the repository to your local machine:**
```
git clone https://github.com/krisztipely/escapevelocitycalculator.git
```
Open the project in Microsoft Visual Studio or your preferred C# development environment.

Use the EscapeVelocityCalculator class in your own projects or run the provided unit tests to ensure accuracy.

## Example
```
// Calculate escape velocity for Earth
double earthMass = 5.972e24; // Earth mass in kilograms
double earthRadius = 6.371e6; // Earth radius in meters

double earthEscapeVelocity = EscapeVelocityCalculator.CalculateEscapeVelocity(earthMass, earthRadius);
Console.WriteLine($"Escape Velocity for Earth: {earthEscapeVelocity} m/s");
```

## Unit Testing
The EscapeVelocityCalculatorTests class contains unit tests using NUnit to validate the correctness of the escape velocity calculation. Run these tests to ensure the accuracy and reliability of the calculator.

## License
MIT 2023, Krisztina-Ronkainen Lakner
