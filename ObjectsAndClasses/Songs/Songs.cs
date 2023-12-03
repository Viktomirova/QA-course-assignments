using System.ComponentModel.Design;

int n = int.Parse(Console.ReadLine());
if (n < 1)
{
    return;
}
List<Song> listOfSongs = new List<Song>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split("_");
    string typeList = input[0];
    string name = input[1];
    string time = input[2];
    listOfSongs.Add(new Song() { TypeList = typeList, Name = name, Time = time });
}
string command = Console.ReadLine();

if (command == "all")
{
    foreach (Song song in listOfSongs)
    {
        Console.WriteLine(song.Name);
    }
}
else
{
    foreach (Song song in listOfSongs.Where(s => s.TypeList == command))
    {
        Console.WriteLine(song.Name);
    }
}

class Song
{
    private string typeList = "";
    private string name = "";
    private string time = "";
    public Song()
    {
        TypeList = typeList;
        Name = name;
        Time = time;
    }
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}