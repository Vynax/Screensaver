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
            offset = new Point( r.Next(10,20) * OneOrN1(), r.Next(10,20) * OneOrN1() );
            this.Width = width;
            this.Height = height;
            rect = new Rectangle(position.X, position.Y, this.Width, this.Height);
        }

        public void Draw(Graphics e)
        {
            e.FillPie(redBrush, rect, 0f, 360f);
        }

        public void Move()
        {
            position.X += offset.X;
            position.Y += offset.Y;
            rect = new Rectangle(position.X, position.Y, 100, 100);
        }

        public void ReOffset( int xory )//0是X1是Y
        {
            if (xory == 0)
                offset = new Point(offset.X * -1, offset.Y);
            else
                offset = new Point(offset.X, offset.Y * -1);
        }
        int OneOrN1(){
            int n = r.Next(2);
            Console.WriteLine(n);
            if (n == 1)
                return 1;
            else
                return -1;
        }
    }
}
