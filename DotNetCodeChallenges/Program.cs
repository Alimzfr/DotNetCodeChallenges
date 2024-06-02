using BenchmarkDotNet.Running;
using DotNetCodeChallenges.Performance;

BenchmarkSwitcher.FromAssembly(typeof(AnagramBenchmarks).Assembly).Run(args);