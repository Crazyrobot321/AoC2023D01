namespace AoC2023D01.Tests
{
    public class NumberFinderTest
    {
        [Theory]
        [InlineData("1abc2", 12)]
        [InlineData("pqr3stu8vwx", 38)]
        [InlineData("a1b2c3d4e5f", 15)]
        [InlineData("treb7uchet", 77)]
        [InlineData("no digits here", 0)]
        [InlineData(" ", 0)]
        public void GetLineValues_ShouldReturnCorrectNumber(string input, int expected)
        {
            // Arrange
            var numberFinder = new NumberFinder();
            // Act
            var result = numberFinder.GetLineValue(input);
            // Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void SumAllLineValues_PuzzleExample_Returns142()
        {
            // Arrange
            var sut = new NumberFinder();
            var text = "1abc2\npqr3stu8vwx\na1b2c3d4e5f\ntreb7uchet";

            // Act
            var result = sut.SumAllLineValues(text);

            // Assert
            Assert.Equal(142, result);
        }
    }
}
