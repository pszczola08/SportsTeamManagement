using TeamCreator;

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter name of your team: ");
        string? name = Console.ReadLine();

        Team Team = new(name);

        while (true) {
            Console.Write("\nWhat do you want to do? (A - Add Player, B - Add Game, C - Show statistics, D - Player scored, E - Search player by position): ");
            string? c = Console.ReadLine();
            switch (c) {
                case "A":
                    Console.Write("Enter name of the player: ");
                    string? plname = Console.ReadLine();
                    Console.Write("Enter position of the player: ");
                    string? position = Console.ReadLine();
                    Team.AddPlayer(plname, position);
                    break;
                case "B":
                    Console.Write("Enter name of the game: ");
                    string? gamename = Console.ReadLine();
                    Console.Write("Did you win? (0, 1): ");
                    string? win = Console.ReadLine();
                    bool boolWin;
                    if (win == "1") {
                        boolWin = true;
                    } else {
                        boolWin = false;
                    }
                    Team.AddGame(gamename, boolWin);
                    break;
                case "C":
                    Console.WriteLine($"Your team wins {Team.Stats()}% of times.");
                    break;
                case "D":
                    Console.Write("Who scored?: ");
                    string? pl = Console.ReadLine();
                    Team.Score(pl);
                    break;
                case "E":
                    Console.Write("Search for position: ");
                    string? pos = Console.ReadLine();
                    Team.WriteByPosition(pos);
                    break;
                default:
                    break;
            }
        }
    }
}