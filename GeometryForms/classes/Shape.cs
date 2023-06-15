class Shape
{
    private string name;

    public string Name { get => name; set => name = value; }

    public Shape(string name)
    {
        this.name = name;
    }

    public virtual float CalcArea() { return 0; }
    public virtual float CalcPerimeter() { return 0; }

    public virtual void Print()
    {
        PrintConsole.Print(Name, 0, CalcArea(), CalcPerimeter());
    }

}