using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19.Karar_Yapilari_Proje3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, toplam, fark, carpma, mod;
            double bolme;
            string sembol;

            sembol = textBox3.Text;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);

            toplam = s1 + s2;
            fark = s1 - s2;
            carpma = s1 * s2;
            bolme = s1 / s2;
            mod = s1 % s2;

            switch(sembol)
            {
                case "+": textBox4.Text = toplam.ToString();
                    break;
                case "-": textBox4.Text = fark.ToString();
                    break;
                case "*": textBox4.Text = carpma.ToString();
                    break;
                case "/": textBox4.Text = bolme.ToString("0.00");
                    break;
                case "%": textBox4.Text = mod.ToString();
                    break;
                default: textBox4.Text = "Hatalı Bir Seçim Yaptınız!";
                    break;

            }
        }
    }
}
