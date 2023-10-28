string[] names = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
string separator = "\n";

PrintArray(names, separator);

static void PrintArray(string[] arr, string sep)
{
	Console.WriteLine(String.Join(sep, arr));
}