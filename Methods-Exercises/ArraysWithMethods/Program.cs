string[] names = Console.ReadLine().Split();
string separator = "\n";

PrintArray(names, separator);

static void PrintArray(string[] arr, string separ)
{
	Console.WriteLine(String.Join(separ, arr));
}