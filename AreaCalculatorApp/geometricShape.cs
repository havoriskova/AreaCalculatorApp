using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorApp
{
    public abstract class GeometricShape
    {
        public virtual double GetResult()
        {
            return 0;
        }
    };

    public class Circle : GeometricShape
    {
        public Circle(double rnum)
        {
            R = rnum;
        }
        
        public double R { get; }
            public override double GetResult()
            {
                return (double)(Math.PI * R * R);

            }
       
    }

    public class Rectangle : GeometricShape
    {
          public Rectangle(double aNum, double bNum)
            {
                A = aNum;
                B = bNum;
            }

        public double A { get; }
        public double B { get; }
        
        public override double GetResult()
        {
            return (A * B);
        }
    }


    public class Triangle : GeometricShape
    {
        public Triangle(double aNum, double vNum)
        {
            A = aNum;
            V = vNum;
        }

        public double A { get; }
        public double V { get; }

        public override double GetResult()
        {
            return (V * A / 2);
        }
    }


    public class Square : GeometricShape
    {
        public Square(double aNum)
        {
            A = aNum;
        }

        public double A { get; }

        public override double GetResult()
        {
            return (A * A);
        }
    }

    public class Trapezoid : GeometricShape
    {
        public Trapezoid(double aNum, double cNum, double vNum)
        {
            A = aNum;
            C = cNum;
            V = vNum;
        }

        public double A { get; }
        public double C { get; }
        public double V { get; }

        public override double GetResult()
        {
            return (((A + C) * V) / 2);
        }
    }


}
