namespace DotNetCodeChallenges.Services;

/// <summary>
/// Check if two strings are anagram
/// </summary>
public class Anagram
{
    public bool AreAnagram(string firstString, string secondString)
    {
        if (string.IsNullOrWhiteSpace(firstString) || string.IsNullOrWhiteSpace(secondString))
        {
            throw new ArgumentNullException($"{nameof(firstString)} , {nameof(secondString)}", "Input strings mustn't be null or empty!");
        }

        if (firstString.Length != secondString.Length)
        {
            return false;
        }

        var firstCharsArray = firstString.ToLower().ToCharArray();
        var secondCharsArray = secondString.ToLower().ToCharArray();

        Array.Sort(firstCharsArray);
        Array.Sort(secondCharsArray);

        return string.Concat(firstCharsArray) == string.Concat(secondCharsArray);
    }
}