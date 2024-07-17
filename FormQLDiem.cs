using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BT45_QLSV_SQL_MUlTIPLE_FORMS
{
    public partial class FormQLDiem : Form
    {
        ClassQLSV_SQL kn = new ClassQLSV_SQL();
        public FormQLDiem()
        {
            InitializeComponent();
        }
        public void LoadDuLieu()
        {
            //string sql = "select * from KETQUA";
            string sqlfull = $@"SELECT SV.[MASV],[HOSV] +' '+ [TENSV] as 'HO VA TEN', MH.[MAMH],TENMH,LANTHI,DIEM
                            FROM[SINHVIEN] SV,MONHOC MH, KETQUA KQ
                            WHERE(SV.MASV = KQ.MASV AND KQ.MAMH = MH.MAMH )";

            dataGridViewDiem.DataSource = kn.taobang(sqlfull);
        }

        private void FormQLDiem_Load(object sender, EventArgs e)
        {
            LoadDuLieu();

            this.btnHuy.Enabled = false;
            this.btnLuu.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            kn.myClose();
        }

        private void dataGridViewDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = -1;

            DataTable bang = new DataTable();

            bang = (DataTable)dataGridViewDiem.DataSource;

            chiso = dataGridViewDiem.SelectedCells[0].RowIndex;

            DataRow hang = bang.Rows[chiso];

            tbMaSV.Text = hang["masv"].ToString();
            tbMaMH.Text = hang["maMH"].ToString();
            tbHoVaTenSV.Text = hang["HO VA TEN"].ToString();
            tbMaMH.Text = hang["MAMH"].ToString();
            tbTenMH.Text = hang["TENMH"].ToString();


            string n1 = hang["LANTHI"].ToString();
            if (Convert.ToInt16(n1) == 1 && Convert.ToInt16(n1) == 2)
            {
                tbLan1.Text = hang["LANTHI"].ToString();
                tbLan2.Text = hang["LANTHI"].ToString();

            }
            else if (Convert.ToInt16(n1) == 2)
            {
                tbLan1.Text = "";
                tbLan2.Text = hang["LANTHI"].ToString();

                tbDiemLan2.Text = hang["DIEM"].ToString();
                tbDiemLan1.Text = "";
                //

            }
            else if (Convert.ToInt16(n1) == 1)
            {
                tbLan1.Text = hang["LANTHI"].ToString();
                tbLan2.Text = "";

                tbDiemLan1.Text = hang["DIEM"].ToString();
                tbDiemLan2.Text = "";

                //

            }

            //  dem tong so lan thi cua sinh vien
            string sl = "SELECT COUNT(*) AS 'SOLAN' FROM KETQUA " +
            $"WHERE MASV='" + tbMaSV.Text + "' GROUP BY MASV ";
            DataTable demsl = kn.taobang(sl);
            foreach (DataRow hang7 in demsl.Rows)
                tbSoLanCoDiem.Text = hang7["SOLAN"].ToString();

            LoadDuLieu();


        }
        int flag;
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            //tbMaSV.ResetText();
            //tbHoVaTenSV.ResetText();

            tbMaMH.ResetText();
            tbTenMH.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnSua.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            tbMaSV.ResetText();
            tbHoVaTenSV.ResetText();



            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnSua.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 
            if (tbMaSV.Text == "" & tbMaMH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã Sinh viên và Mã môn học để Xoá");
            }
            else
            {
                kn.xoaKQ(tbMaSV.Text, tbMaMH.Text);
            }
            tbMaSV.ResetText();
            tbHoVaTenSV.ResetText();
            tbMaMH.ResetText();
            tbTenMH.ResetText();
            tbLan1.ResetText();
            tbLan2.ResetText();
            tbDiemLan2.ResetText();
            tbDiemLan1.ResetText();
            tbSoLanCoDiem.ResetText();

            LoadDuLieu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            tbMaSV.ResetText();
            tbHoVaTenSV.ResetText();
            tbMaMH.ResetText();
            tbTenMH.ResetText();
            tbLan1.ResetText();
            tbLan2.ResetText();
            tbDiemLan2.ResetText();
            tbDiemLan1.ResetText();
            tbSoLanCoDiem.ResetText();
            this.btnThem.Enabled = true;

            LoadDuLieu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tbSoLanCoDiem.ResetText();
            if (flag == 0) // Them du lieu

            {
                string s = "select * from ketqua where masv='" + tbMaSV.Text + "'";
                DataTable dt = new DataTable();
                dt = kn.taobang(s);
                if (dt.Rows.Count != 2)
                    if (tbLan1.Text == "1" && tbLan2.Text == "")
                        kn.ThemKQ(tbMaSV.Text, tbMaSV.Text, "1", tbDiemLan1.Text);
                    else if (tbDiemLan2.Text == "2" && tbDiemLan1.Text == "")
                        kn.ThemKQ(tbMaSV.Text, tbTenMH.Text, "2", tbDiemLan2.Text);
                    else if (tbLan1.Text == "1" && tbLan2.Text == "2")
                    {
                        kn.ThemKQ(tbMaSV.Text, tbMaSV.Text, "1", tbDiemLan1.Text);
                        kn.ThemKQ(tbMaSV.Text, tbMaMH.Text, "2", tbDiemLan2.Text);
                    }


                    else
                    {
                        MessageBox.Show("Ban nhap so lan thi bi loi. " +
                                "\r\n Chu y Lan 1 chi duoc nhap 1," +
                                "\r\n Lan 2 chi duoc nhap 2", "Tam Ga Thong Bao",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                MessageBox.Show("Ban nhap trung Ma So SV " + "\r\n Chú ý" +
                "\r\n -- Du lieu khong the co MSSV qua 2 lan" +
                "\r\n -- www.tamga.tk", "Tam Ga Thong Bao",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbMaSV.ResetText();
                tbMaMH.ResetText();
                tbHoVaTenSV.ResetText();
                tbLan1.ResetText();
                tbLan2.ResetText();
                tbDiemLan1.ResetText();
                tbDiemLan2.ResetText();
                tbTenMH.ResetText();
                tbMaSV.Focus();

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                LoadDuLieu();
            }
            else if (flag == 1) // Sua du lieu
            {
                string s = "select * from ketqua where masv='" + tbMaSV.Text + "'";
                DataTable dt = new DataTable();
                dt = kn.taobang(s);
                if (tbLan1.Text != "" && tbLan2.Text == "")
                    kn.suaKQ(tbMaSV.Text, tbMaMH.Text, tbLan1.Text, tbDiemLan1.Text);
                else if (tbLan2.Text != "" && tbLan1.Text == "")
                    kn.suaKQ(tbMaSV.Text, tbMaMH.Text, tbLan2.Text, tbDiemLan2.Text);
                else if (tbLan1.Text != "" && tbLan2.Text != "")
                {
                    kn.suaKQ(tbMaSV.Text, tbMaMH.Text, tbLan1.Text, tbDiemLan1.Text);
                    kn.suaKQ(tbMaSV.Text, tbMaMH.Text, tbLan2.Text, tbDiemLan2.Text);
                }
                else
                {

                    MessageBox.Show("Ban sua so lan thi bi 18i. " +
                    "\r\n Chu y Lan 1 chi duoc nhap 1," +
                    "\r\n Lan 2 chi duoc nhap 2", "Tam Ga Thong Bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tbMaSV.ResetText();
                tbMaMH.ResetText();
                tbHoVaTenSV.ResetText();
                tbLan1.ResetText();
                tbLan2.ResetText();
                tbDiemLan1.ResetText();
                tbDiemLan2.ResetText();
                tbTenMH.ResetText();
                tbMaSV.Focus();

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                LoadDuLieu();



            }

        }
    }
}