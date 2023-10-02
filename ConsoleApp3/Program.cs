using ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the length of the first side of the rectangle:");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of the other side of the rectangle:");
        double side2 = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Area of rectangle: {rectangle.Area}");
        Console.WriteLine($"Perimeter of rectangle: {rectangle.Perimeter}");

        Console.ReadLine();

     
    }
}
    
