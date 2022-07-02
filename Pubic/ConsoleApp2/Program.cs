using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



abstract class shape
{
    abstract public double Area(); 
    abstract public double Parameter();

}



class circle : shape
{

    public double radius { get; set; }

    static readonly double PI = 3.14;
    public override double Area()
    {
        return PI * (radius*radius);
    }

    public override double Parameter()
    {
        return 2 * PI * radius;
    }
}

class rectangel : shape
{
    public double lenght { get; set; }
    public double width { get; set; }

    public override double Area()
    {
        return lenght * width;
    }

    public override double Parameter()
    {
        return 4*(width+lenght);
    }
}


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circle circle = new circle();
            rectangel rectangel = new rectangel();

            Console.WriteLine("Enter a radius: ");
            double r = 

            circle.radius = Convert.ToDouble(Console.ReadLine());;
            Console.WriteLine("the area of the circle is " + circle.Area());
            Console.WriteLine("the circumfrance of the circle is " + circle.Parameter());

            Console.WriteLine("Enter a lenght: ");
            rectangel.lenght = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a width: ");
            rectangel.width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the area of the rectangle is " + rectangel.Area());
            Console.WriteLine("the parameter of the rectangle is " + rectangel.Parameter());
        }
    }
}
