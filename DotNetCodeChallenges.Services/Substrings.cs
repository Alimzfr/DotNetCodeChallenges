using System.Data.SqlTypes;

namespace DotNetCodeChallenges.Services;

/// <summary>
/// Finding substrings
/// </summary>
public class Substrings
{
    /// <summary>
    /// Finding all substring without repeated characters
    /// </summary>
    public int FindSubstringsWithoutRepeatedCharacters(string input)
    {
        var length = input.Length;
        var substrings = new List<string>();
        for (var i = 0; i < length; i++)
        {
            for (var j = 1; j <= length - i; j++)
            {
                var substring = input.Substring(i, j);
                if (substring.Count() == substring.ToCharArray().Distinct().Count())
                {
                    substrings.Add(substring);
                }
            }
        }
        return substrings.Count;
    }
}