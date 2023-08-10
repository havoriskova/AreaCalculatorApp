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
            Rnum = rnum;
        }
        
        public double Rnum { get; }
            public override double GetResult()
            {
                return Math.Round(Math.PI * Math.Pow(Rnum, 2));

            }
       
    }

    public class Rectangle : GeometricShape
    {
          public Rectangle(double aNum, double bNum)
            {
                Anum = aNum;
                Bnum = bNum;
            }

        public double Anum { get; }
        public double Bnum { get; }
        
        public override double GetResult()
        {
            return Math.Round(Anum * Bnum);
        }
    }


    public class Triangle : GeometricShape
    {
        public Triangle(double aNum, double vNum)
        {
            Anum = aNum;
            Vnum = vNum;
        }

        public double Anum { get; }
        public double Vnum { get; }

        public override double GetResult()
        {
            return Math.Round((Vnum * Anum) / 2);
        }
    }


    public class Square : GeometricShape
    {
        public Square(double aNum)
        {
            Anum = aNum;
        }

        public double Anum { get; }

        public override double GetResult()
        {
            return Math.Round(Anum * Anum);
        }
    }

    public class Trapezoid : GeometricShape
    {
        public Trapezoid(double aNum, double cNum, double vNum)
        {
            Anum = aNum;
            Cnum = cNum;
            Vnum = vNum;
        }

        public double Anum { get; }
        public double Cnum { get; }
        public double Vnum { get; }

        public override double GetResult()
        {
            return Math.Round(((Anum + Cnum) * Vnum) / 2);
        }
    }


}
