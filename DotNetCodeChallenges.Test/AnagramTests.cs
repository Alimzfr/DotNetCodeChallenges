using DotNetCodeChallenges.Services;

namespace DotNetCodeChallenges.Tests;

public class AnagramTests
{
    [Theory]
    [InlineData("silent", "listen")]
    [InlineData("Silent", "Listen")]
    [InlineData("Silent", "listen")]
    [InlineData("silent", "Listen")]
    [InlineData("same", "same")]
    [InlineData("silent word", "listen word")]
    public void TestTwoAnagramStrings(string firstString, string secondString)
    {
        // Arrange
        var anagram = new Anagram();

        // Act
        var result = anagram.AreAnagram(firstString, secondString);

        // Assert
        Assert.Equal(true, result);
    }

    [Theory]
    [InlineData("silence", "listens")]
    [InlineData("cat", "dog")]
    [InlineData("word ", "word")]
    [InlineData("silence word", "listens word")]
    public void TestTwoNotAnagramStrings(string firstString, string secondString)
    {
        // Arrange
        var anagram = new Anagram();

        // Act
        var result = anagram.AreAnagram(firstString, secondString);

        // Assert
        Assert.Equal(false, result);
    }

    [Theory]
    [InlineData(null, "word")]
    [InlineData("word", null)]
    [InlineData(null, null)]
    [InlineData(" ", "word")]
    [InlineData("word", " ")]
    [InlineData(" ", " ")]
    public void TestNullOrWhiteSpaceAnagramStrings(string firstString, string secondString)
    {
        // Arrange
        var anagram = new Anagram();

        // Act
        Action action = () => anagram.AreAnagram(firstString, secondString);

        // Assert
        var exception = Assert.Throws<ArgumentNullException>(action);
    }
}