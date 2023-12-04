﻿namespace Players;

public class Hero
{
    public Hero(string username, int level)
    {
        Username = username;
        Level = level;
    }

    public string Username { get; }
    public int Level { get; }

    public override string ToString()
    {
        return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
    }

}
