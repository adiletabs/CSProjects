using System;
using System.Windows.Forms;

namespace Windows10Calculator
{
    public partial class Calculator : Form
    {
        Brain brain = new Brain();
        public Calculator()
        {
            InitializeComponent();
            brain.invoker = ShowInfo;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeBar.Text = DateTime.Now.ToString("h:mm");
        }

        private void ShowInfo(string msg)
        {
            Display.Text = msg;
        }

        private void BtnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            brain.Process(btn.Text);
        }

    }
}
