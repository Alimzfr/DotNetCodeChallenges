using BenchmarkDotNet.Attributes;
using DotNetCodeChallenges.Services;

namespace DotNetCodeChallenges.Performance;

[MemoryDiagnoser]
public class SubstringsBenchmarks
{
    private const string Input = "Lorem ipsum is placeholder text commonly used in the graphic, print, and publishing industries for previewing layouts and visual mockups.";
    private readonly Substrings _substrings = new();

    [Benchmark]
    public int FindSubstringsWithoutRepeatedCharacters() => _substrings.FindSubstringsWithoutRepeatedCharacters(Input);
}