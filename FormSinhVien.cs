using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT45_QLSV_SQL_MUlTIPLE_FORMS
{
    public partial class FormSinhVien : Form
    {
        public FormSinhVien()
        {
            InitializeComponent();
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            //kn.myConect();
            LoadDuLieu();
            // string sql = "select * from sinhvien";
            // DataGridViewSV.DataSource = kn.taobang(sql);
            this.btnHuy.Enabled = false;
            this.btnLuu.Enabled = false;
        }
        ClassQLSV_SQL kn = new ClassQLSV_SQL();
      

        

        private void DataGridViewSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = -1;

            DataTable bang = new DataTable();

            bang = (DataTable)DataGridViewSV.DataSource;

            chiso = DataGridViewSV.SelectedCells[0].RowIndex;

            DataRow hang = bang.Rows[chiso];

            tbMaSV.Text = hang["masv"].ToString();
            tbHoSV.Text = hang["hosv"].ToString();
            tbTenSV.Text = hang["tensv"].ToString();
            tbMaKhoa.Text = hang["khoa"].ToString();
            tbGioiTinh.Text = hang["gioitinh"].ToString();
            dateTimePickerNgaySinh.Value = Convert.ToDateTime(hang["ngaysinh"].ToString());
        }
        public void LoadDuLieu()
        {
            string sql = "select MaSV,HoSV,TenSV,NgaySinh,GioiTinh,Khoa from sinhvien";
            //string sql = "select * from sinhvien";
            DataGridViewSV.DataSource = kn.taobang(sql);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tbMaSV.ResetText();
            tbHoSV.ResetText();
            tbTenSV.ResetText();
            // tbGioiTinh.ResetText();
            tbMaKhoa.ResetText();
            dateTimePickerNgaySinh.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            LoadDuLieu();
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM sinhvien WHERE MaSV = '{tbMaSV.Text}'";
            DataTable dt = new DataTable();
            dt = kn.taobang(sql);
            if (dt.Rows.Count == 0)
            {
                kn.Them(tbMaSV.Text, tbHoSV.Text, tbTenSV.Text, dateTimePickerNgaySinh.Value,

                    tbGioiTinh.Text, tbMaKhoa.Text);

                tbMaSV.ResetText();
                tbHoSV.ResetText();
                tbTenSV.ResetText();
                // tbGioiTinh.ResetText();
                tbMaKhoa.ResetText();
                dateTimePickerNgaySinh.ResetText();
                tbMaSV.Focus();
            }
            else
            {
                MessageBox.Show("Mã SV đã có !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDuLieu();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM sinhvien WHERE MaSV = '{tbMaSV.Text}'";
            DataTable dt = new DataTable();
            dt = kn.taobang(sql);
            if (dt.Rows.Count != 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    kn.xoa(tbMaSV.Text);

                    // Refresh dữ liệu trên form
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;
                    DataGridViewSV.DataSource = bindingSource;
                }
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Dữ liệu để Xoá !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDuLieu();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM sinhvien WHERE MaSV = '{tbMaSV.Text}'";
            DataTable dt = new DataTable();
            dt = kn.taobang(sql);
            if (dt.Rows.Count != 0)
            {
                kn.sua(tbMaSV.Text, tbHoSV.Text, tbTenSV.Text, dateTimePickerNgaySinh.Value,

                    tbGioiTinh.Text, tbMaKhoa.Text);
                tbMaSV.ResetText();
                tbHoSV.ResetText();
                tbTenSV.ResetText();
                // tbGioiTinh.ResetText();
                tbMaKhoa.ResetText();
                dateTimePickerNgaySinh.ResetText();
                tbMaSV.Focus();
                MessageBox.Show($"{kn.thongbao()}", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Dữ liệu để sửa !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDuLieu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            tbMaSV.ResetText();
            tbHoSV.ResetText();
            tbTenSV.ResetText();
            // tbGioiTinh.ResetText();
            tbMaKhoa.ResetText();
            dateTimePickerNgaySinh.ResetText();
            tbMaSV.Focus();

            this.btnThem.Enabled = true;
            LoadDuLieu();
        }

        private void checkBoxIsNam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsNam.Checked == true)
            {
                tbGioiTinh.Text = "Nam";

            }
            else
            {
                tbGioiTinh.Text = "Nữ";
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
            kn.myClose();

        }
    }
}
