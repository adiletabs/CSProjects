using System.Drawing;

namespace Windows10Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.TimeBar = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(120, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "M+";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(180, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "M-";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(240, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "MS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.BtnClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(0, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "%";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BtnClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(75, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "√";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.BtnClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(150, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 45);
            this.button6.TabIndex = 5;
            this.button6.Text = " x²";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.BtnClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(225, 115);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 45);
            this.button7.TabIndex = 6;
            this.button7.Text = "⅟";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.BtnClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(225, 160);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 45);
            this.button8.TabIndex = 7;
            this.button8.Text = "÷";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.BtnClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(225, 205);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 45);
            this.button9.TabIndex = 8;
            this.button9.Text = "×";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.BtnClick);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(225, 250);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 45);
            this.button10.TabIndex = 9;
            this.button10.Text = "−";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.BtnClick);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(225, 295);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 45);
            this.button11.TabIndex = 10;
            this.button11.Text = "+";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.BtnClick);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(225, 340);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 45);
            this.button12.TabIndex = 11;
            this.button12.Text = "=";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.BtnClick);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.Location = new System.Drawing.Point(0, 160);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 45);
            this.button13.TabIndex = 12;
            this.button13.Text = "CE";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.BtnClick);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.ForeColor = System.Drawing.Color.Black;
            this.button14.Location = new System.Drawing.Point(75, 160);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 45);
            this.button14.TabIndex = 13;
            this.button14.Text = "C";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.BtnClick);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.ForeColor = System.Drawing.Color.Black;
            this.button15.Location = new System.Drawing.Point(150, 160);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 45);
            this.button15.TabIndex = 14;
            this.button15.Text = "⌫";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.BtnClick);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.ForeColor = System.Drawing.Color.Black;
            this.button16.Location = new System.Drawing.Point(75, 340);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 45);
            this.button16.TabIndex = 15;
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.BtnClick);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Transparent;
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.ForeColor = System.Drawing.Color.Black;
            this.button17.Location = new System.Drawing.Point(0, 295);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 45);
            this.button17.TabIndex = 16;
            this.button17.Text = "1";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.BtnClick);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.ForeColor = System.Drawing.Color.Black;
            this.button18.Location = new System.Drawing.Point(75, 295);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 45);
            this.button18.TabIndex = 17;
            this.button18.Text = "2";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.BtnClick);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Transparent;
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.ForeColor = System.Drawing.Color.Black;
            this.button19.Location = new System.Drawing.Point(150, 295);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 45);
            this.button19.TabIndex = 18;
            this.button19.Text = "3";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.BtnClick);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Transparent;
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.ForeColor = System.Drawing.Color.Black;
            this.button20.Location = new System.Drawing.Point(0, 250);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 45);
            this.button20.TabIndex = 19;
            this.button20.Text = "4";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.BtnClick);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Transparent;
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button21.ForeColor = System.Drawing.Color.Black;
            this.button21.Location = new System.Drawing.Point(75, 250);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 45);
            this.button21.TabIndex = 20;
            this.button21.Text = "5";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.BtnClick);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Transparent;
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button22.ForeColor = System.Drawing.Color.Black;
            this.button22.Location = new System.Drawing.Point(150, 250);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 45);
            this.button22.TabIndex = 21;
            this.button22.Text = "6";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.BtnClick);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Transparent;
            this.button23.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button23.ForeColor = System.Drawing.Color.Black;
            this.button23.Location = new System.Drawing.Point(0, 205);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 45);
            this.button23.TabIndex = 22;
            this.button23.Text = "7";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.BtnClick);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Transparent;
            this.button24.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button24.ForeColor = System.Drawing.Color.Black;
            this.button24.Location = new System.Drawing.Point(75, 205);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 45);
            this.button24.TabIndex = 23;
            this.button24.Text = "8";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.BtnClick);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Transparent;
            this.button25.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button25.ForeColor = System.Drawing.Color.Black;
            this.button25.Location = new System.Drawing.Point(150, 205);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 45);
            this.button25.TabIndex = 24;
            this.button25.Text = "9";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.BtnClick);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Transparent;
            this.button26.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button26.ForeColor = System.Drawing.Color.Black;
            this.button26.Location = new System.Drawing.Point(150, 340);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(75, 45);
            this.button26.TabIndex = 25;
            this.button26.Text = ",";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.BtnClick);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Transparent;
            this.button27.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button27.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button27.ForeColor = System.Drawing.Color.Black;
            this.button27.Location = new System.Drawing.Point(0, 340);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 45);
            this.button27.TabIndex = 26;
            this.button27.Text = "±";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.BtnClick);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.Linen;
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Display.Font = new System.Drawing.Font("Arial Unicode MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Display.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Display.Location = new System.Drawing.Point(0, 20);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(300, 70);
            this.Display.TabIndex = 27;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Transparent;
            this.button28.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button28.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button28.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button28.ForeColor = System.Drawing.Color.Black;
            this.button28.Location = new System.Drawing.Point(0, 90);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(60, 25);
            this.button28.TabIndex = 28;
            this.button28.Text = "MC";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.BtnClick);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.Transparent;
            this.button29.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button29.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button29.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button29.ForeColor = System.Drawing.Color.Black;
            this.button29.Location = new System.Drawing.Point(60, 90);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(60, 25);
            this.button29.TabIndex = 29;
            this.button29.Text = "MR";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.BtnClick);
            // 
            // TimeBar
            // 
            this.TimeBar.BackColor = System.Drawing.Color.Linen;
            this.TimeBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeBar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeBar.Location = new System.Drawing.Point(0, 0);
            this.TimeBar.Multiline = true;
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Size = new System.Drawing.Size(300, 20);
            this.TimeBar.TabIndex = 30;
            this.TimeBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 385);
            this.Controls.Add(this.TimeBar);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.TextBox TimeBar;
        private System.Windows.Forms.Timer timer;
    }
}

