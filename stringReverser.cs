using System;

public class stringReverser
{
    public static string reverseText = "Reverse";
    public static string output = "";
    
    public static void Main(string[] args)
    {
        foreach (char c in reverseText){
            output = c + output;
        }
        Console.WriteLine(output);
    }
}
