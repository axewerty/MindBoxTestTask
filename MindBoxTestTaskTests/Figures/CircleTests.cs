using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxTestTask.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestTask.Figures.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void CalcAreaByRadiusTest()
        {
            Dictionary<double, double> areaByRadius = new()
            {
                {1, 6.283185307179586},
                {10, 62.83185307179586},
                {42, 263.89378290154264},
            };

            foreach (var item in areaByRadius)
            {
                Circle circle = new(item.Key);
                Assert.AreEqual(circle.GetArea(), item.Value);
            }
        }
    }
}