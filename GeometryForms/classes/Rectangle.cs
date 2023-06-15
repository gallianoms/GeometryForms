class Rectangle : Polygon
{
    private readonly float side1, side2;

    public float Side1 { get => side1; }
    public float Side2 { get => side2; }

    public Rectangle(float side1, float side2, string name = "Rectangle", int numberSides = 4) : base(name, numberSides)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public override float CalcArea()
    {
        return side1 * side2;
    }

    public override float CalcPerimeter()
    {
        return 2 * (side1 + side2);
    }

    public override void Print()
    {
        PrintConsole.Print(Name, NumberSides, CalcArea(), CalcPerimeter());
    }
}
