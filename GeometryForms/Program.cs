class Program
{
    static void Main(string[] args)
    {
        Diagram diagram = new();
        diagram.GenerateRandomShapes();
        diagram.Print();

        Console.ReadKey();
    }
}