public class Point
{
    private double x;
    private double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public void MoveX(double dx)
    {
        x += dx;
    }
    public void MoveY(double dy)
    {
        y += dy;
    }
    public double DistanceToOrigin()
    {
        return Math.Sqrt(x * x + y * y);
    }
    public static double DistanceBetween(Point p1, Point p2)
    {
        double dx = p2.x - p1.x;
        double dy = p2.y - p1.y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
    public override string ToString()
    {
        return $"({x}, {y})";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите координаты первой точки.");
            Console.Write("x = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки.");
            Console.Write("x = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y2 = double.Parse(Console.ReadLine());
            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);
            Console.WriteLine($"Точка 1: {point1}");
            Console.WriteLine($"Точка 2: {point2}");
            point1.MoveX(2);
            point1.MoveY(-1);
            Console.WriteLine($"Перемещенная точка 1: {point1}");
            Console.WriteLine($"Расстояние от первой точки до начала координат: {point1.DistanceToOrigin()}");
            Console.WriteLine($"Расстояние между точками: {Point.DistanceBetween(point1, point2)}");
        }
        catch (Exception e) { Console.WriteLine("Неверный формат числа!"); }
    }
}