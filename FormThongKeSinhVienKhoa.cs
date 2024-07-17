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
    public partial class FormThongKeSinhVienKhoa : Form
    {
        public FormThongKeSinhVienKhoa()
        {
            InitializeComponent();
        }
        ClassQLSV_SQL kn = new ClassQLSV_SQL();
        private void FormThongKeSinhVienKhoa_Load(object sender, EventArgs e)
        {
            kn.myConect();
            string sql = "select * from KHOA";
            comboBoxMaKhoa.DataSource = kn.taobang(sql);
            comboBoxMaKhoa.DisplayMember = "MaKhoa";
        }

        private void comboBoxMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // load du lieu xuong text
            string s = $"select * from KHOA where makhoa= '{comboBoxMaKhoa.Text}'";
            DataTable d = kn.taobang(s);
            foreach (DataRow hang in d.Rows)
            {
                tbTenKhoa.Text = hang["TENKHOA"].ToString();
            }
            
            //Load du lieu vao data

            string s2 = $"SELECT sv.masv, sv.hosv, sv.tensv, sv.ngaysinh " +
            "FROM SINHVIEN sv , KHOA KH " +
            $"WHERE (sv.khoa = KH.makhoa ) and ( KH.makhoa = '{comboBoxMaKhoa.Text}') ";
            
            DataGridViewSVKhoa.DataSource = kn.taobang(s2);
           
            tbTongSoSV.Text = (DataGridViewSVKhoa.Rows.Count -1 ).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            kn.myClose();
        }
    }
}
