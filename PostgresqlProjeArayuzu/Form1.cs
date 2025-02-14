using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgresqlProjeArayuzu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=LocalHost; port=5432; Database=proje; user ID=postgres; password=12345");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listele_buton1_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM personel";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ekle_buton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into personel(ad,soyad,telefon,meslek) values (@p1,@p2,@p3,@p4)", baglanti);
            komut1.Parameters.AddWithValue("@p1", ad_textbox1.Text);
            komut1.Parameters.AddWithValue("@p2", soyad_textbox1.Text);
            komut1.Parameters.AddWithValue("@p3", telefon_textbox1.Text);
            komut1.Parameters.AddWithValue("@p4", meslek_textbox1.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt İşlemi Başarılı Bir Şekilde Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sil_buton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from personel where ad=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", ad_textbox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı Bir Şekilde Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void guncelle_buton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("update personel set soyad=@p1,telefon=@p2,meslek=@p3 where ad=@p4", baglanti);
            
            komut2.Parameters.AddWithValue("@p1", soyad_textbox1.Text);
            komut2.Parameters.AddWithValue("@p2", telefon_textbox1.Text);
            komut2.Parameters.AddWithValue("@p3", meslek_textbox1.Text);
            komut2.Parameters.AddWithValue("@p4", ad_textbox1.Text);

            komut2.ExecuteNonQuery();

            MessageBox.Show("Güncelleme İşlemi Başarılı Bir Şekilde Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
        }

       
        private void arama_buton1_Click(object sender, EventArgs e)
        {
           

                baglanti.Open();

                string soyad = soyad_textbox1.Text;
                NpgsqlCommand komut = new NpgsqlCommand("SELECT * FROM personel_soyada_gore_ara(@p_soyad)", baglanti);
                komut.Parameters.AddWithValue("@p_soyad", soyad);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
           
        }

        private void personelsayisi_textbox1_Click(object sender, EventArgs e)
        { 
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("SELECT personel_sayisi()", baglanti);
                int toplamPersonelSayisi = Convert.ToInt32(komut.ExecuteScalar());
                personelsayisi_label1.Text = "Toplam Personel Sayısı: " + toplamPersonelSayisi;
                baglanti.Close();
        }

        private void soneklenenpersonel_button1_Click(object sender, EventArgs e)
        {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("SELECT * FROM son_eklenen_personel()", baglanti);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
          
        }

        private void meslekgruppersonel_textbox1_Click_1(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM meslek_grup_personel_sayisi()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void adlistele_button1_Click(object sender, EventArgs e)
        {
                string girilenHarf = harfgirin_textbox1.Text;
                if (string.IsNullOrWhiteSpace(girilenHarf) || girilenHarf.Length != 1)
                {
                    MessageBox.Show("Lütfen yalnızca bir harf girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string sorgu = "SELECT * FROM ad_baslayan_personel(@p_harf)";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p_harf", girilenHarf);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
        }
    }
}