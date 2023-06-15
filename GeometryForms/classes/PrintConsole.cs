class PrintConsole
{
    public static void Print(string name, int numberSides, float area, float perimeter)
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Number of sides: {numberSides}");
        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Perimeter: {perimeter}");
    }
}

