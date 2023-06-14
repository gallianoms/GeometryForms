class Program
{
    static void Main(string[] args)
    {
        Circle circle = new(5);
        circle.Print();

        Console.ReadKey();
    }

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

    class Polygon : Shape
    {
        private readonly int numberSides;

        public int NumberSides { get => numberSides; }

        public Polygon(string name, int sides) : base(name)
        {
            numberSides = sides;
        }

    }

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
}