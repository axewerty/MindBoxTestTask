using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxTestTask;
using MindBoxTestTask.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestTask.Tests
{
    [TestClass()]
    public class FigureTests
    {
        [TestMethod()]
        public void FigureTest()
        {
            //Side length/radius must be greater than zero
            Assert.ThrowsException<ArgumentException>(() => new Figure(new double[] { 0, 3, 5 }));
            Assert.ThrowsException<ArgumentException>(() => new Figure(new double[] { -42 }));
        }

        [TestMethod()]
        public void GetAreaTest()
        {
            //GetArea delegate is not set
            Figure figure = new(new double[] { 42 });
            Assert.ThrowsException<Exception>(() => figure.GetArea());
        }
    }
}