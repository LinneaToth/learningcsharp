
public class ArrayFun
{
    public static void Run()
    {

        string[] pallets = ["B14", "A11", "B12", "A13"];

        Console.WriteLine("Sorted...");
        Array.Sort(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"{pallet}");
        }

        Console.WriteLine("Reversed...");
        Array.Reverse(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"{pallet}");
        }
        Console.WriteLine($"Before: {pallets[0]}");
        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        Console.WriteLine($"After: {pallets[0]}");
        if (pallets[0] != null)
            Console.WriteLine($"After: {pallets[0].ToLower()}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("Lets expand this! +10!");
        Array.Resize(ref pallets, pallets.Length + 10);

        Console.WriteLine("We can shrink stuff!");
        Array.Resize(ref pallets, 4);

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        string sentence = "abcde";
        char[] sentenceArray = sentence.ToCharArray();
        Array.Reverse(sentenceArray);
        string reversedSentence = new string(sentenceArray);
        Console.WriteLine(reversedSentence);
        string commaSeparated = String.Join(", ", sentenceArray);
        Console.WriteLine(commaSeparated);

    }
}