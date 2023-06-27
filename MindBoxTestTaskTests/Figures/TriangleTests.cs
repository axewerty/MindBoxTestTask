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
    public class TriangleTests
    {

        [TestMethod()]
        public void TriangleTest()
        {
            // Length of one side can't be equals sum of two other sides
            Assert.ThrowsException<Exception>(() => new Triangle(new double[] { 1, 2, 3 }));
            Assert.ThrowsException<Exception>(() => new Triangle(new double[] { 2, 3, 5 }));
        }
        [TestMethod()]
        public void CalcAreaTest()
        {
            Dictionary<double[], double> areaBySides = new()
            {
                { new double[] { 6,5,7 }, 14.696938456699069},
                { new double[] { 2,3,4 }, 2.9047375096555625},
                { new double[] { 3, 4, 5 }, 6},
            };

            foreach (var item in areaBySides)
            {
                Triangle triangle = new(item.Key);
                Assert.AreEqual(triangle.GetArea(), item.Value);
            }
        }

        [TestMethod()]
        public void IsRectangledTest()
        {
            Triangle notRectangled = new Triangle(new double[] { 6, 5, 4 });
            Assert.IsFalse(notRectangled.IsRectangled());

            Triangle rectangled = new Triangle(new double[] { 3, 4, 5 });
            Assert.IsTrue(rectangled.IsRectangled());
        }
    }
}