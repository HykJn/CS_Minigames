namespace Minigame
{
    public class Player
    {
        //Properties
        public string Name { get; set; }
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
                TotalScore += score;
                if (score > BestScore) BestScore = score;
            }
        }
        public int TotalScore { get; set; }
        public int BestScore { get; set; }
        public Dictionary<Game, int> PlayedGame { get; set; }
        public int TotalPlayed { get; set; }

        public bool IsBot { get; set; }

        //Private Fields
        private int score;

        //Methods
        


        //Constructors
        public Player(string name, bool isBot = false)
        {
            Name = isBot ? "CPU" : name;
            IsBot = isBot;
            Score = 0;
            TotalScore = 0;
            BestScore = 0;
            PlayedGame = new Dictionary<Game, int>();
            TotalPlayed = 0;
        }
    }
}