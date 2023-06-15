class Triangle : Polygon
{
    private readonly float baseLength, height;

    public float Base { get => baseLength; }
    public float Height { get => height; }

    public Triangle(float baseLength, float height, string name = "Triangle", int numberSides = 3) : base(name, numberSides)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public override float CalcArea()
    {
        return (baseLength * height) / 2;
    }

    public override float CalcPerimeter()
    {
        return baseLength + baseLength + height;
    }

    public override void Print()
    {
        PrintConsole.Print(Name, NumberSides, CalcArea(), CalcPerimeter());
    }
}
