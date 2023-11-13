using System.Text.RegularExpressions;

string listOfNames = Console.ReadLine();

string pattern = @"\b[A-Z][a-z]+ \b[A-Z][a-z]+";
Regex regex = new Regex(pattern);

MatchCollection validNames = regex.Matches(listOfNames);

foreach (Match name in validNames)
{
    Console.Write($"{name.Value} ");
}

Console.WriteLine();