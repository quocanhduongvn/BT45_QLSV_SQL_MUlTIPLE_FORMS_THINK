namespace BT45_QLSV_SQL_MUlTIPLE_FORMS
{
    partial class FormSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxIsNam = new System.Windows.Forms.CheckBox();
            this.DataGridViewSV = new System.Windows.Forms.DataGridView();
            this.tbGioiTinh = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tbMaKhoa = new System.Windows.Forms.TextBox();
            this.tbTenSV = new System.Windows.Forms.TextBox();
            this.tbHoSV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tbMaSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSV)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxIsNam
            // 
            this.checkBoxIsNam.AutoSize = true;
            this.checkBoxIsNam.Location = new System.Drawing.Point(247, 90);
            this.checkBoxIsNam.Name = "checkBoxIsNam";
            this.checkBoxIsNam.Size = new System.Drawing.Size(50, 17);
            this.checkBoxIsNam.TabIndex = 41;
            this.checkBoxIsNam.Text = "NAM";
            this.checkBoxIsNam.UseVisualStyleBackColor = true;
            this.checkBoxIsNam.CheckedChanged += new System.EventHandler(this.checkBoxIsNam_CheckedChanged);
            // 
            // DataGridViewSV
            // 
            this.DataGridViewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSV.Location = new System.Drawing.Point(12, 138);
            this.DataGridViewSV.Name = "DataGridViewSV";
            this.DataGridViewSV.Size = new System.Drawing.Size(635, 207);
            this.DataGridViewSV.TabIndex = 40;
            this.DataGridViewSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSV_CellContentClick);
            // 
            // tbGioiTinh
            // 
            this.tbGioiTinh.Location = new System.Drawing.Point(363, 88);
            this.tbGioiTinh.Name = "tbGioiTinh";
            this.tbGioiTinh.Size = new System.Drawing.Size(100, 20);
            this.tbGioiTinh.TabIndex = 39;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(113, 351);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(435, 351);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 30);
            this.btnHuy.TabIndex = 37;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(326, 351);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(218, 351);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(12, 351);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(546, 351);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 30);
            this.btnThoat.TabIndex = 33;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // tbMaKhoa
            // 
            this.tbMaKhoa.Location = new System.Drawing.Point(546, 87);
            this.tbMaKhoa.Name = "tbMaKhoa";
            this.tbMaKhoa.Size = new System.Drawing.Size(100, 20);
            this.tbMaKhoa.TabIndex = 32;
            // 
            // tbTenSV
            // 
            this.tbTenSV.Location = new System.Drawing.Point(546, 55);
            this.tbTenSV.Name = "tbTenSV";
            this.tbTenSV.Size = new System.Drawing.Size(100, 20);
            this.tbTenSV.TabIndex = 31;
            // 
            // tbHoSV
            // 
            this.tbHoSV.Location = new System.Drawing.Point(363, 55);
            this.tbHoSV.Name = "tbHoSV";
            this.tbHoSV.Size = new System.Drawing.Size(100, 20);
            this.tbHoSV.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(469, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Mã Khoa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(469, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tên SV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(303, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Gới Tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(303, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Họ SV:";
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(90, 88);
            this.dateTimePickerNgaySinh.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerNgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(99, 20);
            this.dateTimePickerNgaySinh.TabIndex = 25;
            // 
            // tbMaSV
            // 
            this.tbMaSV.Location = new System.Drawing.Point(89, 59);
            this.tbMaSV.Name = "tbMaSV";
            this.tbMaSV.Size = new System.Drawing.Size(100, 20);
            this.tbMaSV.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ngày Sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã SV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 36);
            this.label1.TabIndex = 21;
            this.label1.Text = "Chương Trình Quảng Lý Sinh Viên";
            // 
            // FormSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 386);
            this.Controls.Add(this.checkBoxIsNam);
            this.Controls.Add(this.DataGridViewSV);
            this.Controls.Add(this.tbGioiTinh);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tbMaKhoa);
            this.Controls.Add(this.tbTenSV);
            this.Controls.Add(this.tbHoSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerNgaySinh);
            this.Controls.Add(this.tbMaSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSinhVien";
            this.Text = "FormSinhVien";
            this.Load += new System.EventHandler(this.FormSinhVien_Load);
            this.Click += new System.EventHandler(this.FormSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxIsNam;
        private System.Windows.Forms.DataGridView DataGridViewSV;
        private System.Windows.Forms.TextBox tbGioiTinh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox tbMaKhoa;
        private System.Windows.Forms.TextBox tbTenSV;
        private System.Windows.Forms.TextBox tbHoSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.TextBox tbMaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}