using System;
using System.Windows.Forms;

namespace CalculatorDemo
{
    public partial class Calculator1 : Form
    {
        Calc calc = new Calc();

        public Calculator1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeBar.Text = DateTime.Now.ToString("h:mm");
        }

        bool isfirst;
        bool operclicked;
        bool add;

        private void DigitClick(object sender, EventArgs e)
        {
            Button digbtn = sender as Button;
            operclicked = false;

            switch (calc.currentNum)
            {
                case NumberStates.firstN:
                    if (isfirst)
                    {                                              
                        Display.Text = digbtn.Text;                       
                        isfirst = false;
                    }
                    else
                    {
                        if (Display.Text == "0")
                        {
                            Display.Text = digbtn.Text;
                        }
                        else
                        {
                            Display.Text = Display.Text + digbtn.Text;
                        }
                    }
                    break;
                case NumberStates.secondN:
                    if (isfirst)
                    {
                        if (add)
                        {
                            Display.Text = Display.Text + digbtn.Text;
                        }
                        else
                        {
                            Display.Text = digbtn.Text;
                        }

                        isfirst = false;
                    }
                    else
                    {
                        if (Display.Text == "0")
                        {
                            Display.Text = digbtn.Text;
                        }
                        else
                        {
                            Display.Text = Display.Text + digbtn.Text;
                        }
                    }
                    break;
            }     
        }

        private void CommaClick(object sender, EventArgs e)
        {
            Button combtn = sender as Button;
            bool canwe = true;

            foreach (char c in Display.Text)
            {
                if (c == ',')
                {
                    canwe = false;
                    break;
                }
            }

            if (operclicked)
            {
                Display.Text = "0,";
                add = true;
            }
            else if (canwe)
            {
                Display.Text = Display.Text + combtn.Text;
            }
        }

        string prevbtn;

        private void OperClick(object sender, EventArgs e)
        {
            Button operbtn = sender as Button;
            operclicked = true;
            add = false;
            if (calc.currentNum == NumberStates.secondN)
            {
                switch (prevbtn)
                {
                    case "+":
                        Display.Text = (calc.firstNumber + double.Parse(Display.Text)).ToString();
                        break;
                    case "−":
                        Display.Text = (calc.firstNumber - double.Parse(Display.Text)).ToString();
                        break;
                    case "×":
                        Display.Text = (calc.firstNumber * double.Parse(Display.Text)).ToString();
                        break;
                    case "÷":
                        Display.Text = (calc.firstNumber / double.Parse(Display.Text)).ToString();
                        break;
                }
            }

            calc.firstNumber = double.Parse(Display.Text);

            switch (operbtn.Text)
            {
                case "+":
                    calc.currentOp = OperationStates.Plus;
                    prevbtn = "+";
                    break;
                case "−":
                    calc.currentOp = OperationStates.Minus;
                    prevbtn = "−";
                    break;
                case "×":
                    calc.currentOp = OperationStates.Multiply;
                    prevbtn = "×";
                    break;
                case "÷":
                    calc.currentOp = OperationStates.Divide;
                    prevbtn = "÷";
                    break;
                case "=":
                    calc.currentOp = OperationStates.Equals;
                    prevbtn = "=";
                    break;
            }

            switch (calc.currentOp)
            {
                case OperationStates.Plus:
                    if (calc.currentNum == NumberStates.firstN)
                    {
                        calc.currentNum = NumberStates.secondN;
                    }
                    break;
                case OperationStates.Minus:
                    if (calc.currentNum == NumberStates.firstN)
                    {
                        calc.currentNum = NumberStates.secondN;
                    }
                    break;
                case OperationStates.Multiply:
                    if (calc.currentNum == NumberStates.firstN)
                    {
                        calc.currentNum = NumberStates.secondN;
                    }
                    break;
                case OperationStates.Divide:
                    if (calc.currentNum == NumberStates.firstN)
                    {
                        calc.currentNum = NumberStates.secondN;
                    }
                    break;
                case OperationStates.Equals:
                    calc.currentNum = NumberStates.firstN;
                    break;
            }

            isfirst = true;
        }

        private void MakeOpposite(object sender, EventArgs e)
        {
            Display.Text = (-1 * double.Parse(Display.Text)).ToString();
        }

        private void Percent(object sender, EventArgs e)
        {
            if (Display.Text != "0")
            {
                Display.Text = (double.Parse(Display.Text) / 100).ToString();
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            Display.Text = "0";
            calc.currentNum = NumberStates.firstN;
        }
    }
}
