public class MethodPractice
{
    public static void DisplayRandomNumbers()
    {

        Console.WriteLine("Generating random numbers:");
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{random.Next(1, 100)} ");
        }
    }

    public static void FortuneTelling()
    {
        Random random = new Random();
        int luck = random.Next(0, 3);

        string[] fortune()
        {
            string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
            string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
            string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };
            string[] fortune = luck == 2 ? good : (luck == 0 ? bad : neutral);
            return fortune;
        }

        Console.WriteLine("A fortune teller whispers the following words:");

        string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
        string[] fortuneTold = fortune();
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"{text[i]} {fortuneTold[i]} ");
        }

    }

    public static void EmailFormat(string externalDomain = "hayworth.com")
    {
        string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

        string[,] external =
        {
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};


        string shorten(string word, int length = 3, string direction = "start")
        {
            var lengthToUse = word.Length < length ? word.Length : length;

            if (direction == "end") return word.ToLower().Substring(word.Length - lengthToUse);

            return word.ToLower().Substring(0, lengthToUse);

        }

        for (int i = 0; i < corporate.GetLength(0); i++)
        {
            Console.WriteLine($"{shorten(corporate[i, 0])}{shorten(corporate[i, 1], 4, "end")}@contoso.com");
        }

        for (int i = 0; i < external.GetLength(0); i++)
        {
            Console.WriteLine($"{shorten(external[i, 0], 3)}{shorten(external[i, 1], 5, "end")}@{externalDomain}");
        }
    }
}