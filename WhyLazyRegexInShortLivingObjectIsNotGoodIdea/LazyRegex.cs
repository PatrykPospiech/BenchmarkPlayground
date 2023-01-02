using System.Text.RegularExpressions;

namespace WhyLazyRegexInShortLivingObjectIsNotGoodIdea;

public class LazyRegex
{
    private Lazy<Regex> _regex = new Lazy<Regex>(() => new Regex(@"\d+"));

    public bool IsMatch(string input)
    {
        return _regex.Value.IsMatch(input);
    }
}