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

namespace D10916203
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        int times;
        private void button1_Click(object sender, EventArgs e)
        {
            string name = "";
            string op = "";
            SqlConnection Cnn = new SqlConnection("Data Source=192.192.140.111;Initial Catalog=D10916203;User ID=us;Password=takming");
            SqlCommand cmd = new SqlCommand("Select 員工姓名,權限 from 員工資料表='" + textBox1.Text + "' and 密碼='" + textBox2.Text + "'",Cnn);
            Cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                name = (string)dr.GetValue(0);
                op = (string)dr.GetValue(1);
            }
            if (name !="")
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                times++;
                if(times ==3)
                {

                }
            }
        }
    }
}
