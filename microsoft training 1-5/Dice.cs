
public class Dice
{
  public static void Run()
  {

    Random dice = new Random();
    Console.WriteLine(dice.Next(1, 7));


    Random dice2 = new Random();
    int roll1 = dice2.Next();
    int roll2 = dice2.Next(101);
    int roll3 = dice2.Next(50, 101);

    Console.WriteLine($"First roll: {roll1}");
    Console.WriteLine($"Second roll: {roll2}");
    Console.WriteLine($"Third roll: {roll3}");

    dice.Next();

  }
}