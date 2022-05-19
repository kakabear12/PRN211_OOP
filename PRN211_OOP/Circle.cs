public class Circle:Shape
{
    private int Radius { get; set; }
    public Circle()
    {

    }
    public Circle(int radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.Pow(Radius, 2)*Math.PI;
    }

    public override double Perimetter()
    {
        return 2 * Math.PI* Radius;
    }

    public override void display()
    {
        Console.WriteLine("da bi thay doi o lop circle");
    }
}