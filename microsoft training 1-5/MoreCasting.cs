
public class MoreCasting
{
    public static void Run()
    {
        string[] values = { "12,3", "45", "ABC", "11", "DEF" };
        decimal result;
        decimal total = 0;
        string message = "";

        foreach (string value in values)
        {
            if (decimal.TryParse(value, out result))
            {
                total += result;
            }
            else
            {
                message += value;
            }
        }
        Console.WriteLine($"Message: {message} \n Total: {total}");
    }
}