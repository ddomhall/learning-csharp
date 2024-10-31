using TimCoreyCourse.ClassLibrary.Services;

namespace TimCoreyCourse.Tests
{
    public class CalculationServiceTests
    {
        [Theory]
        [InlineData(-1, -1, -2)]
        [InlineData(-0.5, -0.5, -1)]
        [InlineData(0, 0, 0)]
        [InlineData(0.5, 0.5, 1)]
        [InlineData(1, 1, 2)]
        public void AddsCorrectly(double x, double y, double expected)
        {
            double actual = CalculationService.Add(x, y); 
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1, -1, 0)]
        [InlineData(-0.5, -0.5, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(0.5, 0.5, 0)]
        [InlineData(1, 1, 0)]
        public void SubtractsCorrectly(double x, double y, double expected)
        {
            double actual = CalculationService.Subtract(x, y); 
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1, -1, 1)]
        [InlineData(-0.5, -0.5, 0.25)]
        [InlineData(0, 0, 0)]
        [InlineData(0.5, 0.5, 0.25)]
        [InlineData(1, 1, 1)]
        public void MultipliesCorrectly(double x, double y, double expected)
        {
            double actual = CalculationService.Multiply(x, y); 
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1, -1, 1)]
        [InlineData(-0.5, -0.5, 1)]
        [InlineData(0.5, 0.5, 1)]
        [InlineData(1, 1, 1)]
        public void DividesCorrectly(double x, double y, double expected)
        {
            double actual = CalculationService.Divide(x, y); 
            Assert.Equal(expected, actual);
        }
    }
}
