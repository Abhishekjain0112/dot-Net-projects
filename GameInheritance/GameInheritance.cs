using System;
public class Game
{
    public string Name{ get; set;}
    public int MaxNumPlayers{ get; set;}
    public override string ToString() { return "Maximum number of players for "+ Name+ " is "+ MaxNumPlayers;}
}

public class GameWithTimeLimit:Game
{
    public int TimeLimit{ get; set;}
    public override string ToString(){ return "Time Limit for "+Name+ " is "+TimeLimit+" minutes";}
}

public class Pragram
{
    public static void Main(string[] args)
    {
        Game g=new Game();
        Game g2=new Game();
        GameWithTimeLimit gl=new  GameWithTimeLimit();
        Console.WriteLine("Enter the game");
        g.Name=Console.ReadLine();
        Console.WriteLine("Enter the maximum number of players");
        g.MaxNumPlayers=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a game that has time limit");
        g2.Name=Console.ReadLine();
        Console.WriteLine("Enter the maximum number of players");
        g2.MaxNumPlayers=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the time limit in minutes");
        gl.TimeLimit=int.Parse(Console.ReadLine());
        string output1=g.ToString();
        string output2=g2.ToString();
        string output3=gl.ToString();
        Console.WriteLine(output1);
        Console.WriteLine(output2);
        Console.WriteLine(output3);
    }
}