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
        public void testTriangle()
        {
            TriangleSolver ts = new TriangleSolver();

            string resultArea = ts.Analyze(5, 5, 10);
            Assert.That(resultArea, Is.EqualTo("It is not a Triangle").IgnoreCase);


        }
    }
}
