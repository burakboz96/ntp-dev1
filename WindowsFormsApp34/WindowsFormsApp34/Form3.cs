using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source =LAPTOP-RQ4LQB94\SQLEXPRESS; Initial Catalog=login_arayüz;Integrated Security=True");
        private  void veriler()
        {


            SqlCommand komut = new SqlCommand("update parola" +Text.ToString() + "where parola");
            baglanti.Close();



        }
        private void button2_Click(object sender, EventArgs e)
        {

        baglanti.Open();

         SqlCommand komut = new SqlCommand("update");
      
         


        }
    }
}
