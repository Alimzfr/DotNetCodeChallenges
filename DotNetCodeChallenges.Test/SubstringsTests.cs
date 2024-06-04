using DotNetCodeChallenges.Services;

namespace DotNetCodeChallenges.Tests;

public class SubstringsTests
{
    [Fact]
    public void TestFindSubstringsWithoutRepeatedCharacters()
    {
        // Arrange
        var substrings = new Substrings();
        var input = "abac";

        // Act
        var result = substrings.FindSubstringsWithoutRepeatedCharacters(input).ToList();

        // Assert
        var expected = new List<string> { "a", "b", "a", "c", "ab", "ba", "ac", "bac" };
        Assert.True(!expected.Except(result).Any() && expected.Count == result.Count);
    }

    [Theory]
    [InlineData(null)]
    [InlineData(" ")]
    public void TestNullOrWhiteSpaceInputFindSubstringsWithoutRepeatedCharacters(string input)
    {
        // Arrange
        var substrings = new Substrings();

        // Act
        Action action = () => substrings.FindSubstringsWithoutRepeatedCharacters(input);

        // Assert
        var exception = Assert.Throws<ArgumentNullException>(action);
    }
}