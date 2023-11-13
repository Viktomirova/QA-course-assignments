using System.Text.RegularExpressions;

string listOfDates = Console.ReadLine();

string pattern = @"\b(?<Day>\d{2})(\.?\/?-?)(?<Month>[A-Z][a-z]{2})\1(?<Year>\d{4})\b";

MatchCollection validDates = Regex.Matches(listOfDates, pattern);

foreach (Match match in validDates)
{
    Console.WriteLine($"Day: {match.Groups["Day"].Value}, " +
                      $"Month: {match.Groups["Month"].Value}, " +
                      $"Year: {match.Groups["Year"].Value}");
}




//using System.Text.RegularExpressions;

//var inputText = Console.ReadLine();

//var pattern = @"\b(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
//var matches = Regex.Matches(inputText, pattern);

//foreach (Match match in matches)
//{
//    Console.WriteLine($"Day: {match.Groups["day"].Value}, " +
//                      $"Month: {match.Groups["month"].Value}, " +
//                      $"Year: {match.Groups["year"].Value}");
//}