using PlayerCreator;

namespace TeamCreator;

class Team {
    public string Name;
    public List<Game> Games;
    public List<Player> PlayerList;

    public Team(string Name) {
        this.Name = Name;
        Games = new();
        PlayerList = new();
    }

    public void AddPlayer(string name, string position) {
        PlayerList.Add(new Player(name, position));
    }
    public void AddGame(string name, bool win) {
        Games.Add(new(name, win));
    }
    public double Stats() {
        return Games.Count > 0 ? ((double)Games.Where(game => game.Win).Count() / Games.Count) * 100 : 0;
    }
    public void Score(string name) {
        PlayerList.First(player => player.Name == name).PlayerScore();
    }
}

record Game (
    string Title,
    bool Win
);