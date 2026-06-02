namespace DemoLibrary;

public static class StringTools
{
    public static string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        return new string(input.Reverse().ToArray());
    }
}