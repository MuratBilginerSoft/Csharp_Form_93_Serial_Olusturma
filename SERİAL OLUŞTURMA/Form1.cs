using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SERİAL_OLUŞTURMA
{
    public partial class Form1 : Form
    {
        Random r = new Random();

        private void kaydet()
        {
            string dosya = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Serial.accdb";
            OleDbConnection baglanti = new OleDbConnection(dosya);
            string l = "";
            for (int i = 0; i < 20; i++)
            {
                int k = r.Next(0, 10);
                l = l + k.ToString();
            }
            listBox1.Items.Add(l);
            OleDbCommand kaydet = new OleDbCommand("insert into Serial(Seriall) values ('" + l + "' )", baglanti);
            baglanti.Open();
            kaydet.ExecuteNonQuery();
            baglanti.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 400; i++)
            {
                kaydet();
            }
           
        }
    }
}
