public abstract class Shape
{
    protected string Color { get; set; }
    public Shape()
    {

    }

    public Shape (string color)
    {
        Color = color;
    }
    //virtual method
    public virtual void display()
    {
        Console.WriteLine(Color);
    }
    //abtract methods
    public abstract double GetArea();
    public abstract double Perimetter();

}