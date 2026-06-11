
public class Pangram
{
    public static void Run()
    {

        string pangram = "The quick brown fox jumps over the lazy dog";

        string[] pangramArray = pangram.Split(" ");

        string newString = "";

        foreach (string word in pangramArray)
        {
            char[] wordArray = word.ToCharArray();
            Array.Reverse(wordArray);
            string newWord = String.Join("", wordArray);

            newString += newWord + " ";

        }

        // Array.Reverse(pangramArray);

        // string reversedString = String.Join("", pangramArray);

        Console.WriteLine(newString);
    }
}