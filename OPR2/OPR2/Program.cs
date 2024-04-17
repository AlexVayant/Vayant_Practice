using System;
abstract class Figure
{
    public abstract double Area(); 
}
class Quadrilateral : Figure
{
    protected double side1;
    protected double side2;
    protected double side3;
    protected double side4;
    public Quadrilateral(double s1, double s2, double s3, double s4)
    {
        side1 = s1;
        side2 = s2;
        side3 = s3;
        side4 = s4;
    }
    public override double Area()
    {
        throw new NotImplementedException();
    }
}

abstract class Triangle : Figure
{
    protected double side1;
    protected double side2;
    protected double side3;

    public Triangle(double s1, double s2, double s3)
    {
        side1 = s1;
        side2 = s2;
        side3 = s3;
    }
}
class Square : Quadrilateral
{
    public Square(double side) : base(side, side, side, side) { }

    public override double Area()
    {
        return side1 * side1;
    }
}
class EquilateralTriangle : Triangle
{
    public EquilateralTriangle(double side) : base(side, side, side) { }
    public override double Area()
    {
        return (Math.Sqrt(3) / 4) * side1 * side1;
    }
}
class RightTriangle : Triangle
{
    public RightTriangle(double s1, double s2, double s3) : base(s1, s2, s3) { }
    public override double Area()
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }
}
class IsoscelesTriangle : Triangle
{
    public IsoscelesTriangle(double baseSide, double equalSide) : base(baseSide, equalSide, equalSide) { }
    public override double Area()
    {
        return 0.5 * side2 * Math.Sqrt(side1 * side1 - 0.25 * side2 * side2);
    }
}
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Введите сторону квадрата: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону равностороннего треугольника: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите 1ую сторону правильного треугольника: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Введите 2ую сторону правильного треугольника: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Введите 3ю сторону правильного треугольника: ");
            int e = int.Parse(Console.ReadLine());
            Console.Write("Введите равную сторону равнобедренного треугольника: ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("Введите основание равнобедренного треугольника: ");
            int g = int.Parse(Console.ReadLine());
            Figure[] shapes = new Figure[5];
            shapes[0] = new Square(a);
            shapes[1] = new EquilateralTriangle(b);
            shapes[2] = new RightTriangle(c, d, e);
            shapes[3] = new IsoscelesTriangle(f, g);
            Console.WriteLine($"Площадь квадрата равна {shapes[0].Area()}");
            Console.WriteLine($"Площадь равностороннего треугольника равна {shapes[1].Area()}");
            Console.WriteLine($"Площадь правильного треугольника равна {shapes[2].Area()}");
            Console.WriteLine($"Площадь равнобедренного треугольника равна {shapes[3].Area()}");
        }
        catch (Exception ex) { Console.WriteLine("Неверный формат данных");};
        }
}