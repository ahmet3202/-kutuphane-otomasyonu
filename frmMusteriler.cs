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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=AHMET\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");
        private void ahmetsoylu()
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from Musteriekle", baglantı);
           SqlDataReader oku = komut.ExecuteReader();
           while (oku.Read())
           {
               listView1.Items.Clear();
               ListViewItem ekle = new ListViewItem();
               ekle.Text = oku["Musteriid"].ToString();
               ekle.SubItems.Add(oku["Adi"].ToString());
               ekle.SubItems.Add(oku["Soyadi"].ToString());
               ekle.SubItems.Add(oku["Cinsiyet"].ToString());
               ekle.SubItems.Add(oku["Telefon"].ToString());
               ekle.SubItems.Add(oku["Mail"].ToString());
               ekle.SubItems.Add(oku["Tc"].ToString());
               ekle.SubItems.Add(oku["Odano"].ToString());
               ekle.SubItems.Add(oku["Ucret"].ToString());
               ekle.SubItems.Add(oku["GirisTarihi"].ToString());
               ekle.SubItems.Add(oku["CikisTarihi"].ToString());

               listView1.Items.Add(ekle);
           
           }


           baglantı.Close();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ahmetsoylu();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text=listView1.SelectedItems[0].SubItems[1].Text;
            Txtsoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            msktxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
           Txttc.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtodano.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtucret.Text= listView1.SelectedItems[0].SubItems[8].Text;
           dtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpcıkısTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete From Musteriekle where Musteriid = (" + id + ")", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            ahmetsoylu();
        
        
        
        
        
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            Txtsoyadi.Clear();
            comboBox1.Text = "";
            msktxtTelefon.Clear();
            txtMail.Text = "";
            Txttc.Text = "";
            txtodano.Clear();
            txtucret.Clear();
            dtpcıkısTarihi.Text = "";
            dtpGirisTarihi.Text = "";

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update Musteriekle set Adi='"+txtAdi.Text+"',Soyadi='"+Txtsoyadi.Text+"',Cinsiyet='"+comboBox1.Text+"',Telefon='"+msktxtTelefon.Text+"',Mail='"+txtMail.Text+"',Tc='"+Txttc.Text+"',Odano='"+txtodano.Text+"',Ucret='"+txtucret.Text+"',GirisTarihi='"+dtpGirisTarihi.Value.ToString("yyyy-MM-dd")+"',CikisTarihi='"+dtpcıkısTarihi.Value.ToString("yyyy-MM-dd")+"' where Musteriid="+id+"",baglantı);
            komut.ExecuteNonQuery();
          baglantı.Close();
          ahmetsoylu();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from Musteriekle where Adi like'%"+textBox1.Text+"%'", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
             ListViewItem ekle = new ListViewItem();
               ekle.Text = oku["Musteriid"].ToString();
               ekle.SubItems.Add(oku["Adi"].ToString());
               ekle.SubItems.Add(oku["Soyadi"].ToString());
               ekle.SubItems.Add(oku["Cinsiyet"].ToString());
               ekle.SubItems.Add(oku["Telefon"].ToString());
               ekle.SubItems.Add(oku["Mail"].ToString());
               ekle.SubItems.Add(oku["Tc"].ToString());
               ekle.SubItems.Add(oku["Odano"].ToString());
               ekle.SubItems.Add(oku["Ucret"].ToString());
               ekle.SubItems.Add(oku["GirisTarihi"].ToString());
               ekle.SubItems.Add(oku["CikisTarihi"].ToString());

               listView1.Items.Add(ekle);
           
           }


           baglantı.Close();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {

        }
   
 

       // Text+"',CikisTarihi='"+dtpcıkısTarihi.Text+"',+'"where Musteriid="+id+"",);


    }
}


