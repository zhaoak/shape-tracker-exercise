using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class RectangleTests
  {
    // tests
    // test if constructor constructs rectangle object
    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(4, 6);
      Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
    }

    // test if can set and retrieve rectangle side length vals
    [TestMethod]
    public void GetSides_ReturnsSides_Int()
    {
      int length1 = 4;
      int length2 = 2;

      Rectangle newRectangle = new Rectangle(length1, length2);
      Assert.AreEqual(length1, newRectangle.Width);
      Assert.AreEqual(length2, newRectangle.Height);
    }

    // test if correctly calculates area
    [TestMethod]
    public void CalculateArea_ReturnsArea_Int()
    {
      Rectangle newRectangle = new Rectangle(6, 9);
      int area = newRectangle.CalculateArea();
      Assert.AreEqual(area, 54);
    }
  }
}
