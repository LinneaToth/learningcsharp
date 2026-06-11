public class Game()
{
    public static void Run()
    {
        Random random = new Random();




        bool ShouldPLay()
        {
            Console.WriteLine("Would you like to play? (Y/N)");
            return Console.ReadLine().Trim().ToLower() == "y";
        }

        int Roll()
        {
            return random.Next(1, 7);
        }

        string WinOrLose(int target, int roll)
        {
            return roll >= target ? "YOU WIN" : "YOU LOOOSE";
        }

        if (ShouldPLay())
        {
            PlayGame();
        }

        void PlayGame()
        {
            var play = true;

            while (play)
            {
                var target = Roll();
                var roll = Roll();

                Console.WriteLine($"Roll a number greater than or equal to {target} to win!");
                Console.WriteLine($"You rolled a {roll}");
                Console.WriteLine(WinOrLose(target, roll));
                Console.WriteLine("\nPlay again? (Y/N)");

                play = ShouldPLay();
            }
        }
    }
}