using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ay_Çiçeği_pansiyon
{
    public partial class frmAnaform : Form
    {
      
        public frmAnaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             fr = new frmYeniMusteri();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmYeniMusteri fr = new frmYeniMusteri();
            fr.Show();
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMusteriler fr = new frmMusteriler();
            fr.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmOdalar fr = new frmOdalar();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bu bir öğrenci yapımıdır ahmet soylu 2018287047");
        }

        private void frmAnaform_Load(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string Data { get; set; }
    }
}
