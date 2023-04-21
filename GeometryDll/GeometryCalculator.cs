using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryDll
{

    public class GeometryCalculator
    {

        public static double CircleArea(double radius)
        {
            if (radius <= 0) { throw new ArgumentException("Circle radius cannot be less or equal than 0"); }
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double TriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0) { throw new ArgumentException("Triangle side cannot be less or equal than 0"); }
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public static double IDontKnowWhatIsIt(double[] args)
        {
            if (args == null) { throw new ArgumentNullException("Array Empty"); }
            if (args.Length == 1) { return CircleArea(args[0]); }
            else if (args.Length == 3) { return TriangleArea(args[0], args[1], args[2]); }
            else { throw new ArgumentException("Unknown figure"); }
        }

        public static bool RightTriangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0) { throw new ArgumentException("Triangle side cannot be less or equal than 0"); }
            if (Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2)) { return true; }
            else return false;
        }
    }
}
