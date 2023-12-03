using System.Text;

int count = int.Parse(Console.ReadLine());
List<Team> teams = new List<Team>();
List<Team> teamsToDisband = new List<Team>();
for (int i = 0; i < count; i++)
{
    string[] teamToRegister = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);

    if (teams.Any(t => t.Creator == teamToRegister[0]))
    {
        Console.WriteLine($"{teamToRegister[0]} cannot create another team!");
        continue;
    }
    if (teams.Any(t => t.Name == teamToRegister[1]))
    {
        Console.WriteLine($"Team {teamToRegister[1]} was already created!");
        continue;
    }

    Team team = new Team(teamToRegister[1], teamToRegister[0]);
    teams.Add(team);
    Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
}
while (true)
{
    string input = Console.ReadLine();
    if (input == "end of assignment")
    {
        break;
    }
    string[] userToJoin = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
    foreach (Team team in teams.Where(t => t.Name == userToJoin[1]))
    {
        if (teams.Any(t => t.Member.Contains(userToJoin[0])) || teams.Any(t => t.Creator == userToJoin[0]))
        {
            Console.WriteLine($"Member {userToJoin[0]} cannot join team {userToJoin[1]}!");
            continue;
        }
        team.Member.Add(userToJoin[0]);
    }
    if (!teams.Any(t => t.Name == userToJoin[1]))
    {
        Console.WriteLine($"Team {userToJoin[1]} does not exist!");
        continue;
    }
}
foreach (var team in teams.Where(t => t.Member.Count == 0))
{
    teamsToDisband.Add(team);
}
StringBuilder sb = new StringBuilder();
foreach (var team in teams.Where(t => t.Member.Count != 0).OrderBy(t => t.Name))
{
    sb.AppendLine(team.Name);
    sb.AppendLine($"- {team.Creator}");
    foreach (var user in team.Member)
    {
        sb.AppendLine($"-- {user}");
    }
}
sb.AppendLine("Teams to disband:");
foreach (var team in teamsToDisband.OrderBy(t => t.Name))
{
    sb.AppendLine(team.Name);
}
Console.WriteLine(sb.ToString());

class Team
{
    public string Name { get; set; }
    public string Creator { get; set; }
    public List<string> Member { get; set; }
    public Team(string name, string creator)
    {
        Name = name;
        Creator = creator;
        Member = new List<string>();
    }
}

