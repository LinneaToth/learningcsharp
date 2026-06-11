public class Grades
{
    public static void Run()
    {

        int currentAssignments = 5;

        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
        int[] nicolasScores = new int[] { 92, 89, 81, 96, 90 };
        int[] zahirahScores = new int[] { 90, 85, 87, 98, 68 };
        int[] jeongScores = new int[] { 90, 95, 87, 88, 96 };

        // int sophia1 = 93;
        // int sophia2 = 87;
        // int sophia3 = 98;
        // int sophia4 = 95;
        // int sophia5 = 100;

        // int nicolas1 = 80;
        // int nicolas2 = 83;
        // int nicolas3 = 82;
        // int nicolas4 = 88;
        // int nicolas5 = 85;

        // int zahirah1 = 84;
        // int zahirah2 = 96;
        // int zahirah3 = 73;
        // int zahirah4 = 85;
        // int zahirah5 = 79;

        // int jeong1 = 90;
        // int jeong2 = 92;
        // int jeong3 = 98;
        // int jeong4 = 100;
        // int jeong5 = 97;

        int sophiaSum = 0;
        int nicolasSum = 0;
        int zahirahSum = 0;
        int jeongSum = 0;

        foreach (int score in sophiaScores) sophiaSum += score;
        foreach (int score in nicolasScores) nicolasSum += score;
        foreach (int score in zahirahScores) zahirahSum += score;
        foreach (int score in jeongScores) jeongSum += score;

        decimal sophiaScore = (decimal)sophiaSum / (decimal)currentAssignments;
        decimal nicholasScore = (decimal)nicolasSum / (decimal)currentAssignments;
        decimal zahirahScore = (decimal)zahirahSum / (decimal)currentAssignments;
        decimal jeongScore = (decimal)jeongSum / (decimal)currentAssignments;



        string getGrade(decimal score) => score switch
        {
            > 96 => "A+",
            > 92 => "A",
            > 89 => "A-",
            > 86 => "B+",
            _ => "B"
        };

        Console.WriteLine("Student\t\t\tGrade\n");
        Console.WriteLine("Sophia: \t\t" + sophiaScore + ", Grade " + getGrade(sophiaScore));
        Console.WriteLine("Nicolas: \t\t" + nicholasScore + ", Grade " + getGrade(nicholasScore));
        Console.WriteLine("Zahirah: \t\t" + zahirahScore + ", Grade " + getGrade(zahirahScore));
        Console.WriteLine("Jeong: \t\t\t" + jeongScore + ", Grade " + getGrade(jeongScore));

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();

    }
}