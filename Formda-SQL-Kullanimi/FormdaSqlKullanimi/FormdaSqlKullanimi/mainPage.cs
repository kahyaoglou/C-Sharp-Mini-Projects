using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FormdaSqlKullanimi
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3DO8R5T;Initial Catalog=kitaplik;Integrated Security=True");
        
        private void btnVerileriGoster_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Kisiler", baglanti);
            //DataAdapter, DataSet ile form ekranı arasındaki köprüdür.

            DataSet ds = new DataSet(); //Sanal tablo nesnesi oluşturduk.
            da.Fill(ds); //Adapteri, dataset ile doldur.
            dataGridView1.DataSource = ds.Tables[0];
            //DataGridView'in kaynağı dataset olsun.
        }

        private void btnVerileriKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kayitekle = new SqlCommand
            ("insert into Kisiler (KisiNo, Ad, Soyad, Meslek, Sehir, Maas) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);

            kayitekle.Parameters.AddWithValue("@p1", textBox1.Text);
            kayitekle.Parameters.AddWithValue("@p2", textBox2.Text);
            kayitekle.Parameters.AddWithValue("@p3", textBox3.Text);
            kayitekle.Parameters.AddWithValue("@p4", textBox4.Text);
            kayitekle.Parameters.AddWithValue("@p5", textBox5.Text);
            kayitekle.Parameters.AddWithValue("@p6", textBox6.Text);

            kayitekle.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnVerileriSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kayitsil = new SqlCommand("delete from Kisiler where Ad = @adi", baglanti);
            kayitsil.Parameters.AddWithValue("@adi", textBox2.Text);
            kayitsil.ExecuteNonQuery();
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            //Eşitliğin sağ tarafı, biz neyi seçersek o verinin olduğu satırı geçici hafızaya alacak.
            string KisiNo = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string Ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string Soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            string Meslek = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            string Sehir = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            string Maas = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            //Seçtiğim verinin bulunduğu satırdaki 1,2,3,4,5,6. hücreyi seç.

            textBox1.Text = KisiNo;
            textBox2.Text = Ad;
            textBox3.Text = Soyad;
            textBox4.Text = Meslek;
            textBox5.Text = Sehir;
            textBox6.Text = Maas;
            //Seçtiğim hücreleri textboxlara ata.
        }

        private void btnVerileriGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kayitguncelle = new SqlCommand
                ("update Kisiler set KisiNo=@p1, Ad=@p2, Soyad=@p3, Meslek=@p4, Sehir=@p5, Maas=@p6 where KisiNo = @p1", baglanti);
            kayitguncelle.Parameters.AddWithValue("@p1", textBox1.Text);
            kayitguncelle.Parameters.AddWithValue("@p2", textBox2.Text);
            kayitguncelle.Parameters.AddWithValue("@p3", textBox3.Text);
            kayitguncelle.Parameters.AddWithValue("@p4", textBox4.Text);
            kayitguncelle.Parameters.AddWithValue("@p5", textBox5.Text);
            kayitguncelle.Parameters.AddWithValue("@p6", textBox6.Text);

            kayitguncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            btnVerileriSil.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnVerileriKaydet.Enabled = true;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnVerileriGuncelle.Enabled = true;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kisiler WHERE Ad = '" + textBox7.Text + "'", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnEnYuksekMaas_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //Bağlantıyı açtık.
            SqlCommand komut = new SqlCommand
            ("SELECT max(Maas) FROM kisiler", baglanti); //Command ile istenilen aramayı yaptık.
            SqlDataReader oku = komut.ExecuteReader(); //DataReader bulduğumuz veriyi okudu.
            while (oku.Read()) //DataReader nesnesi okunduğunda
            {
                label7.Text = oku[0].ToString(); //Bu eşitlemeyi yap.
                //Tek bir veri tuttuğu için index 0 olarak girildi.
            }
            baglanti.Close();
        }

        private void btnToplamKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //Bağlantıyı açtık.
            SqlCommand komut = new SqlCommand
            ("SELECT Count(Ad) FROM kisiler", baglanti); //Command ile istenilen aramayı yaptık.
            SqlDataReader oku = komut.ExecuteReader(); //DataReader bulduğumuz veriyi okudu.
            while (oku.Read()) //DataReader nesnesi okunduğunda
            {
                label8.Text = oku[0].ToString(); //Bu eşitlemeyi yap.
                //Tek bir veri tuttuğu için index 0 olarak girildi.
            }
            baglanti.Close();
        }

        private void btnMaaslarToplami_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand
            ("SELECT SUM(Maas) FROM kisiler", baglanti);

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label9.Text = oku[0].ToString();
            }
            baglanti.Close();
        }

        private void btnOrtalamaMaas_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand
            ("SELECT AVG(Maas) FROM kisiler", baglanti);

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label10.Text = oku[0].ToString();
            }
            baglanti.Close();
        }
    }
}
