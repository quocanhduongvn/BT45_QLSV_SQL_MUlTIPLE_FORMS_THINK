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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            FormSinhVien formSinhVien = new FormSinhVien();
            formSinhVien.ShowDialog();
        }

        private void toolStripTBThongKeSVMon_Click(object sender, EventArgs e)
        {
            FormThongKeSVMon formThongKeSVMon = new FormThongKeSVMon();
            formThongKeSVMon.ShowDialog();
        }

        private void toolStripTBThongKeSVKhoa_Click(object sender, EventArgs e)
        {
            FormThongKeSinhVienKhoa formThongKeSinhVienKhoa = new FormThongKeSinhVienKhoa();
            formThongKeSinhVienKhoa.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSinhVien formSinhVien = new FormSinhVien();
            formSinhVien.ShowDialog();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhoa formKhoa = new FormKhoa();
            formKhoa.ShowDialog();
        }

        private void kếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLDiem formKetQua = new FormQLDiem();
            formKetQua.ShowDialog();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            FormKhoa formKhoa = new FormKhoa();
            formKhoa.ShowDialog();
        }

        private void toolStripTimKQHT_Click(object sender, EventArgs e)
        {
            FormTimKQHocTap formTimKQHocTap = new FormTimKQHocTap();
            formTimKQHocTap.ShowDialog();
        }
    }
}
