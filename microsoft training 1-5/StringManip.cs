public class StringManip
{
    public static void Run()
    {
        string message = "Find what is (inside the parentheses)";

        int openingPosition = message.IndexOf("(") + 1;
        int closingPosition = message.IndexOf(")");

        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));


        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        string spanText = "What is the value <span>between the tags</span>?";

        int openingPositionSpan = spanText.IndexOf(openSpan);
        int closingPositionSpan = spanText.IndexOf(closeSpan);

        openingPositionSpan += openSpan.Length;
        int lengthOfSpan = closingPositionSpan - openingPositionSpan;
        Console.WriteLine(spanText.Substring(openingPositionSpan, lengthOfSpan));
    }
}