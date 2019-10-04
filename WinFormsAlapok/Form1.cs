using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAlapok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox_beker.Maximum = 255;
            textBox_beker2.Maximum = 255;
            textBox_beker3.Maximum = 255;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int hex = Convert.ToInt32(textBox_beker.Value);
            int hex2 = Convert.ToInt32(textBox_beker2.Value);
            int hex3 = Convert.ToInt32(textBox_beker3.Value);
            this.BackColor = Color.FromArgb(hex,hex2,hex3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_szamol_Click(object sender, EventArgs e)
        {
            int szam1 = Convert.ToInt32(textBox_szam1.Text);
            int szam2 = Convert.ToInt32(textBox_szam2.Text);
            int ered = szam1 + szam2;
            eredmeny.Text = ered.ToString();
        }
    }
}
