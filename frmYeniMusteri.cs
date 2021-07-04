using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Ay_Çiçeği_pansiyon
{
    public partial class frmYeniMusteri : Form
    {
        public frmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=AHMET\\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");
        private void frmYeniMusteri_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglantı);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                btnOda101.Text = oku1["Adi"].ToString() + oku1["Soyadi"].ToString();
            }
            baglantı.Close();
            if (btnOda101.Text != "101")
            {
                btnOda101.BackColor = Color.Red;
                btnOda101.Enabled = false;
            }
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglantı);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                btnOda102.Text = oku2["Adi"].ToString() + oku2["Soyadi"].ToString();
            }
            baglantı.Close();
            if (btnOda102.Text != "102")
            {
                btnOda102.BackColor = Color.Red;
                btnOda102.Enabled = false;
            }


            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglantı);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                btnOda103.Text = oku3["Adi"].ToString() + oku3["Soyadi"].ToString();
            }
            baglantı.Close();
            if (btnOda103.Text != "103")
            {
                btnOda103.BackColor = Color.Red;
                btnOda103.Enabled = false;
            }


            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglantı);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                btnOda104.Text = oku4["Adi"].ToString() + oku4["Soyadi"].ToString();
            }
            baglantı.Close();
            if (btnOda104.Text != "104")
            {
                btnOda104.BackColor = Color.Red;
                btnOda104.Enabled = false;
            }

            baglantı.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglantı);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                btnOda105.Text = oku5["Adi"].ToString() + oku5["Soyadi"].ToString();
            }
            baglantı.Close();
            if (btnOda105.Text != "105")
            {
                btnOda105.BackColor = Color.Red;
                btnOda105.Enabled = false;
            }

            baglantı.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglantı);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                btnOda106.Text = oku6["Adi"].ToString() + oku6["Soyadi"].ToString();
            }
            baglantı.Close();
            if (btnOda106.Text != "106")
            {
                btnOda106.BackColor = Color.Red;
                btnOda106.Enabled = false;
            }

            baglantı.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglantı);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                btnOda107.Text = oku7["Adi"].ToString() + oku7["Soyadi"].ToString();
          
            }
            baglantı.Close();
            if (btnOda107.Text != "107")
            {
                btnOda107.BackColor = Color.Red;
                btnOda107.Enabled = false;
            }


            baglantı.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", baglantı);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                btnOda108.Text = oku8["Adi"].ToString() + oku8["Soyadi"].ToString();
          
            }
            baglantı.Close();
            if (btnOda108.Text != "108")
            {
                btnOda108.BackColor = Color.Red;
                btnOda108.Enabled = false;
            }

            baglantı.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", baglantı);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                btnOda109.Text = oku9["Adi"].ToString() + oku9["Soyadi"].ToString();
            }
            baglantı.Close();
            if (btnOda109.Text != "109")
            {
                btnOda109.BackColor = Color.Red;
                btnOda109.Enabled = false;
            }
            else
            {
                btnOda109.BackColor = Color.Green;
                btnOda109.Enabled = false;
            }
      
        
        
        
        
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtodano.Text = "101";
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtodano.Text = "102";
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtodano.Text = "103";
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtodano.Text = "104";
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtodano.Text = "105";
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtodano.Text = "106";
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtodano.Text = "107";
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtodano.Text = "108";
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtodano.Text = "109";
        }

        private void btnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");
        }

        private void BtnBoşOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("gri Renkli Butonlar boş Odaları Gösterir");
        }

        private void dtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucuktarih = Convert.ToDateTime(dtpGirisTarihi.Text);
            DateTime buyuktarih = Convert.ToDateTime(dtpcıkısTarihi.Text);
            TimeSpan sonuc;
            sonuc = kucuktarih - buyuktarih ;

                label11.Text = sonuc.TotalDays.ToString();
                ucret = Convert.ToInt32(label11.Text)*50;
                txtucret.Text = ucret.ToString();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut=new SqlCommand("insert into Musteriekle (Adi,Soyadi,Cinsiyet,Telefon,Mail,Tc,Odano,Ucret,GirisTarihi,CikisTarihi) values ('"+txtAdi.Text+"','"+Txtsoyadi.Text+"','"+comboBox1.Text+"','"+msktxtTelefon.Text+"','"+txtMail.Text+"','"+Txttc.Text+"','"+txtodano.Text+"','"+txtucret.Text+"','"+dtpGirisTarihi.Value.ToString("yyyy-MM-dd")+"','"+dtpcıkısTarihi.Value.ToString("yyyy-MM-dd")+"')",baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("kayıt başarılı");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}


//Data Source=AHMET\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True




//("insert into musteriekle(Adi,Soyadi)")