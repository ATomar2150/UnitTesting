using System;
using Triangle;
using NUnit.Framework;


namespace Triangle
{
    [TestFixture]
    public class TriangleSolverTest
    {
        [TestCase, Description("Valid equilateral triangle.")]
        public void Analyze_ifThreeSidesAreEqual_expectEquilateral()
        {
            Assert.AreEqual("Given numbers ARE sides of an EQUILATERAL Triangle.", TriangleSolver.Analyze(5, 5, 5));
        }

        [TestCase, Description("Valid isosceles triangle.")]
        public void Analyze_ifTwoSidesAreEqual_expectIsosceles()
        {
            Assert.AreEqual("Given numbers ARE sides of an ISOSCELES Triangle.", TriangleSolver.Analyze(10, 10, 15));
        }

        [TestCase, Description("Valid scalene triangle.")]
        public void Analyze_ifNoSideEqual_expectScalene()
        {
            Assert.AreEqual("Given numbers ARE sides of an SCALENE Triangle.", TriangleSolver.Analyze(5, 7, 10));
        }

        [TestCase, Description("Sum of two sides is less than third.")]
        public void Analyze_ifSumOfTwoSidesIsLessThanThird_expectInvalidTriangle()
        {
            Assert.AreEqual("Given numbers CAN NOT be sides of a Triangle.", TriangleSolver.Analyze(10, 5, 1));
        }

        [TestCase, Description("All three sides have MAX permissible length and equilateral triangle.")]
        public void Analyze_ifThreeSidesAreEqualAndHoldBoundryValues_expectEquilateral()
        {
            Assert.AreEqual("Given numbers ARE sides of an EQUILATERAL Triangle.", TriangleSolver.Analyze(2147483647, 2147483647, 2147483647));
        }

        [TestCase, Description("Two sides at maximum possible value.")]
        public void Analyze_ifTwoSidesAreEqualAndHoldBoundryValues_expectIsosceles()
        {
            Assert.AreEqual("Given numbers ARE sides of an ISOSCELES Triangle.", TriangleSolver.Analyze(2147483647, 2147483647, 15));
        }

        [TestCase, Description("Tow sides at MIN and one side at MAX.")]
        public void Analyze_ifTwoSidesHoldMinBoundryValuesThirdSideHoldMaxValue_expectInvalidTriangle()
        {
            Assert.AreEqual("Given numbers CAN NOT be sides of a Triangle.", TriangleSolver.Analyze(1, 1, 2147483647));
        }

        [TestCase, Description("Sum of two sides is equal to the thrid, produces invalid triangle.")]
        public void Analyze_ifSumOfTwoSidesIsEqualToThirdSide_expectInvalidTriangle()
        {
            Assert.AreEqual("Given numbers CAN NOT be sides of a Triangle.", TriangleSolver.Analyze(12, 7, 5));
        }
    }
}
