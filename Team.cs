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
}

record Game {
    public string Title;
    public bool Win;
}