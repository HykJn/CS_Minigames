using Minigame;

namespace Program
{
    public class Program
    {
        public static List<Player> players = new();
        public static List<Game> games = new();
        public static void Main()
        {

            MainMenu();
        }

        public static void Init()
        {
            games.Add(new UpAndDown(2, 2));
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("==========Console Minigames==========");
            Console.WriteLine("     =====    Main Menu    =====     ");
            Console.WriteLine("1. 플레이어 참가");
            Console.WriteLine("2. 플레이어 목록");
            Console.WriteLine("3. 게임 플레이");
            Console.WriteLine("4. 게임 종료");

            Console.Write("번호를 입력해 주세요: ");
            bool menuFlag = true;
            while (menuFlag)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        menuFlag = false;
                        Console.WriteLine();
                        Console.Write("플레이어 이름을 입력해 주세요: ");
                        string? name = Console.ReadLine();

                        while (name == null)
                        {
                            Console.WriteLine();
                            Console.Write("잘못된 입력입니다. 다시 한 번 입력해 주세요.");
                            name = Console.ReadLine();
                        }

                        players.Add(new Player(name));
                        MainMenu();
                        break;
                    case "2":
                        menuFlag = false;
                        ShowPlayers();
                        Console.Write("Enter: 확인");
                        Console.ReadLine();
                        MainMenu();
                        break;
                    case "3":
                        menuFlag = false;
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine();
                        Console.Write("잘못된 입력입니다. 다시 한 번 입력해 주세요: ");
                        break;
                }
            }
        }

        public static Player CreatePlayer(string name) => new Player(name);

        public static void ShowPlayers()
        {
            Console.WriteLine();
            Console.WriteLine("==========플레이어 목록==========");
            for (int i = 1; i <= players.Count; i++)
            {
                Console.WriteLine($"{i}. {players[i - 1].Name}");
            }
        }

        public static void SelectGame()
        {
            Console.WriteLine();
            Console.WriteLine("==========게임 목록==========");
            for (int i = 1; i < games.Count; i++)
            {
                Console.WriteLine($"{i}. {games[i - 1]}");
            }

            bool inputFlag = true;
            while (inputFlag)
            {
                Console.Write("게임 선택: ");
                switch (Console.ReadLine())
                {

                }
            }
        }
    }

    
}