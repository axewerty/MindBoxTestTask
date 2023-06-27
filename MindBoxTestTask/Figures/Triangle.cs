using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestTask.Figures
{
    public class Triangle : Figure
    {
        private readonly UInt16 sidesCount = 3;
        private double[]? Sides = null;
        public Triangle(double[] sides) : base(sides)
        {
            if (sides.Length != sidesCount)
            {
                throw new Exception($"Triangle must have three sides. {sides.Length} sides resceived.");
            }
            Sides = sides.OrderByDescending(side => side).ToArray();
            CheckIsValid(Sides);
            CalcArea = CalcAreaByThreeSides;
        }
        protected void CheckIsValid(double[] sides)
        {
            if (sides[0] == sides[1] + sides[2])
            {
                throw new Exception("Length of one side is equals sum of two others");
            }
        }
        protected double CalcAreaByThreeSides()
        {
            double p = (Sides[0] + Sides[1] + Sides[2]) / 2;
            return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
        }
        public bool IsRectangled()
        {
            if (Sides == null)
            {
                throw new Exception("Sides array is null.");
            }
            float hypotenuse = (float)Sides[0];
            float firstCathetus = (float)Sides[1];
            float secCathetus = (float)Sides[2];

            return MathF.Pow(hypotenuse, 2) == MathF.Pow(firstCathetus, 2) + MathF.Pow(secCathetus, 2);
        }
    }
}
