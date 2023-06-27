using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestTask
{
    public class Figure
    {
        protected delegate double Calc();
        protected Calc CalcArea;
        public Figure(double[] numbers)
        {
            Validate(numbers);
        }
        protected void Validate(params double[] numbers)
        {
            foreach (double number in numbers)
            {
                if (number <= 0) throw new ArgumentException($"Value ({number}) must be greater than zero.");
            }
        }
        public double GetArea()
        {
            if (CalcArea == null)
            {
                throw new Exception("CalcArea method is null.");
            }
            return CalcArea();
        }
    }
}
