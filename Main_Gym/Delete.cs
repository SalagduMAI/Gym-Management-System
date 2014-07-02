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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        
        private void btn_del_Click(object sender, EventArgs e)
        {

            System.Data.SqlClient.SqlConnection sqlConnection1 =
     new System.Data.SqlClient.SqlConnection("Data Source=HAMMAD;Initial Catalog=Gym;Integrated Security=True");

            SqlCommand cmdd = new SqlCommand("delete from [Table] where ID='" + txt_delid.Text + "'", sqlConnection1);
            cmdd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmdd.ExecuteNonQuery();
            sqlConnection1.Close();
            MessageBox.Show("record deleted");

        }
    }
}
