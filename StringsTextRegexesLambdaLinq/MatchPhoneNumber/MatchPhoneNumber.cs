using System.Text.RegularExpressions;

string listOfNumbers = Console.ReadLine();

string pattern = @"\+\d{3}(\s?-?)\d{1}\1\d{3}\1\d{4}\b";
Regex regex = new Regex(pattern);

MatchCollection validNumbers = regex.Matches(listOfNumbers);

Console.WriteLine(String.Join(", ", validNumbers));