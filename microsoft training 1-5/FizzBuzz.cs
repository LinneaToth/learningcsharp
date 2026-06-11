public class FizzBuzz
{
    public static void Run()
    {
        for (int i = 1; i <= 100; i++)
        {
            bool fizz = (i % 3 == 0);
            bool buzz = (i % 5 == 0);
            Console.WriteLine($"{i} - {(fizz ? "Fizz" : "")}{(buzz ? "Buzz" : "")}");
        }
    }
}