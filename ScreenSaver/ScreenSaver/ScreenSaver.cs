using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenSaver
{
    public partial class ScreenSaver : Form
    {
        #region 宣告參數
        List<Figure> listCirCle = new List<Figure>();

        #endregion
        public ScreenSaver()
        {
            InitializeComponent();
        }

        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            timer1.Interval = 20;
            this.DoubleBuffered = true;
            //Figure tmp = new Figure( 100, 100 );
            //listCirCle.Add(tmp);
            this.Width = 800;
            this.Height = 600;
            CenterToScreen();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Figure tmp in listCirCle)
            {
                //0是左1是右
                if (tmp.position.X + tmp.Width >= ClientRectangle.Right)
                    tmp.ReDirect(-1,tmp.direct.Y);
                else if (tmp.position.X <= ClientRectangle.Left)
                    tmp.ReDirect(1, tmp.direct.Y);
                if (tmp.position.Y + tmp.Height >= ClientRectangle.Bottom)
                    tmp.ReDirect(tmp.direct.X, -1);
                else if (tmp.position.Y <= ClientRectangle.Top)
                    tmp.ReDirect(tmp.direct.X, 1);
                tmp.Move();
            }

            this.Invalidate();
        }

        private void ScreenSaver_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure tmp in listCirCle)
            {
                tmp.Draw(e.Graphics);
            }
        }

        private void ScreenSaver_MouseClick(object sender, MouseEventArgs e)
        {
            Figure tmp = new Figure(100, 100);
            tmp.position = new Point(e.Location.X - tmp.Width / 2, e.Location.Y - tmp.Height / 2);
            listCirCle.Add(tmp);
        }

        
    }

}
