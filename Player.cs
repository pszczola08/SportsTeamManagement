namespace PlayerCreator;

class Player {
    public string Name;
    public string Position;
    public int Score;

    public Player(string name, string position) {
        Name = name;
        Position = position;
        Score = 0;
    }

    public void PlayerScore() {
        Score++;
    }
}