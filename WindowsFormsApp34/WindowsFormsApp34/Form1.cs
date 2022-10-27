﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
SqlConnection baglanti = new SqlConnection(@"Data Source =LAPTOP-RQ4LQB94\SQLEXPRESS; Initial Catalog=login_arayüz;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select * From sifre where kullanıcı_adı =@adi AND sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("adi", textBox1.Text.Trim()); 
                SqlParameter prm2 = new SqlParameter("sifresi",textBox2.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2); 
                DataTable dt= new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
              
              if (dt.Rows.Count > 0)
                {

                    Form2 fr = new Form2();
                    fr.Show();


                }

            }
            catch (Exception)
            {

                MessageBox.Show("HATALI KULLANICI ADI VEYA ŞİFRE GİRDİNİZ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
