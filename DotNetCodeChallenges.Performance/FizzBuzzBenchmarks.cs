﻿using BenchmarkDotNet.Attributes;
using DotNetCodeChallenges.Services;

namespace DotNetCodeChallenges.Performance;

[MemoryDiagnoser]
public class FizzBuzzBenchmarks
{
    private const int _n = 10000;
    private readonly FizzBuzz _fizzBuzz = new();

    [Benchmark]
    public string[] DoFizzBuzz() => _fizzBuzz.DoFizzBuzz(_n);
}