string letter = Console.ReadLine();

switch (letter.ToLower())
{
    case "a":
    case "o":
    case "u":
    case "i":
    case "e":
        Console.WriteLine("Vowel");
        break;
    default:
        Console.WriteLine("Consonant");
        break;
}