namespace Minigame
{
    public class UpAndDown : Game
    {
        public override void Play()
        {
            //Header
            Console.Clear();
            Console.WriteLine("==========Up And Down==========");
            Console.WriteLine("     ===== 참여자 목록 =====     ");
            for (int i = 1; i <= CurrentPlayers; i++)
            {
                Console.WriteLine($"{i}. {Players[i-1]}");
            }
            Console.Write("Enter: 계속");
            Console.ReadLine();

            //Get Numbers
            int[] numbers = new int[2];
            for (int i = 0; i < CurrentPlayers; i++)
            {
                Console.Clear();
                Console.WriteLine($"====={Players[i]}=====");
                Console.WriteLine("무작위 숫자를 입력해주세요.");
                Console.Write("입력: ");
                string? input = Console.ReadLine();
                while (input == null)
                {
                    Console.Clear();
                    Console.WriteLine($"====={Players[i]}=====");
                    Console.WriteLine("잘못된 입력입니다. 다시 한 번 입력해주세요.");
                    Console.Write("입력: ");
                    input = Console.ReadLine();
                }
                numbers[i] = int.Parse(input);
            }

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
        }

        //Override Constructors
        public UpAndDown(int minPlayer, int maxPlayer) : base(minPlayer, maxPlayer) { }
        public UpAndDown(int minPlayer, int maxPlayer, Player[] players, bool fillWithBot = false) : base(minPlayer, maxPlayer, players, fillWithBot) { }
    }
}