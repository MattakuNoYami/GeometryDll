using GeometryDll;
namespace GeometryDll.Test
{
    public class UnitTests
    {
        [Fact]
        public void CircleAreaTest_20()
        {
            Assert.Equal(1256.637061, GeometryCalculator.CircleArea(20), 0.01);
        }
        [Fact]
        public void TriangleAreaTest_7_15_9()
        {
            Assert.Equal(20.692692, GeometryCalculator.TriangleArea(7, 15, 9), 0.01);
        }

        [Fact]
        public void IDontKnowWhatIsIt_Circle()
        {
            Assert.Equal(1256.637061, GeometryCalculator.IDontKnowWhatIsIt(new double[] { 20 }), 0.01);
        }
        [Fact]
        public void IDontKnowWhatIsIt_Triangle()
        {
            Assert.Equal(20.692692, GeometryCalculator.IDontKnowWhatIsIt(new double[] { 7, 15, 9 }), 0.01);
        }
        [Fact]
        public void RightTriangle()
        {
            Assert.True(GeometryCalculator.RightTriangle(3, 4, 5) == true);
        }
    }
}