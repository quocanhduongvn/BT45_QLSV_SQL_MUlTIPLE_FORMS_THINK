using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT45_QLSV_SQL_MUlTIPLE_FORMS
{
    internal class ClassQLSV_SQL
    {

        public void myConect()
        {
            Connection.Open();
        }
        public void myClose()
        {
            Connection.Close();

        }


        public SqlConnection Connection = new SqlConnection
            ("Data Source=quoc-anh-pc\\sqlexpress;Initial Catalog=QLSV;Integrated Security=True");

        public DataTable taobang(string sql)
        {
            // Kiểm tra xem kết nối có đang mở hay không
            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }
            // InitializeConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql, Connection);
            ds.Fill(dt);

            // Đóng kết nối sau khi hoàn thành truy vấn
            Connection.Close();

            return dt;
        }
        string tb = "NOTHING";
        public string thongbao()
        { 
           
            return tb;
        }
        public void Them(string maSV, string ho, string ten, DateTime ngaySinh, string gioiTinh, string khoa)
        {
            string sql = "INSERT INTO sinhvien (masv, hosv, tensv, ngaysinh, gioitinh, khoa) " +
                         "VALUES (@maSV, @ho, @ten, @ngaySinh, @gioiTinh, @Khoa)";
            myConect();
            using (SqlCommand cmd = new SqlCommand(sql, Connection))
            {
                cmd.Parameters.AddWithValue("@maSV", maSV);
                cmd.Parameters.AddWithValue("@ho", ho);
                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@Khoa", khoa);

                cmd.ExecuteNonQuery();
            }
            myClose();
        }
        public void ThemKhoa(string maKhoa, string tenKhoa)
        {
            string sql = "INSERT INTO khoa (maKhoa,tenKhoa) " +
                         "VALUES (@maKhoa, @tenKhoa)";
            myConect();
            using (SqlCommand cmd = new SqlCommand(sql, Connection))
            {
                cmd.Parameters.AddWithValue("@maKhoa", maKhoa);
                
                cmd.Parameters.AddWithValue("@tenKhoa", tenKhoa);

                cmd.ExecuteNonQuery();
            }
            myClose();
        }
        public void ThemKQ(string maSV, string maMH, string lanThi, string diem)
        {
            string sql = "INSERT INTO KETQUA (masv, maMH, lanThi, Diem) " +
                         "VALUES (@masv, @maMH, @lanThi, @diem)";
            myConect();
            using (SqlCommand cmd = new SqlCommand(sql, Connection))
            {
                cmd.Parameters.AddWithValue("@maSV", maSV);
                cmd.Parameters.AddWithValue("@ho", maMH);
                cmd.Parameters.AddWithValue("@ten", lanThi);
                cmd.Parameters.AddWithValue("@ngaySinh", diem);
               

                cmd.ExecuteNonQuery();
            }
            myClose();
        }
        public void xoa(string maSV)
        {
            myConect();
            string sql = "DELETE FROM sinhvien WHERE masv = @maSV";
            using (SqlCommand cmd = new SqlCommand(sql, Connection))
            {
                cmd.Parameters.AddWithValue("@maSV", maSV);
                cmd.ExecuteNonQuery();
            }
            myClose();
        }
        public void xoaKhoa(string maKhoa)
        {
            myConect();
            string sql = "DELETE FROM Khoa WHERE maKhoa = @maKhoa";
            using (SqlCommand cmd = new SqlCommand(sql, Connection))
            {
                cmd.Parameters.AddWithValue("@maKhoa", maKhoa);
                cmd.ExecuteNonQuery();
            }
            myClose();
        }
        public void xoaKQ(string maSV, string maMH )
        {
            myConect();
            string sql = "DELETE FROM KETQUA WHERE (masv = @maSV AND maMH = @maMH)";
            using (SqlCommand cmd = new SqlCommand(sql, Connection))
            {
                cmd.Parameters.AddWithValue("@maSV", maSV);
                cmd.Parameters.AddWithValue("@maMH", maMH);
                cmd.ExecuteNonQuery();
            }
            myClose();
        }
        public void sua(string maSV, string ho, string ten, DateTime ngaySinh,
string gioiTinh, string khoa)
        {
            string sql = "UPDATE sinhvien " +
                         "SET hosv = @ho, tensv = @ten, " +
                         "    ngaysinh = @ngaySinh, gioitinh = @gioiTinh, " +
                         "    khoa = @Khoa " +
                         "WHERE masv = @maSV";
            myConect();

            using (SqlCommand cmd = new SqlCommand(sql, Connection))
            {
                cmd.Parameters.AddWithValue("@ho", ho);
                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@Khoa", khoa);
                cmd.Parameters.AddWithValue("@maSV", maSV);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    tb = "Cập nhật thông tin sinh viên thành công.";
                }
                else
                {
                    tb = ("Không tìm thấy sinh viên với mã số: " + maSV);
                }
                myClose();
            }
        }
            public void suaKhoa(string maKhoa, string tenKhoa)
            {
                string sql = "UPDATE KHOA " +
                             "SET MaKhoa = maKhoa, tenKhoa = @tenKhoa "+ 
                        
                             "WHERE maKhoa = @maKhoa";
                myConect();

                using (SqlCommand cmd = new SqlCommand(sql, Connection))
                {
                   
                    cmd.Parameters.AddWithValue("@maKhoa", maKhoa);
                    cmd.Parameters.AddWithValue("@tenKhoa", tenKhoa);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        tb = "Cập nhật thông tin Khoa thành công.";
                    }
                    else
                    {
                        tb = ("Không tìm thấy Khoa với mã số: " + maKhoa);
                    }
                    myClose();
                }
            
        }
        public void suaKQ(string maSV, string maMH, string lanThi, string diem)
        {
            string sql = "UPDATE sinhvien " +
                         "SET hosv = @ho, tensv = @ten, " +
                         "    ngaysinh = @ngaySinh, gioitinh = @gioiTinh, " +
                         "    khoa = @Khoa " +
                         "WHERE masv = @maSV";
            myConect();

            using (SqlCommand cmd = new SqlCommand(sql, Connection))
            {
                cmd.Parameters.AddWithValue("@maSV", maSV);
                cmd.Parameters.AddWithValue("@ho", maMH);
                cmd.Parameters.AddWithValue("@ten", lanThi);
                cmd.Parameters.AddWithValue("@ngaySinh", diem);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    tb = "Cập nhật thông tin sinh viên thành công.";
                }
                else
                {
                    tb = ("Không tìm thấy sinh viên với mã số: " + maSV);
                }
                myClose();
            }
        }
    }
}
