
namespace ShapeTracker.Models{
    public class Rectangle
    {
       public Rectangle(int length1, int length2)
       {
            Width = length1;
            Height = length2;
       }

       public int Width { get; set; }
       public int Height { get; set; }
    }
}
