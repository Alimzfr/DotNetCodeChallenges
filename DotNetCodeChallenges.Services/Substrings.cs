namespace DotNetCodeChallenges.Services;

/// <summary>
/// Finding all substring without repeated characters
/// </summary>
public class Substrings
{
    public int FindSubstrings(string input)
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