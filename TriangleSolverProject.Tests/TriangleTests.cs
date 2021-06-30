using System;
using NUnit.Framework;


namespace TriangleSolverProject.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void TestNotATriangle()
        {
            // Arrange
            int firstSide = 2;
            int secondSide = 5;
            int thirdSide = 1;
            string expectedResult = "Not a Triangle";

            // Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestFor_EquilateralTriangle()
        {
            // Arrange
            int firstSide = 7;
            int secondSide = 7;
            int thirdSide = 7;
            string expectedResult = "Triangle - Equilateral";

            // Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestFor_FirstAndSecondSide_IsoscelesTriangle()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 8;
            string expectedResult = "Triangle - Isosceles";

            // Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestFor_SecondAndThirdSide_IsoscelesTriangle()
        {
            // Arrange
            int firstSide = 7;
            int secondSide = 4;
            int thirdSide = 4;
            string expectedResult = "Triangle - Isosceles";

            // Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestFor_ScaleneTriangle()
        {
            // Arrange
            int firstSide = 6;
            int secondSide = 8;
            int thirdSide = 10;
            string expectedResult = "Triangle - Scalene";

            // Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestSide_WithZeroLength()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 0;
            int thirdSide = 7;
            string expectedResult = "Not a Triangle";

            // Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestSide_WithNegativeLength()
        {
            // Arrange
            int firstSide = 8;
            int secondSide = -2;
            int thirdSide = 5;
            string expectedResult = "Not a Triangle";

            // Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestAllSides_WithNegativeLength()
        {
            // Arrange
            int firstSide = -3;
            int secondSide = -2;
            int thirdSide = -8;
            string expectedResult = "Not a Triangle";

            // Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
