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
    public partial class product_list : Form
    {
        private string connectionString = "Server=413;Database=Northwind;Integrated Security=True;";
        private DataTable product_dt;


        public product_list()
        {
            InitializeComponent();
        }

        private void Form2_load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            LoadDataGridView();
        }


        private void LoadComboBoxData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter type_da = new SqlDataAdapter("SELECT CategoryID, CategoryName FROM Categories", conn);
                    DataTable type_dt = new DataTable();
                    type_da.Fill(type_dt);
                    product_type.DataSource = type_dt;
                    product_type.DisplayMember = "CategoryName";
                    product_type.ValueMember = "CategoryID";

                    SqlDataAdapter supplier_da = new SqlDataAdapter("SELECT SupplierID, CompanyName FROM Suppliers", conn);

                    DataTable supplier_dt = new DataTable();
                    supplier_da.Fill(supplier_dt);

                    supplier.DataSource = supplier_dt;
                    supplier.DisplayMember = "CompanyName";
                    supplier.ValueMember = "SupplierID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu ComboBox: " + ex.Message);
                }
            }
        }
        private void LoadDataGridView()
        {
            string query = @"
            SELECT  p.ProductID,
                    p.ProductName, 
                    p.UnitPrice,    
                    p.QuantityPerUnit,
                    c.CategoryName,
                    s.CompanyName
            FROM Products p
            INNER JOIN Categories c ON p.CategoryID = c.CategoryID
            INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
            ";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    product_dt = new DataTable();
                    adapter.Fill(product_dt);

                    general.DataSource = product_dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu Sản phẩm: " + ex.Message);
                }
            }

        }


        private void Product_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = general.Rows[e.RowIndex];

                product_name.Text = row.Cells["ProductName"].Value.ToString();
                product_cost.Text = row.Cells["UnitPrice"].Value.ToString();
                product_nums.Text = row.Cells["QuantityPerUnit"].Value.ToString();
                supplier.Text = row.Cells["CompanyName"].Value.ToString();
            }
        }

        private int GetSelectedProductID()
        {
            if (general.CurrentRow != null && general.CurrentRow.Index >= 0)
            {
                return Convert.ToInt32(general.CurrentRow.Cells["ProductID"].Value);
            }
            return -1;
        }

        // INSERT
        private void insertButton_click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(product_name.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = @"
                        INSERT INTO Products(ProductName, UnitPrice, QuantityPerUnit, CategoryID, SupplierID) 
                        VALUES (@TenSP, @DonGia, @SoLuong, @MaLoai, @MaNhaCC)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenSP", product_name.Text.Trim());
                    cmd.Parameters.AddWithValue("@DonGia", string.IsNullOrEmpty(product_cost.Text) ? 0 : Convert.ToDecimal(product_cost.Text));
                    cmd.Parameters.AddWithValue("@MaLoai", product_type.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaNhaCC", supplier.SelectedValue);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo");
                    LoadDataGridView();
            
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
