using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajadeseccion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily, 12,
            this.label1.Font.Style);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontFamily mss = new FontFamily("Microsoft Sans Serif");
            this.label1.Font = new Font(mss, 12, FontStyle.Regular);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FontFamily csl = new FontFamily("FORTE");
            this.label1.Font = new Font(csl, this.label1.Font.Size,
            this.label1.Font.Style);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
            this.label1.Font.Size, this.label1.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
            this.label1.Font.Size, this.label1.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
            this.label1.Font.Size, this.label1.Font.Style ^ FontStyle.Bold);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
            this.label1.Font.Size, this.label1.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            FontFamily csl = new FontFamily("Microsoft Himalaya");
            this.label1.Font = new Font(csl, this.label1.Font.Size,
            this.label1.Font.Style);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            FontFamily csl = new FontFamily("VERDANA");
            this.label1.Font = new Font(csl, this.label1.Font.Size,
            this.label1.Font.Style);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            FontFamily csl = new FontFamily("Bradley Hand ITC");
            this.label1.Font = new Font(csl, this.label1.Font.Size,
            this.label1.Font.Style);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily, 8,
            this.label1.Font.Style);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily, 16,
            this.label1.Font.Style);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily, 20,
            this.label1.Font.Style);
        }

        private void checkBox5_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
            this.label1.Font.Size, this.label1.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox7_CheckStateChanged(object sender, EventArgs e)
        {

        }
    }
}
