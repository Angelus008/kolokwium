using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolos
{
 
        [TestClass]
        public class PointTests
        {
            [TestMethod]
            public void PointCreateTest()
            {
                try
                {
                    Point point = new Point(2, 5);
                }
                catch (Exception)
                {
                    Assert.Fail();
                }
            }

            [TestMethod]
            public void GetPositionTest()
            {
                Point point = new Point(2, 5);

                Assert.AreEqual(point.X, 2);
                Assert.AreEqual(point.Y, 5);
            }
        }
    }
}

