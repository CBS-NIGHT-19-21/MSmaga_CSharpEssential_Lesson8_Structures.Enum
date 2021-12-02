static class Printer
{
    public static void Print(string str, int codeColor)
    {
        //Assignment color by code of color of Enum ConsoleColor;
        ConsoleColor color = (ConsoleColor)codeColor;

        Console.ForegroundColor = color;

        Console.WriteLine(str);

        Console.WriteLine($"Code color: {(int)Console.ForegroundColor} - {color}");
    }
}


