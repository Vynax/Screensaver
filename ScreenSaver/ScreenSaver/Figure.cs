using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ScreenSaver
{
    class Figure
    {
        public int X { get; set; }
        public int Y { get; set; }
        Pen blackPen;
        Rectangle rect;
        public Figure()
        {
            blackPen = new Pen(Color.Black);
            rect = new Rectangle(0, 0, 100, 100);
        }

        public void Draw(Graphics e)
        {
            e.DrawArc(blackPen, rect, 0f, 360f);
        }
    }
}
