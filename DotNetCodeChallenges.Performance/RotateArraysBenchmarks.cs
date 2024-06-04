using BenchmarkDotNet.Attributes;
using DotNetCodeChallenges.Services;

namespace DotNetCodeChallenges.Performance;

[MemoryDiagnoser]
public class RotateArraysBenchmarks
{
    private static readonly int[] _array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
    private const uint _position = 10;
    private readonly Collections _collections = new();

    [Benchmark]
    public void RotateArray() => _collections.RotateArray(_array, _position);
}