class Diamond : Polygon
{
    private readonly float baseLength1, baseLength2;

    public float BaseLength1 { get => baseLength1; }
    public float BaseLength2 { get => baseLength2; }

    public Diamond(float baseLength1, float baseLength2, string name = "Diamond", int numberSides = 5) : base(name, numberSides)
    {
        this.baseLength1 = baseLength1;
        this.baseLength2 = baseLength2;
    }

    public override float CalcArea()
    {
        return baseLength1 * baseLength2 / 2;
    }

    public override float CalcPerimeter()
    {
        return baseLength1 + baseLength2;
    }

    public override void Print()
    {
        PrintConsole.Print(Name, NumberSides, CalcArea(), CalcPerimeter());
    }
}
