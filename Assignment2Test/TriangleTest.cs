using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2;

namespace Assignment2Test
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void testTriangleFormation()
        {
            TriangleSolver ts = new TriangleSolver();

            string resultArea = ts.Analyze(5, 5, 10);
            Assert.AreEqual("It is not a triangle", resultArea);

            string resultArea2 = ts.Analyze(5, 6, 10);
            Assert.AreEqual("It is a triangle and the triangle is Scalene", resultArea2);
        }

        [Test]
        public void testScalene()
        {
            TriangleSolver ts = new TriangleSolver();
            string resultArea3 = ts.Analyze(6, 5, 10);
            Assert.AreEqual("It is a triangle and the triangle is Scalene", resultArea3);

            string resultArea4 = ts.Analyze(20, 10, 12);
            Assert.AreEqual("It is a triangle and the triangle is Scalene", resultArea4);
        }

        [Test]
        public void testEquilateral()
        {
            TriangleSolver ts = new TriangleSolver();
            string resultArea5 = ts.Analyze(5, 5, 5);
            Assert.AreEqual("It is a triangle and the triangle is Equilateral", resultArea5);

            string resultArea6 = ts.Analyze(7, 7, 7);
            Assert.AreEqual("It is a triangle and the triangle is Equilateral", resultArea6);
        }

        [Test]
        public void testIsoceles()
        {
            TriangleSolver ts = new TriangleSolver();
            string resultArea7 = ts.Analyze(6, 6, 10);
            Assert.AreEqual("It is a triangle and the triangle is Isoceles", resultArea7);

            string resultArea8 = ts.Analyze(15, 8, 8);
            Assert.AreEqual("It is a triangle and the triangle is Equilateral", resultArea8);
        }
    }
}
