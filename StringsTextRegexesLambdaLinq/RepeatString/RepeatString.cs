using System.Text;

string[] strings  = Console.ReadLine().Split();

StringBuilder sb = new StringBuilder();
for (int i = 0; i < strings.Length; i++)
{
    for (int j = 0; j < strings[i].Length; j++)
    {
        sb.Append(strings[i]);
    }
}

Console.WriteLine(sb.ToString());