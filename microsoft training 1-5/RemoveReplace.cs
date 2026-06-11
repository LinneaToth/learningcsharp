public class RemoveReplace
{
    public static void Run()
    {
        // string data = "12345John Smith          5000  3  ";
        // string updatedData = data.Remove(5, 20);
        // Console.WriteLine(updatedData);

        // string message = "This--is--ex-amp-le--da-ta";
        // message = message.Replace("--", " ");
        // message = message.Replace("-", "");
        // Console.WriteLine(message);

        string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>".Replace("trade", "reg");


        string marker = "<div>";
        string endMarker = "</div>";
        string quantityMarker = "<span>";
        string quantityEndMarker = "</span>";

        int position = input.IndexOf(marker) + marker.Length;
        int endPosition = input.IndexOf(endMarker);
        int substringLength = endPosition - position;

        int quantityPosition = input.IndexOf(quantityMarker) + quantityMarker.Length;
        int quantityEndPosition = input.IndexOf(quantityEndMarker);
        int quantitySubstringLength = quantityEndPosition - quantityPosition;




        // Your work here

        Console.WriteLine($"Quantity: {input.Substring(quantityPosition, quantitySubstringLength)}");
        Console.WriteLine($"Output: {input.Substring(position, substringLength)}");

    }
}