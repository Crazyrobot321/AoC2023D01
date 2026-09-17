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
        public void GetLineValue_ReturnsExpectedValue(string input, int expected)
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
        [Fact]
        public void SumAllLineValues_WhitespaceOnlyInput_ReturnsZero()
        {
            // Arrange
            var sut = new NumberFinder();
            // Act
            var result = sut.SumAllLineValues(" ");
            // Assert
            Assert.Equal(0, result);
        }
        [Theory]
        [InlineData("two1nine", 29)]
        [InlineData("eightwothree", 83)]
        [InlineData("abcone2threexyz", 13)]
        [InlineData("xtwone3four", 24)]
        [InlineData("4nineeightseven2", 42)]
        [InlineData("zoneight234", 14)]
        [InlineData("7pqrstsixteen", 76)]
        public void GetLineValueWithWords_ReturnsExpectedValue(string line, int expected)
        {
            // Arrange
            var sut = new NumberFinder();
            // Act
            var result = sut.GetLineValueWithWords(line);
            // Assert
            Assert.Equal(expected, result);
        }
    }
}