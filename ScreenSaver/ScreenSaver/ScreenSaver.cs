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
            timer1.Interval = 40;
            this.DoubleBuffered = true;
            Figure tmp = new Figure();
            listCirCle.Add(tmp);
            this.Width = 800;
            this.Height = 600;
            CenterToScreen();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void ScreenSaver_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure tmp in listCirCle)
            {
                tmp.Draw(e.Graphics);
            }
        }

        
    }

}
