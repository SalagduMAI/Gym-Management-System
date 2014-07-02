using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Gym
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=HAMMAD;Initial Catalog=Gym;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            string commandString = "Select Name, Address, Gender, Age, Phone, join_date from [Table] where ID='" + txt_id.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
            SqlDataReader read = sqlCmd.ExecuteReader();

            if (txt_id.Text == "")
            {
                MessageBox.Show("Enter a ID Please");
            }
            //else if (txt_id.Text != "@ID") 
            //{
            //    MessageBox.Show("Enter Correct ID Please");
            //}

            else 
            {
                while (read.Read())
                {
                    txt_name.Text = read["Name"].ToString(); 
                    txt_address.Text = read["Address"].ToString();
                    txt_gender.Text = read["Gender"].ToString();
                    txt_age.Text = read["Age"].ToString();
                    txt_phn.Text = read["Phone"].ToString();
                    DateTime d = DateTime.Now;
                    
                    txt_joining.Text = d.ToShortDateString(); 
                    txt_joining.Text = read["join_date"].ToString();

                }
 
            }

            sqlCon.Close();
        }

       
    }
}
