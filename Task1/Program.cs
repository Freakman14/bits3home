System.Console.WriteLine("Width: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Height: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Color: ");
string c = Console.ReadLine();

var rec1 = new Rectangle();
rec1.Width = a;
rec1.Height = b;
rec1.Color = c;

System.Console.WriteLine("Area: " + rec1.GetArea());
System.Console.WriteLine("Perimeter: " + rec1.GetPerimeter());
System.Console.WriteLine("RectangleColor: "+rec1.GetColor());

public class Rectangle
{
    public int Width;
    public int Height;
    public string Color;

    public int GetArea()
    {
        int area = Width * Height;
        return area;
    }
    public int GetPerimeter()
    {
        int perimetr = 2 * (Width + Height);
        return perimetr;
    }
    public string GetColor()
    {
        return Color;
    }
}
