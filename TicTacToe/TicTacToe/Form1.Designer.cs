namespace TicTacToe
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.Start = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Label();
            this.Display2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.White;
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(0, 0);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(150, 45);
            this.Start.TabIndex = 0;
            this.Start.Text = "New Game";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.Display.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Display.Location = new System.Drawing.Point(193, 12);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(121, 21);
            this.Display.TabIndex = 2;
            this.Display.Text = "← Click to Start";
            // 
            // Display2
            // 
            this.Display2.AutoSize = true;
            this.Display2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Display2.Location = new System.Drawing.Point(245, 12);
            this.Display2.Name = "Display2";
            this.Display2.Size = new System.Drawing.Size(0, 21);
            this.Display2.TabIndex = 3;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 405);
            this.Controls.Add(this.Display2);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TicTacToe_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Label Display2;
    }
}

