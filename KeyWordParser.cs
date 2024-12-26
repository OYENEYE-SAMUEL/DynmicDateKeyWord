using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicDayKeyword
{
    public class KeyWordParser
    {
         public static List<string> Parse(string input)
    {
        // Find all occurrences of keywords like NOW, YESTERDAY, etc.
        var keywords = new List<string>();
        var regex = new System.Text.RegularExpressions.Regex(@"\b(NOW|TODAY|YESTERDAY|NOW[+-]\d+[dhms])\b");
        foreach (System.Text.RegularExpressions.Match match in regex.Matches(input))
        {
            keywords.Add(match.Value);
        }
        return keywords;
    }
    }
}