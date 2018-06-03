namespace Paint
{
    partial class MyPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPaint));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.LocationBar = new System.Windows.Forms.TextBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseThickness = new System.Windows.Forms.ToolStripMenuItem();
            this.Thickness1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Thickness2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Thickness3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Thickness4 = new System.Windows.Forms.ToolStripMenuItem();
            this.coloursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.TimeBar = new System.Windows.Forms.TextBox();
            this.ChoosePen = new System.Windows.Forms.Button();
            this.ChooseLine = new System.Windows.Forms.Button();
            this.ChooseRec = new System.Windows.Forms.Button();
            this.ChooseCircle = new System.Windows.Forms.Button();
            this.ChooseTri = new System.Windows.Forms.Button();
            this.ChooseFill = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.White;
            this.PictureBox.Location = new System.Drawing.Point(0, 77);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(701, 341);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Show);
            this.PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // LocationBar
            // 
            this.LocationBar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.LocationBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationBar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationBar.Location = new System.Drawing.Point(0, 418);
            this.LocationBar.Multiline = true;
            this.LocationBar.Name = "LocationBar";
            this.LocationBar.ReadOnly = true;
            this.LocationBar.Size = new System.Drawing.Size(523, 23);
            this.LocationBar.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.ChooseThickness,
            this.coloursToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(701, 24);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "menu";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.Save});
            this.File.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(43, 20);
            this.File.Text = "File";
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(152, 22);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.OpenFile);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(152, 22);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.SaveFile);
            // 
            // ChooseThickness
            // 
            this.ChooseThickness.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Thickness1,
            this.Thickness2,
            this.Thickness3,
            this.Thickness4});
            this.ChooseThickness.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseThickness.Name = "ChooseThickness";
            this.ChooseThickness.Size = new System.Drawing.Size(81, 20);
            this.ChooseThickness.Text = "Thickness";
            // 
            // Thickness1
            // 
            this.Thickness1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Thickness1.Image = ((System.Drawing.Image)(resources.GetObject("Thickness1.Image")));
            this.Thickness1.Name = "Thickness1";
            this.Thickness1.Size = new System.Drawing.Size(84, 22);
            this.Thickness1.Text = "1";
            this.Thickness1.Click += new System.EventHandler(this.Thickness1_Click);
            // 
            // Thickness2
            // 
            this.Thickness2.Image = ((System.Drawing.Image)(resources.GetObject("Thickness2.Image")));
            this.Thickness2.Name = "Thickness2";
            this.Thickness2.Size = new System.Drawing.Size(84, 22);
            this.Thickness2.Text = "2";
            this.Thickness2.Click += new System.EventHandler(this.Thickness2_Click);
            // 
            // Thickness3
            // 
            this.Thickness3.Image = ((System.Drawing.Image)(resources.GetObject("Thickness3.Image")));
            this.Thickness3.Name = "Thickness3";
            this.Thickness3.Size = new System.Drawing.Size(84, 22);
            this.Thickness3.Text = "3";
            this.Thickness3.Click += new System.EventHandler(this.Thickness3_Click);
            // 
            // Thickness4
            // 
            this.Thickness4.Image = ((System.Drawing.Image)(resources.GetObject("Thickness4.Image")));
            this.Thickness4.Name = "Thickness4";
            this.Thickness4.Size = new System.Drawing.Size(84, 22);
            this.Thickness4.Text = "4";
            this.Thickness4.Click += new System.EventHandler(this.Thickness4_Click);
            // 
            // coloursToolStripMenuItem
            // 
            this.coloursToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coloursToolStripMenuItem.Name = "coloursToolStripMenuItem";
            this.coloursToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.coloursToolStripMenuItem.Text = "Colours";
            this.coloursToolStripMenuItem.Click += new System.EventHandler(this.ChooseColour);
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Interval = 1000;
            this.Time.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // TimeBar
            // 
            this.TimeBar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.TimeBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeBar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeBar.Location = new System.Drawing.Point(523, 418);
            this.TimeBar.Multiline = true;
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Size = new System.Drawing.Size(178, 23);
            this.TimeBar.TabIndex = 3;
            this.TimeBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ChoosePen
            // 
            this.ChoosePen.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.ChoosePen.FlatAppearance.BorderSize = 2;
            this.ChoosePen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoosePen.Image = ((System.Drawing.Image)(resources.GetObject("ChoosePen.Image")));
            this.ChoosePen.Location = new System.Drawing.Point(65, 30);
            this.ChoosePen.Name = "ChoosePen";
            this.ChoosePen.Size = new System.Drawing.Size(40, 40);
            this.ChoosePen.TabIndex = 4;
            this.ChoosePen.UseVisualStyleBackColor = true;
            this.ChoosePen.Click += new System.EventHandler(this.ChoosePen_Click);
            // 
            // ChooseLine
            // 
            this.ChooseLine.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.ChooseLine.FlatAppearance.BorderSize = 2;
            this.ChooseLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseLine.Image = ((System.Drawing.Image)(resources.GetObject("ChooseLine.Image")));
            this.ChooseLine.Location = new System.Drawing.Point(170, 30);
            this.ChooseLine.Name = "ChooseLine";
            this.ChooseLine.Size = new System.Drawing.Size(40, 40);
            this.ChooseLine.TabIndex = 5;
            this.ChooseLine.UseVisualStyleBackColor = true;
            this.ChooseLine.Click += new System.EventHandler(this.ChooseLine_Click);
            // 
            // ChooseRec
            // 
            this.ChooseRec.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.ChooseRec.FlatAppearance.BorderSize = 2;
            this.ChooseRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseRec.Image = ((System.Drawing.Image)(resources.GetObject("ChooseRec.Image")));
            this.ChooseRec.Location = new System.Drawing.Point(275, 30);
            this.ChooseRec.Name = "ChooseRec";
            this.ChooseRec.Size = new System.Drawing.Size(40, 40);
            this.ChooseRec.TabIndex = 6;
            this.ChooseRec.UseVisualStyleBackColor = true;
            this.ChooseRec.Click += new System.EventHandler(this.ChooseRec_Click);
            // 
            // ChooseCircle
            // 
            this.ChooseCircle.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.ChooseCircle.FlatAppearance.BorderSize = 2;
            this.ChooseCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseCircle.Image = ((System.Drawing.Image)(resources.GetObject("ChooseCircle.Image")));
            this.ChooseCircle.Location = new System.Drawing.Point(380, 30);
            this.ChooseCircle.Name = "ChooseCircle";
            this.ChooseCircle.Size = new System.Drawing.Size(40, 40);
            this.ChooseCircle.TabIndex = 7;
            this.ChooseCircle.UseVisualStyleBackColor = true;
            this.ChooseCircle.Click += new System.EventHandler(this.ChooseCircle_Click);
            // 
            // ChooseTri
            // 
            this.ChooseTri.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.ChooseTri.FlatAppearance.BorderSize = 2;
            this.ChooseTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseTri.Image = ((System.Drawing.Image)(resources.GetObject("ChooseTri.Image")));
            this.ChooseTri.Location = new System.Drawing.Point(485, 30);
            this.ChooseTri.Name = "ChooseTri";
            this.ChooseTri.Size = new System.Drawing.Size(40, 40);
            this.ChooseTri.TabIndex = 8;
            this.ChooseTri.UseVisualStyleBackColor = true;
            this.ChooseTri.Click += new System.EventHandler(this.ChooseTri_Click);
            // 
            // ChooseFill
            // 
            this.ChooseFill.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.ChooseFill.FlatAppearance.BorderSize = 2;
            this.ChooseFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseFill.Image = ((System.Drawing.Image)(resources.GetObject("ChooseFill.Image")));
            this.ChooseFill.Location = new System.Drawing.Point(590, 30);
            this.ChooseFill.Name = "ChooseFill";
            this.ChooseFill.Size = new System.Drawing.Size(40, 40);
            this.ChooseFill.TabIndex = 9;
            this.ChooseFill.UseVisualStyleBackColor = true;
            this.ChooseFill.Click += new System.EventHandler(this.ChooseFill_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // MyPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(701, 441);
            this.Controls.Add(this.ChooseFill);
            this.Controls.Add(this.ChooseTri);
            this.Controls.Add(this.ChooseCircle);
            this.Controls.Add(this.ChooseRec);
            this.Controls.Add(this.ChooseLine);
            this.Controls.Add(this.ChoosePen);
            this.Controls.Add(this.TimeBar);
            this.Controls.Add(this.LocationBar);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Name = "MyPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPaint";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox LocationBar;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem ChooseThickness;
        private System.Windows.Forms.ToolStripMenuItem Thickness1;
        private System.Windows.Forms.ToolStripMenuItem Thickness2;
        private System.Windows.Forms.ToolStripMenuItem Thickness3;
        private System.Windows.Forms.ToolStripMenuItem Thickness4;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.TextBox TimeBar;
        private System.Windows.Forms.ToolStripMenuItem coloursToolStripMenuItem;
        private System.Windows.Forms.Button ChoosePen;
        private System.Windows.Forms.Button ChooseLine;
        private System.Windows.Forms.Button ChooseRec;
        private System.Windows.Forms.Button ChooseCircle;
        private System.Windows.Forms.Button ChooseTri;
        private System.Windows.Forms.Button ChooseFill;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

