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

namespace SoftwareSolution
{
    public partial class MainForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-E8HLCCT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Table values('"+name_box.Text+"','" + provider_box.Text + "','" + version_box.Text + "','" + datum_box.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            disp_data();
            MessageBox.Show("record inserted");
        }
        
        public void disp_data()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Table where name='" + name_box.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            disp_data();
            MessageBox.Show("record deleted");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Table set name='"+provider_box.Text+"' where name='" + name_box.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            disp_data();
            MessageBox.Show("record updated");
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
