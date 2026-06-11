public class DoWhile
{

    public static void Run()
    {
        int? readResult;

        do
        {
            Console.WriteLine("Enter an integer between 5 and 10:");
            readResult = Int32.Parse(Console.ReadLine());
        } while (!(readResult >= 5 && readResult <= 10));
    }
}