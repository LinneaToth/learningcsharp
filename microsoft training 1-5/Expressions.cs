public class Expressions
{
    public static void Run()
    {
        Random randomizer = new Random();
        int randomValue = randomizer.Next(0, 2);

        Console.WriteLine($"you flipped {(randomValue == 0 ? "head" : "tails")}");


        string permission = "Nobody";
        int level = 55;

        if (permission.Contains("Admin"))
        {
            Console.WriteLine($"Welcome, {(level > 55 ? "Super " : "")}Admin user.");
        }

        if (permission.Contains("Manager"))
        {
            Console.WriteLine($"{(level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges")}");
        }

        if (!permission.Contains("Manager") || !permission.Contains("Admin"))
        {
            Console.WriteLine($"You do not have sufficient privileges.");
        }

    }

}
