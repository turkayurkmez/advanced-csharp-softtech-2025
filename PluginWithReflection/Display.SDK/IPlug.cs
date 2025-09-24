using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display.SDK
{
    public interface IPlug
    {
        string Name { get; }
        void Draw(Graphics graphic, SolidBrush brush, int x, int y, int width, int height);
    }
}
