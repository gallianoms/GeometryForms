class Diagram
{
    private float areaTotal;
    private float perimeterTotal;
    private readonly Random random;

    public float AreaTotal { get => areaTotal; set => areaTotal = value; }
    public float PerimeterTotal { get => perimeterTotal; set => perimeterTotal = value; }

    public Diagram()
    {
        areaTotal = 0;
        perimeterTotal = 0;
        random = new Random();
    }

    public void Print()
    {
        Console.WriteLine($"Area: {areaTotal}");
        Console.WriteLine($"Perimeter: {perimeterTotal}");
    }

    public int GenerateRandomNumOfShapes()
    {
        return random.Next(2, 6); // 2 to 5

    }

    public void GenerateRandomShapes()
    {
        int numOfShapes = GenerateRandomNumOfShapes();

        for (int i = 0; i < numOfShapes; i++)
        {
            int shapeCase = random.Next(1, 6); // 1 to 6
            int randomNum = random.Next(1, 101); // 1 to 100

            switch (shapeCase)
            {
                case 1:
                    Circle circle = new(randomNum);
                    areaTotal += circle.CalcArea();
                    perimeterTotal += circle.CalcPerimeter();
                    break;
                case 2:
                    Diamond diamond = new(randomNum, randomNum);
                    areaTotal += diamond.CalcArea();
                    perimeterTotal += diamond.CalcPerimeter();
                    break;
                case 3:
                    Rectangle rectangle = new(randomNum, randomNum);
                    areaTotal += rectangle.CalcArea();
                    perimeterTotal += rectangle.CalcPerimeter();
                    break;
                case 4:
                    Square square = new(randomNum, randomNum);
                    areaTotal += square.CalcArea();
                    perimeterTotal += square.CalcPerimeter();
                    break;
                case 5:
                    Triangle triangle = new(randomNum, randomNum);
                    areaTotal += triangle.CalcArea();
                    perimeterTotal += triangle.CalcPerimeter();
                    break;
                default:
                    break;
            }

        }
    }
}
