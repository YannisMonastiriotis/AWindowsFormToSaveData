namespace AcommonForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeTxt = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Details = new System.Windows.Forms.TabPage();
            this.Clock = new System.Windows.Forms.TabPage();
            this.clockTXT = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.startClock = new System.Windows.Forms.Button();
            this.stopClock = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Details.SuspendLayout();
            this.Clock.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(384, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1254, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "An application from the future\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 527);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(751, 26);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 84);
            this.label2.TabIndex = 5;
            this.label2.Text = "Consider the following before saving to your PC! Critical!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 56);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(409, 39);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "1. Be sure to display the message of success after saving. Otherwise there is a p" +
    "roblem. Try again ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(202, 98);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(409, 32);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "2. No error should be displayed when saving. An error means that your data is not" +
    " daved.";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(202, 133);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(409, 44);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "3. Be sure to save the information at different times. In any circumstances and a" +
    "t any time, the responsibility for the loss of information is at your own risk.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(92, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Warning: Before you change Windows and remove the program, be sure to  copy the i" +
    "nstallation folder and make a back-up.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Arial Nova Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(951, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 58);
            this.button2.TabIndex = 10;
            this.button2.Text = "Help";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Arial Nova Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1063, 505);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 60);
            this.button3.TabIndex = 11;
            this.button3.Text = "Exit";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Arial Nova Cond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(50, 514);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 51);
            this.button4.TabIndex = 12;
            this.button4.Text = "Browse";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeTxt
            // 
            this.TimeTxt.BackColor = System.Drawing.Color.LightGreen;
            this.TimeTxt.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTxt.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.TimeTxt.Location = new System.Drawing.Point(384, 301);
            this.TimeTxt.Multiline = true;
            this.TimeTxt.Name = "TimeTxt";
            this.TimeTxt.ReadOnly = true;
            this.TimeTxt.Size = new System.Drawing.Size(486, 51);
            this.TimeTxt.TabIndex = 13;
            this.TimeTxt.Text = "Hi";
            this.TimeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Details);
            this.tabControl1.Controls.Add(this.Clock);
            this.tabControl1.Location = new System.Drawing.Point(599, 576);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 246);
            this.tabControl1.TabIndex = 15;
            // 
            // Details
            // 
            this.Details.Controls.Add(this.textBox3);
            this.Details.Controls.Add(this.textBox2);
            this.Details.Controls.Add(this.textBox4);
            this.Details.Controls.Add(this.label2);
            this.Details.Controls.Add(this.label3);
            this.Details.Location = new System.Drawing.Point(4, 26);
            this.Details.Name = "Details";
            this.Details.Padding = new System.Windows.Forms.Padding(3);
            this.Details.Size = new System.Drawing.Size(617, 216);
            this.Details.TabIndex = 0;
            this.Details.Text = "Help";
            this.Details.UseVisualStyleBackColor = true;
            // 
            // Clock
            // 
            this.Clock.Controls.Add(this.stopClock);
            this.Clock.Controls.Add(this.startClock);
            this.Clock.Controls.Add(this.clockTXT);
            this.Clock.Location = new System.Drawing.Point(4, 26);
            this.Clock.Name = "Clock";
            this.Clock.Padding = new System.Windows.Forms.Padding(3);
            this.Clock.Size = new System.Drawing.Size(617, 216);
            this.Clock.TabIndex = 1;
            this.Clock.Text = "Clock";
            this.Clock.UseVisualStyleBackColor = true;
            // 
            // clockTXT
            // 
            this.clockTXT.BackColor = System.Drawing.Color.Black;
            this.clockTXT.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockTXT.ForeColor = System.Drawing.Color.Honeydew;
            this.clockTXT.Location = new System.Drawing.Point(126, 59);
            this.clockTXT.Multiline = true;
            this.clockTXT.Name = "clockTXT";
            this.clockTXT.Size = new System.Drawing.Size(334, 95);
            this.clockTXT.TabIndex = 0;
            this.clockTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // startClock
            // 
            this.startClock.Location = new System.Drawing.Point(179, 161);
            this.startClock.Name = "startClock";
            this.startClock.Size = new System.Drawing.Size(88, 36);
            this.startClock.TabIndex = 1;
            this.startClock.Text = "Start";
            this.startClock.UseVisualStyleBackColor = true;
            this.startClock.Click += new System.EventHandler(this.startClock_Click);
            // 
            // stopClock
            // 
            this.stopClock.Location = new System.Drawing.Point(304, 160);
            this.stopClock.Name = "stopClock";
            this.stopClock.Size = new System.Drawing.Size(83, 37);
            this.stopClock.TabIndex = 2;
            this.stopClock.Text = "Stop";
            this.stopClock.UseVisualStyleBackColor = true;
            this.stopClock.Click += new System.EventHandler(this.stopClock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1203, 631);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.TimeTxt);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A simple application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Details.ResumeLayout(false);
            this.Details.PerformLayout();
            this.Clock.ResumeLayout(false);
            this.Clock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TimeTxt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Details;
        private System.Windows.Forms.TabPage Clock;
        private System.Windows.Forms.TextBox clockTXT;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button stopClock;
        private System.Windows.Forms.Button startClock;
    }
}

