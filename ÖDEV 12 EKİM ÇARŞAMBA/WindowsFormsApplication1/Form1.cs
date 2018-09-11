using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int kod = int.Parse(textBox1.Text);

            switch (kod)
            {
                case 1:
                    textBox2.Text = "PC"; break;
                case 2:
                    textBox2.Text = "NETBOOK"; break;
                case 3:
                    textBox2.Text = "NOTEBOOK"; break;
                case 4:
                    textBox2.Text = "PDA"; break;
                default:
                    MessageBox.Show("Hatalı Tuşa Bastınız"); break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = int.Parse(textBox1.Text);
            int pcn,pck,netn,netk,notn,notk,pdan,pdak;
            if (kod == 1)
            { pcn = (500 / 100) * 95; textBox3.Text = (pcn.ToString()); pck = (500 / 100) * 115; textBox4.Text = (pck.ToString()); }
            else if (kod == 2)
            { netn = (700 / 100) * 95; textBox3.Text = (netn.ToString()); netk = (700 / 100) * 115; textBox4.Text = (netk.ToString()); }
            else if (kod == 3)
            { notn = (1200 / 100) * 95; textBox3.Text = (notn.ToString()); notk = (1200 / 100) * 115; textBox4.Text = (notk.ToString()); }
            else if (kod == 4)
            { pdan = (2000 / 100) * 95; textBox3.Text = (pdan.ToString()); pdak = (2000 / 100) * 115; textBox4.Text = (pdak.ToString()); }
        }
    }
}
