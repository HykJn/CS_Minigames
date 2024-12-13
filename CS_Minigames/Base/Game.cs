namespace Minigame
{
    public abstract class Game
    {
        //Properties
        public Player[] Players { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int CurrentPlayers { get; set; }

        //Methods
        public abstract void Play();

        public void FillWithBot()
        {
            if (Players.Length < MaxPlayers)
            {
                for (int i = Players.Length; i < MaxPlayers; i++)
                {
                    Players[i] = new Player("CPU_" + (i - Players.Length + 1), true);
                }
            }
        }

        public void Participate(Player player)
        {
            if (CurrentPlayers < MaxPlayers)
            {
                Players[CurrentPlayers] = player;
                CurrentPlayers++;
            }
            else
            {
                throw new Exception("플레이어가 가득 찼습니다.");
            }
        }

        //Contructors
        public Game(int minPlayers, int maxPlayers)
        {
            if (minPlayers < 1)
                throw new ArgumentException("최소 플레이어는 1명 이상이여야 합니다.", nameof(minPlayers));

            MinPlayers = minPlayers;
            MaxPlayers = maxPlayers;
            Players = new Player[maxPlayers];
            CurrentPlayers = 0;
        }

        public Game(int minPlayers, int maxPlayers, Player[] players, bool fillWithBot) : this(minPlayers, maxPlayers)
        {
            if (players == null || players.Length == 0)
                throw new ArgumentException("비어있는 플레이어입니다.", nameof(players));

            Array.Copy(players, 0, Players, 0, players.Length);

            if (fillWithBot) FillWithBot();

            CurrentPlayers = Players.Length;
        }
    }
}