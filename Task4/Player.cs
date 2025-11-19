namespace Task4;

public class Player
{
        public string playerName;
        public int level;
        public string health;

        public Player()
        {
            Console.WriteLine("Default constructor has been called!");
        }

        public Player(string name, int level, string health)
        {
            this.playerName = name;
            this.level = level;
            this.health = health;
        }
}