using BenchmarkDotNet.Attributes;
using DotNetCodeChallenges.Services;

namespace DotNetCodeChallenges.Performance;

public class AnagramBenchmarks
{
    private const string _firstString = "silent";
    private const string _secondString = "listen";
    private readonly Anagram _anagram = new();

    [Benchmark]
    public bool AreAnagram() => _anagram.AreAnagram(_firstString,_secondString);
}