namespace PaintTest3
{
    partial class Form1
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
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.SetPenButton = new System.Windows.Forms.Button();
            this.SetTriangleButton = new System.Windows.Forms.Button();
            this.SetCircleButton = new System.Windows.Forms.Button();
            this.SetRectangleButton = new System.Windows.Forms.Button();
            this.CurrentColorBox = new System.Windows.Forms.Button();
            this.BlackColorButton = new System.Windows.Forms.Button();
            this.BlueColorButton = new System.Windows.Forms.Button();
            this.GreenColorButton = new System.Windows.Forms.Button();
            this.YellowColorButton = new System.Windows.Forms.Button();
            this.OrangeColorButton = new System.Windows.Forms.Button();
            this.WidthTrackBar = new System.Windows.Forms.TrackBar();
            this.RedColorButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCanvas.BackColor = System.Drawing.Color.White;
            this.pictureBoxCanvas.Location = new System.Drawing.Point(0, 82);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(800, 369);
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseDown);
            this.pictureBoxCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseMove);
            this.pictureBoxCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseUp);
            this.pictureBoxCanvas.Resize += new System.EventHandler(this.pictureBoxCanvas_Resize);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlPanel.Controls.Add(this.SetPenButton);
            this.ControlPanel.Controls.Add(this.SetTriangleButton);
            this.ControlPanel.Controls.Add(this.SetCircleButton);
            this.ControlPanel.Controls.Add(this.SetRectangleButton);
            this.ControlPanel.Controls.Add(this.CurrentColorBox);
            this.ControlPanel.Controls.Add(this.BlackColorButton);
            this.ControlPanel.Controls.Add(this.BlueColorButton);
            this.ControlPanel.Controls.Add(this.GreenColorButton);
            this.ControlPanel.Controls.Add(this.YellowColorButton);
            this.ControlPanel.Controls.Add(this.OrangeColorButton);
            this.ControlPanel.Controls.Add(this.WidthTrackBar);
            this.ControlPanel.Controls.Add(this.RedColorButton);
            this.ControlPanel.Location = new System.Drawing.Point(0, 27);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(800, 55);
            this.ControlPanel.TabIndex = 2;
            // 
            // SetPenButton
            // 
            this.SetPenButton.Location = new System.Drawing.Point(15, 3);
            this.SetPenButton.Name = "SetPenButton";
            this.SetPenButton.Size = new System.Drawing.Size(75, 23);
            this.SetPenButton.TabIndex = 11;
            this.SetPenButton.Text = "Pen";
            this.SetPenButton.UseVisualStyleBackColor = true;
            this.SetPenButton.Click += new System.EventHandler(this.SetPenButton_Click);
            // 
            // SetTriangleButton
            // 
            this.SetTriangleButton.Location = new System.Drawing.Point(96, 29);
            this.SetTriangleButton.Name = "SetTriangleButton";
            this.SetTriangleButton.Size = new System.Drawing.Size(75, 23);
            this.SetTriangleButton.TabIndex = 10;
            this.SetTriangleButton.Text = "Triangle";
            this.SetTriangleButton.UseVisualStyleBackColor = true;
            this.SetTriangleButton.Click += new System.EventHandler(this.SetTriangleButton_Click);
            // 
            // SetCircleButton
            // 
            this.SetCircleButton.Location = new System.Drawing.Point(96, 3);
            this.SetCircleButton.Name = "SetCircleButton";
            this.SetCircleButton.Size = new System.Drawing.Size(75, 23);
            this.SetCircleButton.TabIndex = 9;
            this.SetCircleButton.Text = "Circle";
            this.SetCircleButton.UseVisualStyleBackColor = true;
            this.SetCircleButton.Click += new System.EventHandler(this.SetCircleButton_Click);
            // 
            // SetRectangleButton
            // 
            this.SetRectangleButton.Location = new System.Drawing.Point(15, 29);
            this.SetRectangleButton.Name = "SetRectangleButton";
            this.SetRectangleButton.Size = new System.Drawing.Size(75, 23);
            this.SetRectangleButton.TabIndex = 8;
            this.SetRectangleButton.Text = "Rectangle";
            this.SetRectangleButton.UseVisualStyleBackColor = true;
            this.SetRectangleButton.Click += new System.EventHandler(this.SetRectangleButton_Click);
            // 
            // CurrentColorBox
            // 
            this.CurrentColorBox.BackColor = System.Drawing.Color.Black;
            this.CurrentColorBox.Location = new System.Drawing.Point(356, 3);
            this.CurrentColorBox.Name = "CurrentColorBox";
            this.CurrentColorBox.Size = new System.Drawing.Size(37, 34);
            this.CurrentColorBox.TabIndex = 7;
            this.CurrentColorBox.UseVisualStyleBackColor = false;
            // 
            // BlackColorButton
            // 
            this.BlackColorButton.BackColor = System.Drawing.Color.Black;
            this.BlackColorButton.Location = new System.Drawing.Point(593, 30);
            this.BlackColorButton.Name = "BlackColorButton";
            this.BlackColorButton.Size = new System.Drawing.Size(64, 22);
            this.BlackColorButton.TabIndex = 6;
            this.BlackColorButton.UseVisualStyleBackColor = false;
            this.BlackColorButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnyColorButton_MouseClick);
            // 
            // BlueColorButton
            // 
            this.BlueColorButton.BackColor = System.Drawing.Color.Blue;
            this.BlueColorButton.Location = new System.Drawing.Point(523, 30);
            this.BlueColorButton.Name = "BlueColorButton";
            this.BlueColorButton.Size = new System.Drawing.Size(64, 22);
            this.BlueColorButton.TabIndex = 5;
            this.BlueColorButton.UseVisualStyleBackColor = false;
            this.BlueColorButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnyColorButton_MouseClick);
            // 
            // GreenColorButton
            // 
            this.GreenColorButton.BackColor = System.Drawing.Color.Green;
            this.GreenColorButton.Location = new System.Drawing.Point(453, 30);
            this.GreenColorButton.Name = "GreenColorButton";
            this.GreenColorButton.Size = new System.Drawing.Size(64, 22);
            this.GreenColorButton.TabIndex = 4;
            this.GreenColorButton.UseVisualStyleBackColor = false;
            this.GreenColorButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnyColorButton_MouseClick);
            // 
            // YellowColorButton
            // 
            this.YellowColorButton.BackColor = System.Drawing.Color.Yellow;
            this.YellowColorButton.Location = new System.Drawing.Point(593, 3);
            this.YellowColorButton.Name = "YellowColorButton";
            this.YellowColorButton.Size = new System.Drawing.Size(64, 22);
            this.YellowColorButton.TabIndex = 3;
            this.YellowColorButton.UseVisualStyleBackColor = false;
            this.YellowColorButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnyColorButton_MouseClick);
            // 
            // OrangeColorButton
            // 
            this.OrangeColorButton.BackColor = System.Drawing.Color.Orange;
            this.OrangeColorButton.Location = new System.Drawing.Point(523, 3);
            this.OrangeColorButton.Name = "OrangeColorButton";
            this.OrangeColorButton.Size = new System.Drawing.Size(64, 22);
            this.OrangeColorButton.TabIndex = 2;
            this.OrangeColorButton.UseVisualStyleBackColor = false;
            this.OrangeColorButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnyColorButton_MouseClick);
            // 
            // WidthTrackBar
            // 
            this.WidthTrackBar.Location = new System.Drawing.Point(693, 3);
            this.WidthTrackBar.Maximum = 50;
            this.WidthTrackBar.Minimum = 1;
            this.WidthTrackBar.Name = "WidthTrackBar";
            this.WidthTrackBar.Size = new System.Drawing.Size(104, 45);
            this.WidthTrackBar.TabIndex = 1;
            this.WidthTrackBar.Value = 1;
            // 
            // RedColorButton
            // 
            this.RedColorButton.BackColor = System.Drawing.Color.Red;
            this.RedColorButton.Location = new System.Drawing.Point(453, 3);
            this.RedColorButton.Name = "RedColorButton";
            this.RedColorButton.Size = new System.Drawing.Size(64, 22);
            this.RedColorButton.TabIndex = 0;
            this.RedColorButton.UseVisualStyleBackColor = false;
            this.RedColorButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnyColorButton_MouseClick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.TrackBar WidthTrackBar;
        private System.Windows.Forms.Button RedColorButton;
        private System.Windows.Forms.Button CurrentColorBox;
        private System.Windows.Forms.Button BlackColorButton;
        private System.Windows.Forms.Button BlueColorButton;
        private System.Windows.Forms.Button GreenColorButton;
        private System.Windows.Forms.Button YellowColorButton;
        private System.Windows.Forms.Button OrangeColorButton;
        private System.Windows.Forms.Button SetPenButton;
        private System.Windows.Forms.Button SetTriangleButton;
        private System.Windows.Forms.Button SetCircleButton;
        private System.Windows.Forms.Button SetRectangleButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

