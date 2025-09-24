using Display.SDK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display.Library
{
    public class Square : IPlug
    {
        public string Name => "Square";

        public void Draw(Graphics graphic, SolidBrush brush, int x, int y, int width, int height)
        {
            graphic.FillRectangle(brush, x, y, width, height);
        }
    }
}

