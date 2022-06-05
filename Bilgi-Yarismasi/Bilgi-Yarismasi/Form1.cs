using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20.Karar_Yapilari_Proje4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0; //Bu değişkenleri globale atadık. Alttaki toolbox tetiklemelerine atasaydık mantık hatası olurdu.

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true; // önce bu tuşlar kullanılır olsun
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;  // Sonraki tuşu, ona basıldıktan sonra pasif olmalı. Bu durumda şıklar seçildikten sonra aktif olsun.
            pictureBox1.Visible = false; // Yanlış veya doğru resimleri şıklar seçilmeden önce
            pictureBox2.Visible = false; //kapalı olsun

            soruno++; // Her sonraki tuşuna bastığımızda soruno değeri artsın
            LblSoruno.Text = soruno.ToString(); // Ve bu değeri yazdıralım.

            if (soruno == 1) // soruno artıp 1 olduysa
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923"; //Bunu köprü görevinde kullandık. Doğru şık label4'te. Doğru şık seçiminde görev alacak.
            }
          if (soruno == 2)
            {
                richTextBox1.Text = "Hangi il Ege bölgemizde bulunmaz?";
                BtnA.Text = "İzmir";
                BtnB.Text = "Balıkesir";
                BtnC.Text = "Aydın";
                BtnD.Text = "Manisa";
                label4.Text = "Balıkesir";
            }
          if(soruno == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreyya";
                BtnC.Text = "Atilla İlhan";
                BtnD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                BtnSonraki.Text = "Sonuçlar";
            }
          if(soruno == 4)
            {
                BtnA.Enabled = false; // bütün şıkları kapa
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false; //Sonraki tuşunu kapa
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis); //İstatistikleri göster
            }

        }
        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false; // Bu şık seçildiğinde diğer şıklar seçilmesin.
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true; // Sadece sonraki tuşu seçilebilir olsun.

            label5.Text = BtnA.Text;        // Bu şıktaki texti köprü labela atadık.
            if (label4.Text == label5.Text) // Eğer doğru labeli ile aynıysa alttaki görevleri uygula.
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else //Değilse bunu uygula.
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
