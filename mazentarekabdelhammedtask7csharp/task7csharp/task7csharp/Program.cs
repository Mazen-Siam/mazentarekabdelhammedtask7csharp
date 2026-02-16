using System;

namespace task7csharp
{


    #region Problem3
    //public class Parent
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }

    //    public Parent(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //        Console.WriteLine($"Parent constructor called: X={X}, Y={Y}");
    //    }
    //}

    //public class Child : Parent
    //{
    //    public int Z { get; set; }

    //    public Child(int x, int y, int z) : base(x, y)
    //    {
    //        Z = z;
    //        Console.WriteLine($"Child constructor called: Z={Z}");
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Child c = new Child(10, 20, 30);
    //        Console.WriteLine($"Final values: X={c.X}, Y={c.Y}, Z={c.Z}");
    //    }
    //} 
    #endregion


    #region Problem4
    //public class Parent
    //{
    //    public virtual int Product(int x, int y)
    //    {
    //        return x * y;
    //    }
    //}

    //public class Child : Parent
    //{

    //    public new int Product(int x, int y)
    //    {
    //        return (x * y) + 10;
    //    }


    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Parent p = new Parent();
    //        Child c = new Child();
    //        Parent pc = new Child();

    //        Console.WriteLine("Parent reference, Parent object: " + p.Product(2, 3));
    //        Console.WriteLine("Child reference, Child object: " + c.Product(2, 3));
    //        Console.WriteLine("Parent reference, Child object: " + pc.Product(2, 3));
    //    }
    //} 
    #endregion



    #region Problem5
    //public class Parent
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }

    //    public Parent(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public override string ToString()
    //    {
    //        return $"({X}, {Y})";
    //    }
    //}

    //public class Child : Parent
    //{
    //    public int Z { get; set; }

    //    public Child(int x, int y, int z) : base(x, y)
    //    {
    //        Z = z;
    //    }

    //    public override string ToString()
    //    {
    //        return $"({X}, {Y}, {Z})";
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Parent p = new Parent(10, 20);
    //        Child c = new Child(10, 20, 30);

    //        Parent pc = new Child(5, 6, 7);

    //        Console.WriteLine("Parent instance: " + p);
    //        Console.WriteLine("Child instance: " + c);
    //        Console.WriteLine("Parent reference to Child instance: " + pc);
    //    }
    //} 
    #endregion



    #region Problem6
    //public interface IShape
    //{
    //    double Area { get; }   
    //    void Draw();          
    //}

    //public class Rectangle : IShape
    //{
    //    public double Width { get; set; }
    //    public double Height { get; set; }

    //    public Rectangle(double width, double height)
    //    {
    //        Width = width;
    //        Height = height;
    //    }

    //    public double Area
    //    {
    //        get { return Width * Height; }
    //    }

    //    public void Draw()
    //    {
    //        Console.WriteLine($"Drawing a rectangle of width {Width} and height {Height}");
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        IShape rect = new Rectangle(5, 10);
    //        rect.Draw();
    //        Console.WriteLine("Area: " + rect.Area);
    //    }
    //} 
    #endregion



    #region Problem7
    //public interface IShape
    //{
    //    double Area { get; }

    //    void Draw();

    //    void PrintDetails()
    //    {
    //        Console.WriteLine($"Shape details: Area = {Area}");
    //    }
    //}

    //public class Circle : IShape
    //{
    //    public double Radius { get; set; }

    //    public Circle(double radius)
    //    {
    //        Radius = radius;
    //    }

    //    public double Area => Math.PI * Radius * Radius;

    //    public void Draw()
    //    {
    //        Console.WriteLine($"Drawing a circle with radius {Radius}");
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        IShape circle = new Circle(5);
    //        circle.Draw();
    //        circle.PrintDetails();
    //    }
    //} 
    #endregion


    #region Problem8
    //public interface IMovable
    //{
    //    void Move();
    //}

    //public class Car : IMovable
    //{
    //    public void Move()
    //    {
    //        Console.WriteLine("The car is moving forward.");
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        IMovable vehicle = new Car();
    //        vehicle.Move();
    //    }
    //} 
    #endregion


    #region Problem9
    //public interface IReadable
    //{
    //    void Read();
    //}

    //public interface IWritable
    //{
    //    void Write();
    //}

    //public class File : IReadable, IWritable
    //{
    //    public void Read()
    //    {
    //        Console.WriteLine("Reading data from the file...");
    //    }

    //    public void Write()
    //    {
    //        Console.WriteLine("Writing data to the file...");
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        File myFile = new File();
    //        myFile.Read();
    //        myFile.Write();
    //    }
    //} 
    #endregion


    #region Problem10
    //public abstract class Shape
    //{
    //    public virtual void Draw()
    //    {
    //        Console.WriteLine("Drawing Shape");
    //    }

    //    public abstract double CalculateArea();
    //}

    //public class Rectangle : Shape
    //{
    //    public double Width { get; set; }
    //    public double Height { get; set; }

    //    public Rectangle(double width, double height)
    //    {
    //        Width = width;
    //        Height = height;
    //    }

    //    public override void Draw()
    //    {
    //        Console.WriteLine("Drawing Rectangle");
    //    }

    //    public override double CalculateArea()
    //    {
    //        return Width * Height;
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Rectangle rect = new Rectangle(10, 5);

    //        rect.Draw();
    //        Console.WriteLine("Area: " + rect.CalculateArea());
    //    }
    //} 
    #endregion

}
