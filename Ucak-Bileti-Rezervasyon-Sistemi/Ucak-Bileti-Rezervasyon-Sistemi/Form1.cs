using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07.Proje___Uçak_Bileti_Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text + " / Tarih: " +dateTimePicker1.Text + " / Saat: " +maskedTextBox1.Text + " ///// Yolcu Bilgileri ~~ Ad: " + textBox1.Text + " / TC No: " +maskedTextBox2.Text + " / Telefon: "+maskedTextBox3.Text);
            MessageBox.Show("Rezervasyon Başarılı! ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;        //Burada köprü yapmış olduk
            comboBox2.Text = comboBox1.Text;     //label9 köprüde kullanılan ek eleman oldu
            comboBox1.Text = label9.Text;        //Fazlalık değer label9'a atandı diyebiliriz. label9 buradaki aracımız.
        }
    }
}
