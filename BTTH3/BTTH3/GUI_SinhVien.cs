using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;
namespace BTTH3
{
    public partial class GUI_SinhVien : Form
    {
        BUS_SinhVien busSV = new BUS_SinhVien();
        public GUI_SinhVien()
        {
            InitializeComponent();
            this.Load += GUI_SinhVien_Load;
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GUI_SinhVien_Load(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = busSV.getSinhVien();

        }


        private void buttThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void buttThem_Click(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text != "" && txtSDT.Text != "" && txtEmail.Text != "")
            {
                DTO_SinhVien sv = new DTO_SinhVien(0, txtHoVaTen.Text, txtSDT.Text, txtEmail.Text);

                if (busSV.themSinhVien(sv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvSinhVien.DataSource = busSV.getSinhVien();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
        }

        private void buttSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                if (txtHoVaTen.Text != "" && txtSDT.Text != "" && txtEmail.Text != "")
                {
                    DataGridViewRow row = dgvSinhVien.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    DTO_SinhVien sv = new DTO_SinhVien(ID, txtHoVaTen.Text, txtSDT.Text, txtEmail.Text);

                    if (busSV.suaSinhVien(sv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvSinhVien.DataSource = busSV.getSinhVien();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn sinh viên muốn sửa");
            }
            
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvSinhVien.SelectedRows[0];

            txtHoVaTen.Text = row.Cells[1].Value.ToString();
            txtSDT.Text = row.Cells[2].Value.ToString();
            txtEmail.Text = row.Cells[3].Value.ToString();
        }

        private void buttXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSinhVien.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                
                if (busSV.xoaSinhVien(ID))
                {
                    MessageBox.Show("Xóa Thành công");
                    dgvSinhVien.DataSource = busSV.getSinhVien();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn sinh viên muốn xóa");
            }
        }

    }
}
