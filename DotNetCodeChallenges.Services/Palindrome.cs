namespace DotNetCodeChallenges.Services;

/// <summary>
/// Check if a string is palindrome
/// </summary>
public class Palindrome
{
    public bool IsPalindrome(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentNullException(nameof(input), "Input string mustn't be null or empty!");
        }

        var inputCharsArray = input.ToLower().ToCharArray();
        var reversedInputCharsArray = inputCharsArray.Reverse();
        return input == string.Concat(reversedInputCharsArray);
    }
}