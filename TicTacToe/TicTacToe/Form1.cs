using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        Graphics g;

        Button[,] cells = new Button[3, 3];
        int[,] whos = new int[3, 3];
        bool end;

        int size = 120;
        int turn;

        public TicTacToe()
        {
            InitializeComponent();
            g = CreateGraphics();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button btn = new Button();
                    btn.Name = i.ToString() + j.ToString();
                    btn.Size = new Size(size, size);
                    btn.Location = new Point(i * size, j * size + 45);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.WhiteSmoke;
                    btn.Enabled = false;
                    cells[i, j] = btn;
                    Controls.Add(cells[i, j]);
                }
            }
        }


        private void TicTacToe_Paint(object sender, PaintEventArgs e)
        {
            g.DrawRectangle(new Pen(Color.Black, 3), 150, 0, 210, 45);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cells[i, j].Enabled = true;
                    cells[i, j].Image = null;
                    cells[i, j].BackColor = Color.White;
                    cells[i, j].Click += Process;
                    whos[i, j] = -1;
                }
            }
            turn = 0;
            end = false;
            Display.Text = "";
            Display2.Text = "🗙";
        }

        private void Process(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int x = int.Parse(btn.Name[0].ToString());
            int y = int.Parse(btn.Name[1].ToString());

            if (btn.Image == null)
            {
                if (turn % 2 == 0)
                {
                    btn.Image = Properties.Resources.cross;
                    whos[x, y] = 1;
                }
                else
                {
                    btn.Image = Properties.Resources.circle;
                    whos[x, y] = 0;
                }

                turn++;
                Check();

                if (!end)
                {
                    if (turn % 2 == 1)
                    {
                        Display2.Text = "◯";
                    }
                    else
                    {
                        Display2.Text = "🗙";
                    }
                }
            }
        }

        private void Check()
        {
            for (int i = 0; i < 3; i++)
            {
                if (whos[i, 0] >=0 && whos[i, 0] == whos[i, 1] && whos[i, 1] == whos[i, 2])
                {
                    cells[i, 0].Image = Properties.Resources.win;
                    cells[i, 1].Image = Properties.Resources.win;
                    cells[i, 2].Image = Properties.Resources.win;

                    GameOver();
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (whos[0, i] >= 0 && whos[0, i] == whos[1, i] && whos[1, i] == whos[2, i])
                {
                    cells[0, i].Image = Properties.Resources.win;
                    cells[1, i].Image = Properties.Resources.win;
                    cells[2, i].Image = Properties.Resources.win;

                    GameOver();
                }
            }

            if (whos[0, 0] >= 0 && whos[0, 0] == whos[1, 1] && whos[1, 1] == whos[2, 2])
            {
                cells[0, 0].Image = Properties.Resources.win;
                cells[1, 1].Image = Properties.Resources.win;
                cells[2, 2].Image = Properties.Resources.win;

                GameOver();
            }

            else if  (whos[0, 2] >= 0 && whos[0, 2] == whos[1, 1] && whos[1, 1] == whos[2, 0])
            {
                cells[0, 2].Image = Properties.Resources.win;
                cells[1, 1].Image = Properties.Resources.win;
                cells[2, 0].Image = Properties.Resources.win;

                GameOver();
            }

            if (!end && turn == 9)
            {
                Display.Text = "         Draw";
                Display2.Text = "";
                end = true;
            }

            if (end)
            {
                foreach (Button btn in cells)
                {
                    btn.Click -= Process;
                }
            }
        }

        private void GameOver()
        {
            if (turn % 2 == 1)
            {
                Display.Text = "       🗙 wins!";
                Display2.Text = "";
            }
            else if (turn % 2 == 0)
            {
                Display.Text = "       ◯ wins!";
                Display2.Text = "";
            }
            end = true;
        }
    }
}
