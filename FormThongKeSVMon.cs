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
    public partial class FormThongKeSVMon : Form
    {
        public FormThongKeSVMon()
        {
            InitializeComponent();
        }
        ClassQLSV_SQL kn = new ClassQLSV_SQL();
        private void FormThongKeSVMon_Load(object sender, EventArgs e)
        {
            kn.myConect();
            string sql = "select * from MONHOC";
            comboBoxMaMonHoc.DataSource = kn.taobang(sql);
            comboBoxMaMonHoc.DisplayMember = "MaMH";

        }
        
       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            kn.myClose();
        }

        private void comboBoxMaMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // load du lieu xuong text
            string s = $"select * from MONHOC where MAMH= '{comboBoxMaMonHoc.Text}'";
            DataTable d = kn.taobang(s);
            foreach (DataRow hang in d.Rows)
            {
                tbTenMonHoc.Text = hang["TENMH"].ToString();
            }
            foreach (DataRow hang in d.Rows)
            {
                tbSoTiet.Text = hang["SOTIET"].ToString();
            }
            //Load du lieu vao data

            string s2 = $"SELECT sv.masv, sv.hosv, sv.tensv, sv.ngaysinh, kq.diem " +
            "FROM SINHVIEN sv , ketqua kq " +
            $"WHERE (sv.masv = kq.masv ) and ( kq.mamh = '{comboBoxMaMonHoc.Text}') ";
            /*
            string s2 = "SELECT sv.masv, sv.hosv, sv.tensv, sv.ngaysinh, kq.diem " +
            "FROM SINHVIEN sv " +
            "INNER JOIN KETQUA kq ON sv.masv = kq.masv " +
            "WHERE kq.mamh = 'AV'";
            */
           //MessageBox.Show(s2);
            DataGridViewMH.DataSource = kn.taobang(s2);
        }
    }
}
