namespace CAMERAPROJECT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.START = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RESET = new System.Windows.Forms.Button();
            this.PAUSE = new System.Windows.Forms.Button();
            this.CAPTURE = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SAVE = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imgCapture = new System.Windows.Forms.PictureBox();
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(12, 30);
            this.START.Margin = new System.Windows.Forms.Padding(4);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(144, 28);
            this.START.TabIndex = 0;
            this.START.Text = "START CAMERA";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 30);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 33);
            this.comboBox1.TabIndex = 1;
            // 
            // RESET
            // 
            this.RESET.Location = new System.Drawing.Point(498, 30);
            this.RESET.Margin = new System.Windows.Forms.Padding(4);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(151, 28);
            this.RESET.TabIndex = 2;
            this.RESET.Text = "RESET CAMERA";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // PAUSE
            // 
            this.PAUSE.Location = new System.Drawing.Point(685, 30);
            this.PAUSE.Margin = new System.Windows.Forms.Padding(4);
            this.PAUSE.Name = "PAUSE";
            this.PAUSE.Size = new System.Drawing.Size(100, 28);
            this.PAUSE.TabIndex = 3;
            this.PAUSE.Text = "PAUSE";
            this.PAUSE.UseVisualStyleBackColor = true;
            this.PAUSE.Click += new System.EventHandler(this.PAUSE_Click);
            // 
            // CAPTURE
            // 
            this.CAPTURE.Location = new System.Drawing.Point(819, 30);
            this.CAPTURE.Margin = new System.Windows.Forms.Padding(4);
            this.CAPTURE.Name = "CAPTURE";
            this.CAPTURE.Size = new System.Drawing.Size(100, 28);
            this.CAPTURE.TabIndex = 4;
            this.CAPTURE.Text = "CAPTURE";
            this.CAPTURE.UseVisualStyleBackColor = true;
            this.CAPTURE.Click += new System.EventHandler(this.CAPTURE_Click);
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(1084, 30);
            this.EXIT.Margin = new System.Windows.Forms.Padding(4);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(100, 28);
            this.EXIT.TabIndex = 5;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SAVE);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.EXIT);
            this.panel1.Controls.Add(this.START);
            this.panel1.Controls.Add(this.CAPTURE);
            this.panel1.Controls.Add(this.RESET);
            this.panel1.Controls.Add(this.PAUSE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 77);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(961, 30);
            this.SAVE.Margin = new System.Windows.Forms.Padding(4);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(100, 28);
            this.SAVE.TabIndex = 6;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.imgCapture);
            this.panel2.Controls.Add(this.imgVideo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1191, 574);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 516);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1191, 58);
            this.panel3.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // imgCapture
            // 
            this.imgCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCapture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgCapture.Location = new System.Drawing.Point(469, 25);
            this.imgCapture.Margin = new System.Windows.Forms.Padding(4);
            this.imgCapture.Name = "imgCapture";
            this.imgCapture.Size = new System.Drawing.Size(363, 455);
            this.imgCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCapture.TabIndex = 16;
            this.imgCapture.TabStop = false;
            // 
            // imgVideo
            // 
            this.imgVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgVideo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgVideo.Location = new System.Drawing.Point(40, 25);
            this.imgVideo.Margin = new System.Windows.Forms.Padding(4);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(363, 455);
            this.imgVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVideo.TabIndex = 15;
            this.imgVideo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 651);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "                                                                                 " +
    "                                               AForge Usage for Camera and  how " +
    "to capture at C#";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button START;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.Button PAUSE;
        private System.Windows.Forms.Button CAPTURE;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imgCapture;
        private System.Windows.Forms.PictureBox imgVideo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SAVE;
    }
}

