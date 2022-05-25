using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PansiyonTakipOtomasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0SBV3MD\SQLEXPRESS;Initial Catalog=GP;Integrated Security=True");

        private void BilgileriGöster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriBilgileri",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriId"].ToString();

                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Tc_no"].ToString());
                ekle.SubItems.Add(oku["Tel_no"].ToString());
                ekle.SubItems.Add(oku["Oda_no"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["Giris_tarih"].ToString());
                ekle.SubItems.Add(oku["Cikis_tarih"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            BilgileriGöster();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            BilgileriGöster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtTcno.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtTelno.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtOdano.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtÜcret.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtGiriştarihi.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtÇıkıştarihi.Text = listView1.SelectedItems[0].SubItems[8].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriBilgileri where MusteriId=("+id+")",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            BilgileriGöster();
            txtAd.Clear();
            txtSoyad.Clear();
            txtTcno.Clear();
            txtTelno.Clear();
            txtOdano.Clear();
            txtÜcret.Clear();
            txtGiriştarihi.Text="";
            txtÇıkıştarihi.Text="";
            MessageBox.Show("Müşteri Başarı ile Silindi", "Müşteri Silme", MessageBoxButtons.OK);

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriBilgileri set Ad='"+txtAd.Text+"',Soyad='"+txtSoyad.Text+ "',Tc_no='" + txtTcno.Text + "',Tel_no='" + txtTelno.Text + "',Oda_no='" + txtOdano.Text + "',Ucret='" + txtÜcret.Text + "',Giris_tarih='" + txtGiriştarihi.Value.ToString("yyyy-MM-dd") + "',Cikis_tarih='" + txtÇıkıştarihi.Value.ToString("yyyy-MM-dd") + "' where MusteriId="+id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            BilgileriGöster();
            MessageBox.Show("Müşteri Başarı ile Güncellendi", "Müşteri Güncelleme", MessageBoxButtons.OK);

        }
    }
}
