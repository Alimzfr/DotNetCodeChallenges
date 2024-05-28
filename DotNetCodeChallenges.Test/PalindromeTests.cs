using DotNetCodeChallenges.Services;

namespace DotNetCodeChallenges.Tests;

public class PalindromeTests
{
    [Theory]
    [InlineData("level")]
    [InlineData("madam")]
    [InlineData("12321")]
    public void TestPalindromeString(string input)
    {
        // Arrange
        var palindrome = new Palindrome();

        // Act
        var result = palindrome.IsPalindrome(input);

        // Assert
        Assert.Equal(true, result);
    }

    [Theory]
    [InlineData("word")]
    [InlineData("level ")]
    [InlineData(" madam")]
    [InlineData("12345")]
    public void TestNotPalindromeString(string input)
    {
        // Arrange
        var palindrome = new Palindrome();

        // Act
        var result = palindrome.IsPalindrome(input);

        // Assert
        Assert.Equal(false, result);
    }

    [Theory]
    [InlineData(null)]
    [InlineData(" ")]
    public void TestNullOrWhiteSpacePalindromeString(string input)
    {
        // Arrange
        var palindrome = new Palindrome();

        // Act
        Action action = () => palindrome.IsPalindrome(input);

        // Assert
        var exception = Assert.Throws<ArgumentNullException>(action);
    }
}