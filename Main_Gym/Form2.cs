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
    public partial class Registeration : Form
    {
        public Registeration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_rej_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=HAMMAD;Initial Catalog=Gym;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            if (txt_name.Text != "" & txt_address.Text != "" & combo_gndr.Text != "" & txt_age.Text != "" & txt_phn.Text != "" & txt_id.Text != "" & dateTimePicker1.Text != "")
            {
                SqlCommand CmdSql = new SqlCommand("INSERT INTO [Table] (Name, Address, Gender, Age, Phone, ID, join_date) VALUES (@Name, @Address, @Gender, @Age, @Phone, @ID, @join_date)", conn);
                
                conn.Open();
                CmdSql.Parameters.AddWithValue("@Name", txt_name.Text);
                CmdSql.Parameters.AddWithValue("@Address", txt_address.Text);
                CmdSql.Parameters.AddWithValue("@Gender", combo_gndr.Text);

                //SqlDataAdapter da = new SqlDataAdapter(CmdSql);

                //if(rad_male.Checked == true)

                //{

                //CmdSql.Parameters.AddWithValue("@Gender", rad_male.Text.ToString());

                //rad_fem.Checked = false;

                //CmdSql.ExecuteNonQuery();
                //}

                //else if (rad_fem.Checked == true)

                //{

                //    CmdSql.Parameters.AddWithValue("@Gender", rad_fem.Text.ToString());

                //    rad_male.Checked = false;

                //    CmdSql.ExecuteNonQuery();

                //}

                CmdSql.Parameters.AddWithValue("@Age", txt_age.Text);
                CmdSql.Parameters.AddWithValue("@Phone", txt_phn.Text);
                CmdSql.Parameters.AddWithValue("@ID", txt_id.Text);
                CmdSql.Parameters.AddWithValue("@join_date",dateTimePicker1.Text);
                CmdSql.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registeration Sucessfull");
                
            }
            else { MessageBox.Show("Registeration UnSucessfull"); }
            
        }

        private void radiobox_Enter(object sender, EventArgs e)
        {
           
        }
        
    }
}
