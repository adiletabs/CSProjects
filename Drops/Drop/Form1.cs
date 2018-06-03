using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Drop
{
    public partial class Drops : Form
    {
        Graphics g;
        Pen p = new Pen(Color.DarkBlue, 2);

        List<int> R = new List<int>();
        List<int> x = new List<int>();
        List<int> y = new List<int>();

        Random rnd = new Random();

        public Drops()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < x.Count; i++)
            {
                g.DrawEllipse(p, x[i] - R[i] / 2, y[i] - R[i] / 2, R[i], R[i]);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < R.Count; i++)
            {
                R[i]++;
                if (R[i] == 40)
                {
                    R.RemoveAt(i);
                    x.RemoveAt(i);
                    y.RemoveAt(i);
                }
            }
            Refresh();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x.Add(e.Location.X);
            y.Add(e.Location.Y);
            R.Add(2);
        }

        private void Rain_Click(object sender, EventArgs e)
        {
            if (Rain.Text == "Start Rain")
            {
                RainTimer.Start();
                Rain.Text = "Stop";
            }
            else
            {
                RainTimer.Stop();
                Rain.Text = "Start Rain";
            }
        }

        private void RainTimer_Tick(object sender, EventArgs e)
        {
            x.Add(rnd.Next(0, 601));
            y.Add(rnd.Next(0, 451));
            R.Add(2);
        }
    }
}
