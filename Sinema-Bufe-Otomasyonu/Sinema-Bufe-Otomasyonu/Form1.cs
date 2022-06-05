using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14.Proje___Sinema_Büfe_Satış_Uygulaması
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        int kasatutar = 0; /* Bunu yapmamızın sebebi alttaki başvuru içinde bu değerin
                            * sabit kalmaması, altta her değer eklendiğiinde, üstteki bu
                            * değerin artması için yapıyoruz. Algoritmik bir mantık. */

        private void button1_Click(object sender, EventArgs e) // Hesapla Butonu
        {
            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt16(TxtMisir.Text); // Bu text isimlerini özellikler,
            bilet = Convert.ToInt16(TxtBilet.Text); // name sekmesinden biz verdik.
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(TxtCay.Text);

            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            LblToplam.Text = toplam.ToString() + "TL";

            kasatutar = kasatutar + toplam;        // Sayaç mantığı;
            LblKasa.Text = kasatutar.ToString() + "TL";

        }

        private void button2_Click(object sender, EventArgs e) // Temizle Butonu
        {
            TxtBilet.Text = ""; // Burada her butona basışta ekrana hiçbir şey 'yazdırması'
            TxtCay.Text = "";   // için sadece çift tırnak bırakıyoruz.
            TxtMisir.Text = "";
            TxtSu.Text = "";
            TxtMisir.Focus();   // Her bastığımızda, imleci tekrar TxtMisir'a odaklasın.
                                // Yani Her bastığımızda bu TextBox değerleri sıfırlansın.
        }
    }
}
