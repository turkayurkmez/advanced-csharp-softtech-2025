using Display.SDK;
using System.Drawing;

namespace Display.Library
{
    public class Circle : IPlug
    {
        public string Name => "Circle";

        public void Draw(Graphics graphic, SolidBrush brush, int x, int y, int width, int height)
        {
          graphic.FillEllipse(brush, x, y, width, height);  
        }
    }
}
