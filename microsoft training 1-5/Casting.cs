
public class Casting
{
    public static void Run()
    {
        int firstValue = 2;
        string secondValue = "4";
        string result = firstValue + secondValue;
        Console.WriteLine(result);

        // int myInt = 3;
        // Console.WriteLine($"int: {myInt}");

        // decimal myDecimal = myInt;
        // Console.WriteLine($"decimal: {myDecimal}");

        decimal myDecimal = 3.14m;
        Console.WriteLine($"decimal: {myDecimal}");

        int myInt = (int)myDecimal;
        Console.WriteLine($"int: {myInt}");

        int value = (int)1.5m; // casting truncates
        Console.WriteLine(value);

        int value2 = Convert.ToInt32(1.5m); // converting rounds up
        Console.WriteLine(value2);

        Console.WriteLine("What would you like me to parse? ");
        string valueToParse = Console.ReadLine();
        int parseResult;
        if (int.TryParse(valueToParse, out parseResult))
        {
            Console.WriteLine(parseResult);
        }
        else
        {
            Console.WriteLine("That aint no number");
        }
    }
}