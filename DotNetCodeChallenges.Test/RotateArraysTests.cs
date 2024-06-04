using DotNetCodeChallenges.Services;

namespace DotNetCodeChallenges.Tests;

public class RotateArraysTests
{
    [Fact]
    public void TestRotateArray()
    {
        // Arrange
        var collections = new Collections();
        var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var position = 5U;

        // Act
        collections.RotateArray(array, position);

        // Assert
        var expected = new int[] { 6, 7, 8, 9, 10, 1, 2, 3, 4, 5 };
        Assert.Equal(expected, array);
    }

    [Theory]
    [InlineData(null, 0)]
    [InlineData(new int[] { }, 0)]
    [InlineData(new int[] { 1 }, 0)]
    public void TestRotateArrayByNullOrEmptyOrSingleItemArray(int[] array, uint position)
    {
        // Arrange
        var collections = new Collections();

        // Act
        Action action = () => collections.RotateArray(array, position);

        // Assert
        var exception = Assert.Throws<ArgumentNullException>(action);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 11)]
    public void TestRotateArrayByOutOfRangePosition(int[] array, uint position)
    {
        // Arrange
        var collections = new Collections();

        // Act
        Action action = () => collections.RotateArray(array, position);

        // Assert
        var exception = Assert.Throws<ArgumentOutOfRangeException>(action);
    }
}