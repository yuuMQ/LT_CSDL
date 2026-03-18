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
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            window_radio.Checked = true;
            username.Enabled = false;
            password.Enabled = false;
            dis_button.Enabled = false;
        }

        // windows authentication
        private void radioWindows_Checked(object sender, EventArgs e)
        {
            if (window_radio.Checked)
            {
                username.Text = "";
                password.Text = "";
                username.Enabled = false;
                password.Enabled = false;
            }
        }

        // sql server authentication
        private void radioSQL_checked(object sender, EventArgs e)
        {
            username.Enabled = true;
            password.Enabled = true;
        }

        // Connect button
        private void cnnButton_clicked(object sender, EventArgs e)
        {
            string serverName = servername.Text.Trim();
            string dbName = dbname.Text.Trim();
            string cnn_str = "";

            // Windows Authentication
            if (window_radio.Checked)
            {
                cnn_str = $"Server={serverName}; Database={dbName}; Integrated Security=True;";
            }
            else
            {
                string user = username.Text.Trim();
                string pass = password.Text.Trim();
                cnn_str = $"Server={serverName};Database={dbName};User ID={user};Password={pass}; Trust_Connection=False;";
            }
            try
            {
                conn = new SqlConnection(cnn_str);
                conn.Open();

                MessageBox.Show("Kết nối đến cơ sở dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn_button.Enabled = false;
                dis_button.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Disconnection
        private void disButton_clicked(object sender, EventArgs e)
        {
            try {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    MessageBox.Show("Đã ngắt kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conn_button.Enabled = true;
                    dis_button.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ngắt kết nối:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void window_radio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
