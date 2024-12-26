The Dynamic Date-Keyword Parser is a lightweight .NET library designed to parse and resolve date-related keywords in file names or strings dynamically. 
It simplifies handling file names with embedded date logic for use cases like fetching files from FTP servers, generating dynamic file paths, and supporting localization.

Features
Keyword Parsing: Supports predefined and custom keywords like NOW, TODAY, YESTERDAY, and relative offsets (NOW-1d, NOW+2h).
Localization: Resolves dates using specified cultures (en-US, fr-FR, etc.).
Flexible Offsets: Handles time units like days, hours, minutes, and seconds.
Custom Formatting: Allows developers to specify date formats (yyyy-MM-dd, HH:mm:ss, etc.).


Dynamic Date-Keyword Parser NuGet Package
Overview
The Dynamic Date-Keyword Parser is a lightweight .NET library designed to parse and resolve date-related keywords in file names or strings dynamically. It simplifies handling file names with embedded date logic for use cases like fetching files from FTP servers, generating dynamic file paths, and supporting localization.

Features
Keyword Parsing: Supports predefined and custom keywords like NOW, TODAY, YESTERDAY, and relative offsets (NOW-1d, NOW+2h).
Localization: Resolves dates using specified cultures (en-US, fr-FR, etc.).
Flexible Offsets: Handles time units like days, hours, minutes, and seconds.
Custom Formatting: Allows developers to specify date formats (yyyy-MM-dd, HH:mm:ss, etc.).

Installation
Add the package to your project via the NuGet Package Manager or the .NET CLI:

bash
Copy code
dotnet add package DynamicDateKeywordParser  
Quick Start
Example Code
csharp
Copy code
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        var parser = new DynamicDateKeywordParser();
        string resolvedName = parser.ResolveFileName("File_YESTERDAY-2h.csv", new CultureInfo("en-US"));
        Console.WriteLine(resolvedName); // Output: File_2024-12-24.csv (example)
    }
}
Core Classes
DynamicDateKeywordParser

Method: ResolveFileName(string input, CultureInfo culture = null)
Resolves keywords in the input string to actual date values.
KeywordParser

Method: Parse(string input)
Extracts keywords like NOW, YESTERDAY, or NOW+2h from the input string.
DateResolver

Method: Resolve(string keyword, CultureInfo culture = null)
Converts keywords and relative offsets into date-time strings.
Supported Keywords
Static Keywords:

NOW: Current date and time.
TODAY: Start of the current day.
YESTERDAY: Start of the previous day.
Dynamic Keywords:

NOW-1d: 1 day before the current time.
NOW+2h: 2 hours after the current time.
Customization
Culture/Locale
Pass a CultureInfo object to format dates based on specific localization needs:

csharp
Copy code
var resolvedName = parser.ResolveFileName("Report_NOW.csv", new CultureInfo("fr-FR"));
Extendable Patterns
You can modify or extend parsing logic by customizing KeywordParser and DateResolver.

Dependencies
.NET Framework: Supports .NET Standard 2.0+ for wide compatibility.
System.Globalization: Handles localization and formatting.
System.Text.RegularExpressions: Used for keyword extraction.
Contribution
Feel free to submit pull requests or raise issues on the GitHub repository to contribute to the project.



