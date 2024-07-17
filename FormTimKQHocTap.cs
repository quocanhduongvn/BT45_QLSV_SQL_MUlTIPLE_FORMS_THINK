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
    public partial class FormTimKQHocTap : Form
    {
        public FormTimKQHocTap()
        {
            InitializeComponent();
        }
        ClassQLSV_SQL kn = new ClassQLSV_SQL();
        private void FormTimKQHocTap_Load(object sender, EventArgs e)
        {
            kn.myConect();
            string sqlSV = "select * from SINHVIEN ";
            cbMaSV.DataSource = kn.taobang(sqlSV);
            cbMaSV.DisplayMember = "MASV";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            kn.myClose();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql = "SELECT [MASV],"
                        +"[HOSV] +' '+ [TENSV] as 'HO VA TEN'"
                        +",[NGAYSINH] ,[GIOITINH],[KHOA]"
                        +$"FROM[SINHVIEN] WHERE MASV = '{cbMaSV.Text}'";
            DataTable d = kn.taobang(sql);
            foreach(DataRow hang in d.Rows)
            {
                tbNgaySinh.Text = hang["NGAYSINH"].ToString() ;
                tbHoVaTenSV.Text = hang["HO VA TEN"].ToString();
                tbMaKhoa.Text = hang["KHOA"].ToString();
                tbGioiTinh.Text = hang["GIOITINH"].ToString();
            }
            string sqlKQ = "SELECT AVG(DIEM) AS DIEMTB"
                + $"  FROM [KETQUA] Where [MASV] = '{cbMaSV.Text}'";
            DataTable dkq = kn.taobang(sqlKQ);
            foreach (DataRow hang in dkq.Rows)
            {
                tbDiemTB.Text = hang["DIEMTB"].ToString();
               
            }
            String sShow = $@"SELECT MH.[MAMH],TENMH,LANTHI,DIEM
                            FROM[SINHVIEN] SV,MONHOC MH, KETQUA KQ
                            WHERE(SV.MASV = KQ.MASV AND KQ.MAMH = MH.MAMH AND
                            SV.MASV = '{cbMaSV.Text}')";
            dataGridViewKQSV.DataSource = kn.taobang(sShow);
            kn.myClose();
        }
    }
}
