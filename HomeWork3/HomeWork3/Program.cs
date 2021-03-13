using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{

    public interface Shape
    {
       double Area { get;}
        bool isLegal();
    }
    class Rectangle : Shape
    {
        public double Length
        {
            get;
            set;
        }
        public double Width
        {
            get;
            set;
       }
        public double Area
        {
            get { return Length * Width; }
        }

        public Rectangle(double length,double width)
        {
                Length = length;
                Width = width;
        }

        public bool isLegal()
        {
            return Length > 0 && Width > 0;
        }
    }

    class Square : Shape
    {
        public double Length
        {
            get;
            set;
        }

        public double Area 
        {
            get { return Length * Length; } 
        }

        public Square(double length)
        {
            Length = length;          
        }
        public bool isLegal()
        {
            return Length > 0;
        }
    }

    class Triangle : Shape
    {
        public double Length
        {
            get;
            set;
        }
        public double Width
        {
            get;
            set;
        }
        public double Height
        {
            get;
            set;
        }
        public double Area
        {
            get
            {
                double p = (Height + Length + Width) / 2;
                return (int)Math.Sqrt(p * (p - Length) * (p - Width) * (p - Height));
            }
        }

        public Triangle(double length, double width, double height)
        {
            Height = height;
            Length = length;
            Width = width;
        }
        public bool isLegal()
        {
            return Height + Length > Width && Height + Width > Length && Length + Width > Height &&
               Height - Length < Width && Height - Width < Length && Length - Width < Height &&
               Length > 0 && Width > 0 && Height > 0;
        }
    }

    class ShapeFactory
    {
        public static Shape makeProduct(int kind, params double[] sides)
        {
            switch(kind)
            {
                case 0:
                    if (sides.Length < 2)
                        throw new ArgumentException("参数个数应该为2");
                    return new Rectangle(sides[0],sides[1]);
                case 1:
                    if (sides.Length < 1)
                        throw new ArgumentException("参数个数应该为1");
                    return new Square(sides[0]);
                case 2:
                    if (sides.Length < 3)
                        throw new ArgumentException("参数个数应该为3");
                    return new Triangle(sides[0],sides[1],sides[2]);
            }
            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle myRe = new Rectangle(3, 5);
            Console.WriteLine($"{ myRe.Area}");
            Square mySq = new Square(7);
            Console.WriteLine($"{mySq.Area}");
            Triangle myTr = new Triangle(3, 9, 8);
            Console.WriteLine($"{myTr.Area}");

            Random rm = new Random(new Guid().GetHashCode());
            double SumArea =0;
            int kind;
            for(int i=0;i<10;i++)
            {
                kind = rm.Next() % 3;
                Shape myShape = ShapeFactory.makeProduct(kind,rm.Next(0,10),rm.Next(0,10),rm.Next(0,10));
                SumArea += myShape.Area;
            }
            Console.WriteLine($"The sun of all figure areas is {SumArea}");
        }
    }
}
