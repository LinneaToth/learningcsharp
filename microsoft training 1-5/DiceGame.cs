
public class DiceGame
{
  public static void Run()
  {

    int firstValue = 500;
    int secondValue = 600;
    int largerValue = Math.Max(firstValue, secondValue);

    Console.WriteLine(largerValue);

    Random dice = new Random();
    int roll1;
    int roll2;
    int roll3;

    int amtRounds = 0;


    bool triple = false;



    while (triple == false)
    {

      roll1 = dice.Next(1, 7);
      roll2 = dice.Next(1, 7);
      roll3 = dice.Next(1, 7);

      int total = roll1 + roll2 + roll3;
      Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

      Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


      if ((roll1 == roll2) && (roll2 == roll3))
      {
        Console.WriteLine($"You rolled triples! +6 bonus to total! It only took {amtRounds} rounds");
        total += 6;
        triple = true;
      }
      else if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
      {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
      }

      if (total > 14)
      {
        Console.WriteLine("You win!");
      }

      if (total < 15)
      {
        Console.WriteLine("Sorry, you lose.");
      }
      amtRounds++;
    }

  }
}