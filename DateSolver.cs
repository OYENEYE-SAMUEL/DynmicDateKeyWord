using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicDayKeyword
{
    public class DateSolver
    {
           public string Resolve(string keyword, System.Globalization.CultureInfo culture = null)
            {
                culture ??= System.Globalization.CultureInfo.InvariantCulture;

                DateTime now = DateTime.Now;

                return keyword switch
                {
                    "NOW" => now.ToString("yyyy-MM-dd HH:mm:ss", culture),
                    "TODAY" => now.Date.ToString("yyyy-MM-dd", culture),
                    "YESTERDAY" => now.AddDays(-1).Date.ToString("yyyy-MM-dd", culture),
                    _ => ResolveWithOffset(keyword, now, culture)
                };
            }

            private static string ResolveWithOffset(string keyword, DateTime now, System.Globalization.CultureInfo culture)
            {
                // Example implementation for offsets like NOW+2h
                if (keyword.StartsWith("NOW"))
                {
                    var match = System.Text.RegularExpressions.Regex.Match(keyword, @"NOW([+-]\d+)([dhms])");
                    if (match.Success)
                    {
                        int value = int.Parse(match.Groups[1].Value);
                        string unit = match.Groups[2].Value;

                        now = unit switch
                        {
                            "d" => now.AddDays(value),
                            "h" => now.AddHours(value),
                            "m" => now.AddMinutes(value),
                            "s" => now.AddSeconds(value),
                            _ => now
                        };
                    }
                }

                return now.ToString("yyyy-MM-dd HH:mm:ss", culture);
            }
        }

    }
