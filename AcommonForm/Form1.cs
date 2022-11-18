using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcommonForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit the app?", "Warning", MessageBoxButtons.YesNo);
            
            if(result == DialogResult.Yes)
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            this.AutoScaleMode = AutoScaleMode.Font;

        }

        private void transparentBackgroundTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.TimeTxt.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.clockTXT.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }
        public class TransparentBackgroundTextBox : TextBox
        {
            public TransparentBackgroundTextBox()
            {

                SetStyle(ControlStyles.SupportsTransparentBackColor |
                         ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.ResizeRedraw |
                         ControlStyles.UserPaint, true);
                BackColor = Color.Transparent;
                ForeColor = Color.MediumTurquoise;
                BorderStyle = BorderStyle.None;
            }

            public sealed override Color BackColor
            {
                get => base.BackColor;
                set => base.BackColor = value;
            }
        }

        private void startClock_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void stopClock_Click(object sender, EventArgs e)
        {
           

            timer2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ScrollControlIntoView(tabControl1);
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = textBox1.Text.Trim();
            this.process1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fileDialog.FileName;
            }
        }
    }
}
