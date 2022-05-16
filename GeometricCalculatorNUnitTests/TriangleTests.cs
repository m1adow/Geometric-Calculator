using Geometric_Calculator.Models.Triangles;

namespace GeometricCalculatorNUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDefaultTriangleWithSinFormula()
        {
            double firstSide = 5;
            double secondSide = 4;

            double thirdAngle = 30;

            Triangle triangle = new(firstSide, secondSide, 0, 0, 0, 0, 0, 0, thirdAngle);

            //0.5 * 5 * 4 * sin(30)
            Assert.AreEqual(0.5 * 5 * 4 * Math.Sin(30 * Math.PI / 180), triangle.GetArea());
        }

        [Test]
        public void TestDefaultTriangleWithGeronFormula()
        {
            double firstSide = 5;
            double secondSide = 6;
            double thirdSide = 9;

            Triangle triangle = new(firstSide, secondSide, thirdSide, 0, 0, 0, 0, 0, 0);

            //(9 + 5 + 6) / 2 = 10
            //sqrt(10(10-9)(10-5)(10-6))
            Assert.That(triangle.GetArea(), Is.EqualTo(Math.Sqrt(10 * (10 - 9) * (10 - 5) * (10 - 6))));
        }

        [Test]
        public void TestDefaultTriangleWithHeightFormula()
        {
            double firstSide = 5;
            double firstHeight = 10;

            Triangle triangle = new(firstSide, 0, 0, firstHeight, 0, 0, 0, 0, 0);

            //0.5 * 5 * 10
            Assert.That(triangle.GetArea(), Is.EqualTo(0.5 * 5 * 10));
        }
    }
}