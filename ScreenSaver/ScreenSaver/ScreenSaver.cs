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
        List<Circle> listCirCle = new List<Circle>();

        #endregion
        public ScreenSaver()
        {
            InitializeComponent();
        }

        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            timer1.Interval = 40;
            this.DoubleBuffered = true;
            Circle tmp = new Circle();
            listCirCle.Add(tmp);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void ScreenSaver_Paint(object sender, PaintEventArgs e)
        {
            foreach (Circle tmp in listCirCle)
            {
                tmp.Draw(e.Graphics);
            }
        }

        
    }

    class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        Pen blackPen;
        Rectangle rect;
        public Circle()
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
