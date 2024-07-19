namespace Game_of_Life
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            bStop = new Button();
            bStart = new Button();
            label4 = new Label();
            label3 = new Label();
            nudDensity = new NumericUpDown();
            label2 = new Label();
            nudResolution = new NumericUpDown();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDensity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudResolution).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(bStop);
            splitContainer1.Panel1.Controls.Add(bStart);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(nudDensity);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(nudResolution);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1055, 607);
            splitContainer1.SplitterDistance = 330;
            splitContainer1.TabIndex = 0;
            // 
            // bStop
            // 
            bStop.Location = new Point(69, 223);
            bStop.Name = "bStop";
            bStop.Size = new Size(135, 29);
            bStop.TabIndex = 7;
            bStop.Text = "STOP";
            bStop.UseVisualStyleBackColor = true;
            bStop.Click += bStop_Click;
            // 
            // bStart
            // 
            bStart.Location = new Point(69, 173);
            bStart.Name = "bStart";
            bStart.Size = new Size(135, 29);
            bStart.TabIndex = 6;
            bStart.Text = "START";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 7);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 5;
            label4.Text = "2024";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 7);
            label3.Name = "label3";
            label3.Size = new Size(190, 23);
            label3.TabIndex = 4;
            label3.Text = "powered by Yakushkin";
            // 
            // nudDensity
            // 
            nudDensity.Location = new Point(39, 128);
            nudDensity.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudDensity.Name = "nudDensity";
            nudDensity.Size = new Size(181, 30);
            nudDensity.TabIndex = 3;
            nudDensity.TextAlign = HorizontalAlignment.Right;
            nudDensity.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 105);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 2;
            label2.Text = "Density";
            // 
            // nudResolution
            // 
            nudResolution.Location = new Point(39, 72);
            nudResolution.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            nudResolution.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudResolution.Name = "nudResolution";
            nudResolution.Size = new Size(181, 30);
            nudResolution.TabIndex = 1;
            nudResolution.TextAlign = HorizontalAlignment.Right;
            nudResolution.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 49);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 0;
            label1.Text = "Resolution";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(717, 603);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 607);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudDensity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudResolution).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private NumericUpDown nudResolution;
        private Label label1;
        private Label label4;
        private Label label3;
        private NumericUpDown nudDensity;
        private Label label2;
        private Button bStop;
        private Button bStart;
        private System.Windows.Forms.Timer timer1;
    }
}
