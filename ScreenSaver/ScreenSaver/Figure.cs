using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ScreenSaver
{
    class Figure
    {
        public Point position;
        public Point offset { get; set; }
        public Point direct;
        Pen blackPen;
        Rectangle rect;
        SolidBrush redBrush;
        Random r = new Random(Guid.NewGuid().GetHashCode());
        public int Width, Height;
        public Figure(int width, int height)
        {
            blackPen = new Pen(Color.Black);
            redBrush = new SolidBrush(Color.Red);
            position = new Point(400, 300);
            offset = new Point(r.Next(10, 20), r.Next(10, 20));
            direct = new Point(OneOrN1(), OneOrN1());
            this.Width = width;
            this.Height = height;
            rect = new Rectangle(position.X, position.Y, this.Width, this.Height);
        }

        public void Draw(Graphics e)
        {
            e.FillEllipse(redBrush, rect);
            e.DrawEllipse(blackPen, rect);
            //e.FillPie(redBrush, rect, 0f, 360f);
        }

        public void Move()
        {
            position.X += offset.X * direct.X;
            position.Y += offset.Y * direct.Y;
            rect = new Rectangle(position.X, position.Y, 100, 100);
        }

        public void ReDirect(int dx, int dy)//-1是左1是右
        {
            direct.X = dx;
            direct.Y = dy;
            //offset = new Point(offset.X * direct.X, offset.Y * direct.Y);
        }
        int OneOrN1()
        {
            int n = r.Next(2);
            Console.WriteLine(n);
            if (n == 1)
                return 1;
            else
                return -1;
        }
    }
}
