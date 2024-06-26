﻿using DotNetCodeChallenges.Services;

namespace DotNetCodeChallenges.Tests;

public class FizzBuzzTests
{
    [Theory]
    [InlineData(15)]
    public void TestDoFizzBuzz(uint input)
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();

        // Act
        var result = fizzBuzz.DoFizzBuzz(input);

        // Assert
        var expected = new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0)]
    public void TestDoFizzBuzzByZeroInput(uint input)
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();

        // Act
        var result = fizzBuzz.DoFizzBuzz(input);

        // Assert
        var expected = new string[] { };
        Assert.Equal(expected, result);
    }
}