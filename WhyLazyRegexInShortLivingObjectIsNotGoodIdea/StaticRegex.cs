using System.Text.RegularExpressions;

namespace WhyLazyRegexInShortLivingObjectIsNotGoodIdea;

public class StaticRegex
{
    private static Regex _regex = new Regex(@"\d+", RegexOptions.Compiled);

    public static bool IsMatch(string input)
    {
        return _regex.IsMatch(input);
    }
}