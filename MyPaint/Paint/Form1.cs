using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Paint
{
    enum Tools
    {
        Pen,
        Line,
        Rectangle,
        Circle,
        Triangle,
        Fill
    }

    enum BmpCreationMode
    {
        AfterFill,
        FromFile,
        Init
    }

    public partial class MyPaint : Form
    {
        public MyPaint()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");

            SetupPictureBox(BmpCreationMode.Init, "");
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeBar.Text = DateTime.Now.ToString("f");
        }

        Tools activeTool = Tools.Pen;

        Point firstpoint = default(Point);
        Point secondpoint = default(Point);
        Bitmap bmp = default(Bitmap);
        Graphics gfx = default(Graphics);
        Pen pen = new Pen(Color.Black, 1);
        bool ToShow;

        private void SetupPictureBox(BmpCreationMode mode, string fileName)
        {
            if (mode == BmpCreationMode.Init)
            {
                bmp = new Bitmap(PictureBox.Width, PictureBox.Height);
            }
            else if (mode == BmpCreationMode.FromFile)
            {
                bmp = new Bitmap(Bitmap.FromFile(OpenFileDialog.FileName));
            }

            gfx = Graphics.FromImage(bmp);

            if (mode == BmpCreationMode.Init)
            {
                gfx.Clear(Color.White);
            }

            PictureBox.Image = bmp;
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void ChooseColour(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog.Color;
            }
        }

        private void Thickness1_Click(object sender, EventArgs e)
        {
            pen.Width = 1;
        }

        private void Thickness2_Click(object sender, EventArgs e)
        {
            pen.Width = 3;
        }

        private void Thickness3_Click(object sender, EventArgs e)
        {
            pen.Width = 5;
        }

        private void Thickness4_Click(object sender, EventArgs e)
        {
            pen.Width = 7;
        }

        private void ChoosePen_Click(object sender, EventArgs e)
        {
            activeTool = Tools.Pen;
        }

        private void ChooseLine_Click(object sender, EventArgs e)
        {
            activeTool = Tools.Line;
        }

        private void ChooseRec_Click(object sender, EventArgs e)
        {
            activeTool = Tools.Rectangle;
        }

        private void ChooseCircle_Click(object sender, EventArgs e)
        {
            activeTool = Tools.Circle;
        }

        private void ChooseTri_Click(object sender, EventArgs e)
        {
            activeTool = Tools.Triangle;
        }

        private void ChooseFill_Click(object sender, EventArgs e)
        {
            activeTool = Tools.Fill;
        }

        Rectangle GetRectangle(Point p1, Point p2)
        {
            Rectangle rec = new Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));
            return rec;
        }

        Point[] GetPoints()
        {
            Point thirdPoint = default(Point);

            if (secondpoint.X > firstpoint.X)
            {
                thirdPoint.X = firstpoint.X - (secondpoint.X - firstpoint.X);
                thirdPoint.Y = secondpoint.Y;
            }
            else if (secondpoint.X < firstpoint.X)
            {
                thirdPoint.X = firstpoint.X + (firstpoint.X - secondpoint.X);
                thirdPoint.Y = secondpoint.Y;
            }

            Point[] points =
            {
                firstpoint,
                secondpoint,
                thirdPoint
            };
            return points;
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            ToShow = true;
            firstpoint = e.Location;
            if (activeTool == Tools.Fill)
            {
                MapFill mf = new MapFill();
                mf.Fill(gfx, firstpoint, pen.Color, ref bmp);
                SetupPictureBox(BmpCreationMode.AfterFill, "");
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            LocationBar.Text = "Cursor location: " + e.X + ", " + e.Y + "px";
            if (e.Button == MouseButtons.Left)
            {
                secondpoint = e.Location;
                switch (activeTool)
                {
                    case Tools.Pen:
                        gfx.DrawLine(pen, firstpoint, secondpoint);
                        firstpoint = secondpoint;
                        break;
                    case Tools.Line:
                        break;
                    case Tools.Rectangle:
                        break;
                    case Tools.Circle:
                        break;
                    case Tools.Triangle:
                        break;
                    case Tools.Fill:
                        break;
                    default:
                        break;
                }
            }
            PictureBox.Refresh();
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            ToShow = false;
            switch (activeTool)
            {
                case Tools.Pen:
                    break;
                case Tools.Fill:
                    break;
                case Tools.Rectangle:
                    gfx.DrawRectangle(pen, GetRectangle(firstpoint, secondpoint));
                    break;
                case Tools.Circle:
                    gfx.DrawEllipse(pen, GetRectangle(firstpoint, secondpoint));
                    break;
                case Tools.Triangle:
                    gfx.DrawPolygon(pen, GetPoints());
                    break;
                case Tools.Line:
                    gfx.DrawLine(pen, firstpoint, secondpoint);
                    break;
                default:
                    break;
            }
        }

        private void Show(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            if (ToShow)
            {
                switch (activeTool)
                {
                    case Tools.Pen:
                        break;
                    case Tools.Fill:
                        break;
                    case Tools.Rectangle:
                        e.Graphics.DrawRectangle(pen, GetRectangle(firstpoint, secondpoint));
                        break;
                    case Tools.Circle:
                        e.Graphics.DrawEllipse(pen, GetRectangle(firstpoint, secondpoint));
                        break;
                    case Tools.Triangle:
                        e.Graphics.DrawPolygon(pen, GetPoints());
                        break;
                    case Tools.Line:
                        e.Graphics.DrawLine(pen, firstpoint, secondpoint);
                        break;
                    default:
                        break;
                }
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox.Image.Save(SaveFileDialog.FileName);
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                SetupPictureBox(BmpCreationMode.FromFile, OpenFileDialog.FileName);
            }
        }
    }
}
