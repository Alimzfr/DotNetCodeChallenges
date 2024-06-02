using BenchmarkDotNet.Attributes;
using DotNetCodeChallenges.Services;

namespace DotNetCodeChallenges.Performance;

public class PalindromeBenchmarks
{
    private const string _input = "silent";
    private readonly Palindrome _palindrome = new();

    [Benchmark]
    public bool IsPalindrome() => _palindrome.IsPalindrome(_input);
}