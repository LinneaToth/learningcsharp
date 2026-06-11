public class BattleGame
{

    public static void Run()
    {
        int heroHealth = 10;
        int monsterHealth = 10;


        Random attack = new Random();

        while (heroHealth > 0 && monsterHealth > 0)
        {
            Console.WriteLine($"Monster's health is {monsterHealth} ");
            int attackValue = attack.Next(1, 11);
            monsterHealth -= attackValue;
            Console.WriteLine($"After an attack of {attackValue}, monster's Health is down to {monsterHealth}");

            if (monsterHealth <= 0)
            {
                Console.WriteLine("Monster is out! Hero won!");
                break;
            }

            Console.WriteLine($"Hero's health is {heroHealth} ");
            int monsterAttackValue = attack.Next(1, 11);
            heroHealth -= monsterAttackValue;
            Console.WriteLine($"After an attack of {monsterAttackValue}, hero's Health is down to {heroHealth}");
        }
    }
}