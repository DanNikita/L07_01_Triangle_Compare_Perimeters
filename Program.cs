using System.Diagnostics;
using System.Diagnostics.Metrics;
using static System.Reflection.Metadata.BlobBuilder;

internal class Program
{
    //public struct Sides
    //{
    //    public int Side_a;
    //    public int Side_B;
    //    public int Side_C;
    //}
    static void Main(string[] args)
    {
        Triangle Tr = new Triangle(3, 5, 7); //create class example
        Triangle Tr2 = new Triangle(4, 6, 9);
        Triangle Tr3 = new Triangle(10, 4, 2);
        Console.Write("Enter three sides, a:");
        //Tr.a = int.Parse(Console.ReadLine());
        //Console.Write("b:");
        //Tr.b = int.Parse(Console.ReadLine());
        //Console.Write("c:");
        //Tr.c = int.Parse(Console.ReadLine());
        ////Triangle.Print(Tr);
        //Triangle Tr2 = new Triangle();
        ////Tr2.SetSides(2, 4, 7);
        Console.WriteLine(Tr.ToString());
        Console.WriteLine(Tr2.ToString());
        object[] Triangles = new object[] { Tr, Tr2, Tr3 };
        Array.Sort(Triangles);
        foreach (object b in Triangles)
        {
            Triangle ini = (Triangle)b;
            int a = ini.Perimeter();
            Console.WriteLine("Triangle Perimeter = {0}", a);
        }
      Console.ReadLine();
        
    }
}
public class Triangle : IComparable
{ 
    private int a;
    private int b;
    private int c;
    static int counter = 0;
    public Triangle(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        counter++;
    }

    int IComparable.CompareTo(object obj)
    {
        Triangle otherTriangle = (Triangle)obj;
        if (this.Perimeter() == otherTriangle.Perimeter()) return 0;
        else if (this.Perimeter() > otherTriangle.Perimeter()) return 1;
        else return -1;
    }
    //public void SetSides(int side1, int side2, int side3)
    //{
    //    a = side1;
    //    b = side2;
    //    c = side3;
    //}
    public bool Check() //Checking sides
    {
        Console.WriteLine("Entering method to check sides");
        //if (side1 != 0 & side2 != 0 & side3 != 0)
        //    return true;
        //else
        //    return false;
        if (a != 0 & b != 0 & c != 0)
            return true;
        else
            return false;
    }
    public int Perimeter() //Calculating perimeter
    {
        int sum = a + b + c;
        return sum;
    }
    public double Square() //Calculating square
    {
        int per = this.Perimeter();
        double s = Math.Sqrt(per * (per - a) * (per - b) * (per - c));
        return s;
    }
    public override string ToString()
    {
        return String.Format("Triangle with sides {0},{1},{2}, Perimeter {3}", a, b, c, this.Perimeter());
    }
    //public static void Print(Triangle toWrite) //Printing all sides
    //{
    //    Console.WriteLine("Side a: {0}", toWrite.a); //What about Triangle.a???
    //    Console.WriteLine("Side b: {0}", toWrite.b);
    //    Console.WriteLine("Side b: {0}", toWrite.c);
    //    Console.WriteLine("Perimeter {0}", this.Perimeter());
    //    Console.WriteLine("Square {0:F2}", this.Square());
    //}

    ////public static Sides NewTriangle(int input1, int input2, int input3)
    ////{
    ////    return new Sides { Side_a = input1,Side_B =  input2,Side_C = input3};
    ////}
    //public int perimeter(Sides)
    //{
    //    int sum = 0;
    //    return int sum =  Sides.Side_a +
    //}

}
