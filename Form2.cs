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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0SBV3MD\\SQLEXPRESS;Initial Catalog=GP;Integrated Security=True");


        private void btn1_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "100";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into oda100 (ad,soyad) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into oda101 (ad,soyad) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into oda102 (ad,soyad) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into oda103 (ad,soyad) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into oda104 (ad,soyad) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into oda105 (ad,soyad) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into oda106 (ad,soyad) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into oda107 (ad,soyad) values ('"+txtAd.Text+"','"+txtSoyad.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into oda108 (ad,soyad) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

       

        private void btnD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Butonlar Dolu Odaları Gösterir");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Butonlar Boş Odaları Gösterir");

        }

        private void txtÇıkıştarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            string gun;
            DateTime GirisTarih = Convert.ToDateTime(txtGiriştarihi.Text);
            DateTime CikisTarih = Convert.ToDateTime(txtÇıkıştarihi.Text);

            TimeSpan Sonuc = CikisTarih - GirisTarih;

            gun = Sonuc.TotalDays.ToString();
            ucret=Convert.ToInt32(gun)*95;
            txtÜcret.Text = ucret.ToString();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into MusteriBilgileri (Ad,Soyad,Tc_no,Tel_no,Oda_no,Ucret,Giris_tarih,Cikis_tarih) values('"+txtAd.Text+"','"+txtSoyad.Text+ "','" + txtTcno.Text + "','" + txtTelno.Text + "','" + txtOdano.Text + "','" + txtÜcret.Text + "','" + txtGiriştarihi.Value.ToString("yyyy-MM-dd") + "','" + txtÇıkıştarihi.Value.ToString("yyyy-MM-dd") + "')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Başarılı Kayıt Edildi", "Kayıt Başarılı", MessageBoxButtons.OK);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * from oda100 ", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();


            while (oku1.Read())
            {
                btn1.Text = oku1["ad"].ToString() + " " + oku1["soyad"].ToString();
            }
            baglanti.Close();
            if (btn1.Text != "100")
            {
                btn1.BackColor = Color.Red;
                btn1.Enabled = false;

            }


            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * from oda101 ", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();


            while (oku2.Read())
            {
                btn2.Text = oku2["ad"].ToString() + " " + oku2["soyad"].ToString();
            }
            baglanti.Close();
            if (btn2.Text != "101")
            {
                btn2.BackColor = Color.Red;
                btn2.Enabled = false;

            }

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * from oda102 ", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();


            while (oku3.Read())
            {
                btn3.Text = oku3["ad"].ToString() + " " + oku3["soyad"].ToString();
            }
            baglanti.Close();
            if (btn3.Text != "102")
            {
                btn3.BackColor = Color.Red;
                btn3.Enabled = false;

            }

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * from oda103 ", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();


            while (oku4.Read())
            {
                btn4.Text = oku4["ad"].ToString() + " " + oku4["soyad"].ToString();
            }
            baglanti.Close();
            if (btn4.Text != "103")
            {
                btn4.BackColor = Color.Red;
                btn4.Enabled = false;

            }

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * from oda104 ", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();


            while (oku5.Read())
            {
                btn5.Text = oku5["ad"].ToString() + " " + oku5["soyad"].ToString();
            }
            baglanti.Close();
            if (btn5.Text != "104")
            {
                btn5.BackColor = Color.Red;
                btn5.Enabled = false;

            }

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select * from oda105 ", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();


            while (oku6.Read())
            {
                btn6.Text = oku6["ad"].ToString() + " " + oku6["soyad"].ToString();
            }
            baglanti.Close();
            if (btn6.Text != "105")
            {
                btn6.BackColor = Color.Red;
                btn6.Enabled = false;

            }



            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select * from oda106 ", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();


            while (oku7.Read())
            {
                btn7.Text = oku7["ad"].ToString() + " " + oku7["soyad"].ToString();
            }
            baglanti.Close();
            if (btn7.Text != "106")
            {
                btn7.BackColor = Color.Red;
                btn7.Enabled = false;

            }



            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("Select * from oda107 ", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();


            while (oku8.Read())
            {
                btn8.Text = oku8["ad"].ToString() + " " + oku8["soyad"].ToString();
            }
            baglanti.Close();
            if (btn8.Text != "107")
            {
                btn8.BackColor = Color.Red;
                btn8.Enabled = false;
            }


            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("Select * from oda108 ", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();


            while (oku9.Read())
            {
                btn9.Text = oku9["ad"].ToString() + " " + oku9["soyad"].ToString();
            }
            baglanti.Close();
            if (btn9.Text != "108")
            {
                btn9.BackColor = Color.Red;
                btn9.Enabled = false;

            }
        }
    }
}
