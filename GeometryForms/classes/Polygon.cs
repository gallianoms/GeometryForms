class Polygon : Shape
{
    private readonly int numberSides;

    public int NumberSides { get => numberSides; }

    public Polygon(string name, int sides) : base(name)
    {
        numberSides = sides;
    }

}
