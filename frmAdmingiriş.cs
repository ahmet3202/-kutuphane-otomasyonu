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
    public partial class frmAdmingiriş : Form
    {
        public frmAdmingiriş()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=AHMET\\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");
        private void btnGirişYap_Click(object sender, EventArgs e)
        {

            try
            {
                baglantı.Open();
                string sql = "select * from AdminGiris where kullanici=@kullaniciadi AND sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("kullaniciadi", txtKullanıcıadı.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", txtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglantı);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    frmAnaform fr = new frmAnaform();
                    fr.Show();

                }

            }
            catch (Exception)
            {

                MessageBox.Show("hatalı giriş");
            }
        }

    }
}
