string[] input = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
Article article = new Article()
{
    Title = input[0],
    Content = input[1],
    Autor = input[2]
};
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine()
        .Split(": ", StringSplitOptions.RemoveEmptyEntries);
    switch (command[0])
    {
        case "Edit":
            article.Content = command[1];
        break;
        case "ChangeAuthor":
            article.Autor = command[1];
        break;
        case "Rename":
            article.Title = command[1];
        break;
    }
}
Console.WriteLine($"{article.Title} - {article.Content}: {article.Autor}");

class Article
{
    string title = " ";
    string content = " ";
    string autor = " ";
    public string Title { get => title; set => title = value; }
    public string Content { get => content; set => content = value; }
    public string Autor { get; set; }
    public Article()
    {
        this.Title = title;
        this.Content = content;
        this.Autor = autor;
    }
}