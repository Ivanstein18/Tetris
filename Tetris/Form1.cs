using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        int size;
        int[,] map = new int[8, 16];
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Init()
        {
            size = 25;
            Invalidate();

        }

        public void DrowMap(Graphics g)
        {
            for (int i = 0; i <= 16; i++)
            {
                g.DrawLine(Pens.Black, new Point(50, 50 + i * 25), new Point(50 + 8 * 25, 50 + i * 25));                

            }
            for (int i = 0; i <= 8; i++)
            {
                g.DrawLine(Pens.Black, new Point(50 + i * 25, 50), new Point(50 + i * 25, 50 + 16 * 25));

            }

        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            DrowMap(e.Graphics);
        }
    }
}
