using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26.Donguler_Proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saat = 0, dakika = 0, saniye = 0;               // Sayaçları globale tanımladık.

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;                                       // Uygulama başlar başlamaz timer başlaması için Enabled'ı true yaptık.
            label3.Text = saniye.ToString();                // Sonra saniye değerini birer birer arttırıp bunu label3'e yazdırdık.
            if (saniye == 60)                               // Saniye 60 olunca alttakileri uygula dedik.
            {
                dakika++;                                   // Dakikayı birer birer arttır dedik.
                label2.Text = dakika.ToString();            // Sonra dakika değerini birer birer arttırıp bunu label2'ye yazdırdık.
                saniye = 0;                                 // Her dakika artışında saniyeyi sıfırla dedik.

                if (dakika == 60)                           // Dakika 60 olunca alttakileri uygula dedik.
                {
                    saat = saat + 1;                        // Saati birer birer arttır dedik.
                    label1.Text = saat.ToString();          // Sonra saat değerini birer birer arttırıp bunu label1'e yazdırdık.
                    dakika = 0;                             // Her saat artışında dakikayı sıfırla dedik.
                }
            }

        }
    }
}
