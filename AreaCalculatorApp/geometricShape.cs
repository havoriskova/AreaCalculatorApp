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
        public virtual float GetResult()
        {
            return 0;
        }
    };

    public class Circle : GeometricShape
    {
        public Circle(float rnum)
        {
            R = rnum;
        }
        
        public float R { get; }
            public override float GetResult()
            {
                return (float)(Math.PI * Math.Pow(R, 2));

            }
       
    }

    public class Rectangle : GeometricShape
    {
          public Rectangle(float aNum, float bNum)
            {
                A = aNum;
                B = bNum;
            }

        public float A { get; }
        public float B { get; }
        
        public override float GetResult()
        {
            return (float)(A * B);
        }
    }


    public class Triangle : GeometricShape
    {
        public Triangle(float aNum, float vNum)
        {
            A = aNum;
            V = vNum;
        }

        public float A { get; }
        public float V { get; }

        public override float GetResult()
        {
            return (float)((V * A) / 2);
        }
    }


    public class Square : GeometricShape
    {
        public Square(float aNum)
        {
            A = aNum;
        }

        public float A { get; }

        public override float GetResult()
        {
            return (float)(A * A);
        }
    }

    public class Trapezoid : GeometricShape
    {
        public Trapezoid(float aNum, float cNum, float vNum)
        {
            A = aNum;
            C = cNum;
            V = vNum;
        }

        public float A { get; }
        public float C { get; }
        public float V { get; }

        public override float GetResult()
        {
            return (float)(((A + C) * V) / 2);
        }
    }


}
