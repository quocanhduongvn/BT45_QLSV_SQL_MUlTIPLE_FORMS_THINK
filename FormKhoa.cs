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
    public partial class FormKhoa : Form
    {
        public FormKhoa()
        {
            InitializeComponent();
        }
        ClassQLSV_SQL kn = new ClassQLSV_SQL();
        private void FormKhoa_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            this.btnHuy.Enabled = false;
            this.btnLuu.Enabled = false;
        }
        public void LoadDuLieu()
        {
            kn.myConect();
            string sql = "select * from KHOA";
            DataGridViewKhoa.DataSource = kn.taobang(sql);
            // string s2 = "seclect count(*) form khoa"+ $"where khoa = '{tbMaKhoa.Text}' group by makhoa";
            tbTongKhoa.Text = (DataGridViewKhoa.Rows.Count - 1).ToString();
        }
        private void DataGridViewKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)DataGridViewKhoa.DataSource;
            chiso = DataGridViewKhoa.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[chiso];
            tbMaKhoa.Text = hang["MAKHOA"].ToString();
            tbTenKhoa.Text = hang["TenKhoa"].ToString();


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int flag;
        private void btnThem_Click(object sender, EventArgs e)
        {   
            flag = 0;
            this.btnHuy.Enabled = true;
            this.btnLuu.Enabled = true;

            this.btnSua.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnSua.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string s = $"select * from KHOA where makhoa= '{tbMaKhoa.Text}'";
           
            DataTable dt = kn.taobang(s);
            if (dt.Rows.Count != 0) 
            {
                // chay lenh xoa khoa
                kn.xoaKhoa(tbMaKhoa.Text);
                tbMaKhoa.ResetText();
                tbTenKhoa.ResetText();
            }else
            {
                MessageBox.Show("Bạn Chưa Chọn dữa liẹu để xoá","Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            LoadDuLieu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM sinhvien WHERE MaSV = '{tbMaKhoa.Text}'";
            DataTable dt = new DataTable();
            dt = kn.taobang(sql);
            if (flag == 0) //Thêm Dữa liệu
            {
  
                if(tbMaKhoa.Text =="" ||tbTenKhoa.Text == "")
                {
                    MessageBox.Show("Bạn Chưa Nhập dữa liệu cần thêm !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dt.Rows.Count == 0)
                {
                    kn.ThemKhoa(tbMaKhoa.Text, tbTenKhoa.Text);
                   

                   

                    tbMaKhoa.Focus();
                }
                else if (dt.Rows.Count != 0)
                {
                    MessageBox.Show("Mã Khoa đã có !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }else if(flag == 1) // Sửa  dữ liệu
            {
                kn.suaKhoa(tbMaKhoa.Text,tbTenKhoa.Text);
                MessageBox.Show($"{kn.thongbao()} ", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            tbMaKhoa.ResetText();
            tbTenKhoa.ResetText();
            tbMaKhoa.Focus();
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;

            this.btnSua.Enabled = true;
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;
            LoadDuLieu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            tbMaKhoa.ResetText();
            tbTenKhoa.ResetText();
            tbMaKhoa.Focus();

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;

            this.btnSua.Enabled = true;
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;
        }
    }
}
