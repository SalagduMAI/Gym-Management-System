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

namespace Main_Gym
{
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void btn_fee_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=HAMMAD;Initial Catalog=Gym;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            string month = comboBox_fee.Text;

            switch (comboBox_fee.Text) 
            {
                case "January":
                    {

                        SqlCommand CmdSql = new SqlCommand("UPDATE [Table] set january='" + comb_day.Text + " " + comboBox_fee.Text + " " + comb_year.Text + "' WHERE Id='" + txt_feeid.Text + "'", conn);

                        conn.Open();
                        CmdSql.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(" Fees paid ", month, MessageBoxButtons.OK);
                        break;
                    }
                case "February":
                    {
                        SqlCommand CmdSql = new SqlCommand("UPDATE [Table] set feburary='" + comb_day.Text + " " + comboBox_fee.Text + " " + comb_year.Text + "' WHERE Id='" + txt_feeid.Text + "'", conn);
                        conn.Open();
                        CmdSql.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(" Fees paid ", month, MessageBoxButtons.OK);
                        break;
                    }

                case "March":
                    {
                        SqlCommand CmdSql = new SqlCommand("UPDATE [Table] set march='" + comb_day.Text + " " + comboBox_fee.Text + " " + comb_year.Text + "' WHERE Id='" + txt_feeid.Text + "'", conn);
                        conn.Open();
                        CmdSql.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(" Fees paid ", month, MessageBoxButtons.OK);
                        break;
                    }

                case "April":
                    {
                        SqlCommand CmdSql = new SqlCommand("UPDATE [Table] set april='" + comb_day.Text + " " + comboBox_fee.Text + " " + comb_year.Text + "' WHERE Id='" + txt_feeid.Text + "'", conn);
                        conn.Open();
                        CmdSql.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(" Fees paid ", month, MessageBoxButtons.OK);
                        break;
                    }

                case "May":
                    {
                        SqlCommand CmdSql = new SqlCommand("UPDATE [Table] set may='" + comb_day.Text + " " + comboBox_fee.Text + " " + comb_year.Text + "' WHERE Id='" + txt_feeid.Text + "'", conn);
                        conn.Open();
                        CmdSql.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(" Fees paid ", month, MessageBoxButtons.OK);
                        break;
                    }
                case "June":
                    {
                        SqlCommand CmdSql = new SqlCommand("UPDATE [Table] set june='" + comb_day.Text + " " + comboBox_fee.Text + " " + comb_year.Text + "' WHERE Id='" + txt_feeid.Text + "'", conn);
                        conn.Open();
                        CmdSql.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(" Fees paid ",month, MessageBoxButtons.OK);
                        break;
                    }

                case "July":
                    {
                        SqlCommand CmdSql = new SqlCommand("UPDATE [Table] set july='" + comb_day.Text + " " + comboBox_fee.Text + " " + comb_year.Text + "' WHERE Id='" + txt_feeid.Text + "'", conn);
                        conn.Open();
                        CmdSql.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(" Fees paid ", month, MessageBoxButtons.OK);

                        break;
                    }

                case "August":
                    {
                        SqlCommand CmdSql = new SqlCommand("UPDATE [Table] set august='" + comb_day.Text + " " + comboBox_fee.Text + " " + comb_year.Text + "' WHERE Id='" + txt_feeid.Text + "'", conn);
                        conn.Open();
                        CmdSql.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(" Fees paid ", month, MessageBoxButtons.OK);
                        break;
                    }

                case "September":
                    {
                        SqlCommand CmdSql = new SqlCommand("UPDATE [Table] set september='" + comb_day.Text + " " + comboBox_fee.Text + " " + comb_year.Text + "' WHERE Id='" + txt_feeid.Text + "'", conn);
                        conn.Open();
                        CmdSql.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(" Fees paid ", month, MessageBoxButtons.OK);
                        break;
                    }

                case "October":
                    {
                        SqlCommand CmdSql = new SqlCommand("UPDATE [Table] set october='" + comb_day.Text + " " + comboBox_fee.Text + " " + comb_year.Text + "' WHERE Id='" + txt_feeid.Text + "'", conn);
                        conn.Open();
                        CmdSql.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(" Fees paid ", month, MessageBoxButtons.OK);
                        break;
                    }

                case "November":
                    {
                        SqlCommand CmdSql = new SqlCommand("UPDATE [Table] set november='" + comb_day.Text + " " + comboBox_fee.Text + " " + comb_year.Text + "' WHERE Id='" + txt_feeid.Text + "'", conn);
                        conn.Open();
                        CmdSql.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(" Fees paid ", month, MessageBoxButtons.OK);
                        break;
                    }

                case "December":
                    {
                        SqlCommand CmdSql = new SqlCommand("UPDATE [Table] set december='" + comb_day.Text + " " + comboBox_fee.Text + " " + comb_year.Text + "' WHERE Id='" + txt_feeid.Text + "'", conn);
                        conn.Open();
                        CmdSql.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(" Fees paid ", month, MessageBoxButtons.OK);
                        break;
                    }
 
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=HAMMAD;Initial Catalog=Gym;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand CmdSql = new SqlCommand("select * from [Table] ", conn);

            try 
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = CmdSql;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                datagrid.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            conn.Open();
            CmdSql.ExecuteNonQuery();
            conn.Close();
            
        }
    }
}
