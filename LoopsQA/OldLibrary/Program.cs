string favoriteBook = Console.ReadLine();
int counter = 0;
bool isFound = false;

string nextBook = Console.ReadLine();
while (true)
{
    if (nextBook == "No More Books")
    {
        Console.WriteLine("The book you search is not here!");
        Console.WriteLine($"You checked {counter} books.");
        return;
    }
    if (nextBook == favoriteBook)
    {
        Console.WriteLine($"You checked {counter} books and found it.");
        return;
    }
    counter++;
    nextBook = Console.ReadLine();
}