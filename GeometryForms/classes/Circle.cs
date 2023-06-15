class Circle : Shape
{
    private readonly float radius;

    public float Radius { get => radius; }

    public Circle(float radius, string name = "Circle") : base(name)
    {
        this.radius = radius;
    }

    public override float CalcArea()
    {
        return (float)(radius * radius * Math.PI);
    }

    public override float CalcPerimeter()
    {
        return (float)(2 * Math.PI * radius);
    }

    public override void Print()
    {
        PrintConsole.Print(Name, 0, CalcArea(), CalcPerimeter());
    }
}
