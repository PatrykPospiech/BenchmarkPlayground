using BenchmarkDotNet.Attributes;

namespace WhyLazyRegexInShortLivingObjectIsNotGoodIdea;

public class Benchmarks
{
    [Benchmark()]
    public bool IsLazyRegex()
    {
        return new LazyRegex().IsMatch("test");
    }

    
    [Benchmark()]
    public bool IsLazyRegexTwoCalls()
    {
        var regex = new LazyRegex();
        regex.IsMatch("test");
        return regex.IsMatch("test");
    }
    
    [Benchmark()]
    public bool IsStaticLazyRegex()
    {
        return StaticLazyRegex.IsMatch("test");
    }
    
    [Benchmark()]
    public bool IsStaticRegex()
    {
        return StaticRegex.IsMatch("test");
    }
}