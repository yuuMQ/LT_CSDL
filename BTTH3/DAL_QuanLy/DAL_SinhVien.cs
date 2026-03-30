using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;
using System.Data.SqlClient;
using System.Data;
namespace DAL_QuanLy
{
    public class DAL_SinhVien : DBConnect
    {
        public DataTable getSinhVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SINHVIEN", conn);
            DataTable dtSinhVien = new DataTable();
            da.Fill(dtSinhVien);
            return dtSinhVien;
        }

        public bool themSinhVien(DTO_SinhVien sv)
        {
            try
            {
                conn.Open();
                string SQL = string.Format($"INSERT INTO SINHVIEN(SV_NAME, SV_PHONE, SV_EMAIL) VALUES ('{sv.SINHVIEN_NAME}', '{sv.SINHVIEN_PHONE}', '{sv.SINHVIEN_EMAIL}')");

                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool suaSinhVien(DTO_SinhVien sv)
        {
            try
            {
                conn.Open();
                string SQL = string.Format($"UPDATE SINHVIEN SET SV_NAME='{sv.SINHVIEN_NAME}', SV_PHONE='{sv.SINHVIEN_PHONE}', SV_EMAIL='{sv.SINHVIEN_EMAIL}' WHERE SV_ID={sv.SINHVIEN_ID}");
                SqlCommand cmd = new SqlCommand(SQL, conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool xoaSinhVien(int SV_ID)
        {
            try
            {
                conn.Open();
                string SQL = string.Format($"DELETE FROM SINHVIEN WHERE SV_ID = {SV_ID}");
                SqlCommand cmd = new SqlCommand(SQL, conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
