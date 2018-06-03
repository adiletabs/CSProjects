namespace Drop
{
    partial class Drops
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drops));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Rain = new System.Windows.Forms.Button();
            this.RainTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Rain
            // 
            this.Rain.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Rain.FlatAppearance.BorderSize = 2;
            this.Rain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rain.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Rain.Location = new System.Drawing.Point(250, 177);
            this.Rain.Name = "Rain";
            this.Rain.Size = new System.Drawing.Size(100, 30);
            this.Rain.TabIndex = 0;
            this.Rain.Text = "Start Rain";
            this.Rain.UseVisualStyleBackColor = true;
            this.Rain.Click += new System.EventHandler(this.Rain_Click);
            // 
            // RainTimer
            // 
            this.RainTimer.Interval = 50;
            this.RainTimer.Tick += new System.EventHandler(this.RainTimer_Tick);
            // 
            // Drops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.Rain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Drops";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drops";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button Rain;
        private System.Windows.Forms.Timer RainTimer;
    }
}

