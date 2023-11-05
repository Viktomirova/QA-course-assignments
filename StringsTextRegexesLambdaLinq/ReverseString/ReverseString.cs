using System.Text;

string command = Console.ReadLine();
while (command != "end")
{
    char[] word = command.ToCharArray();
    StringBuilder reversedString = new StringBuilder();
    for (int i = word.Length - 1; i >= 0; i--)
    {
        reversedString.Append(word[i]);
    }
    Console.WriteLine($"{command} = {reversedString.ToString()}");
    command = Console.ReadLine();
}