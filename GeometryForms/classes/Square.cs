class Square : Rectangle
{
    public Square(float side1, float side2, string name = "Square", int numberSides = 4) : base(side1, side2, name, numberSides)
    {

    }

    public override float CalcArea()
    {
        return Side1 * Side1;
    }

    public override float CalcPerimeter()
    {
        return Side1 * 4;
    }

    public override void Print()
    {
        PrintConsole.Print(Name, NumberSides, CalcArea(), CalcPerimeter());
    }
}
