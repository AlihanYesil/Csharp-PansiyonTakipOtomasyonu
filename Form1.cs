using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonTakipOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();

            if (txtKullaniciAd.Text == "G2125010121" && txtParola.Text == "karasumyo2022")
            {
                frm4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatali","Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
