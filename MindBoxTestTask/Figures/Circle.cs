using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestTask.Figures
{
    public class Circle : Figure
    {
        public double Radius { get; }
        public Circle(double radius) : base(new double[] { radius })
        {
            Radius = radius;
            CalcArea = CalcAreaByRadius;
        }
        public double CalcAreaByRadius()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
