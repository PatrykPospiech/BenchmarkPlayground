using System.Text.RegularExpressions;

namespace WhyLazyRegexInShortLivingObjectIsNotGoodIdea;

public class StaticLazyRegex
{
    private static Lazy<Regex> _regex = new Lazy<Regex>(() => new Regex(@"\d+"));

    public static bool IsMatch(string input)
    {
        return _regex.Value.IsMatch(input);
    }
}