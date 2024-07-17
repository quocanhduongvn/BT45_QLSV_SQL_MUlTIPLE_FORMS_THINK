namespace BT45_QLSV_SQL_MUlTIPLE_FORMS
{
    partial class FormThongKeSinhVienKhoa
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
            this.comboBoxMaKhoa = new System.Windows.Forms.ComboBox();
            this.tbTenKhoa = new System.Windows.Forms.TextBox();
            this.DataGridViewSVKhoa = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTongSoSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSVKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMaKhoa
            // 
            this.comboBoxMaKhoa.FormattingEnabled = true;
            this.comboBoxMaKhoa.Location = new System.Drawing.Point(110, 62);
            this.comboBoxMaKhoa.Name = "comboBoxMaKhoa";
            this.comboBoxMaKhoa.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaKhoa.TabIndex = 60;
            this.comboBoxMaKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaKhoa_SelectedIndexChanged);
            // 
            // tbTenKhoa
            // 
            this.tbTenKhoa.Location = new System.Drawing.Point(316, 62);
            this.tbTenKhoa.Name = "tbTenKhoa";
            this.tbTenKhoa.Size = new System.Drawing.Size(222, 20);
            this.tbTenKhoa.TabIndex = 59;
            // 
            // DataGridViewSVKhoa
            // 
            this.DataGridViewSVKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSVKhoa.Location = new System.Drawing.Point(9, 89);
            this.DataGridViewSVKhoa.Name = "DataGridViewSVKhoa";
            this.DataGridViewSVKhoa.Size = new System.Drawing.Size(635, 244);
            this.DataGridViewSVKhoa.TabIndex = 58;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(463, 354);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 25);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(237, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 56;
            this.label6.Text = "Tên Khoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mã Khoa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 36);
            this.label1.TabIndex = 53;
            this.label1.Text = "Thống Kê Sinh Viên Theo Khoa";
            // 
            // tbTongSoSV
            // 
            this.tbTongSoSV.Location = new System.Drawing.Point(241, 358);
            this.tbTongSoSV.Name = "tbTongSoSV";
            this.tbTongSoSV.Size = new System.Drawing.Size(197, 20);
            this.tbTongSoSV.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(95, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 61;
            this.label3.Text = "Tổng Số Sinh Viên:";
            // 
            // FormThongKeSinhVienKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 386);
            this.Controls.Add(this.tbTongSoSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxMaKhoa);
            this.Controls.Add(this.tbTenKhoa);
            this.Controls.Add(this.DataGridViewSVKhoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThongKeSinhVienKhoa";
            this.Text = "FormThongKeSinhVienKhoa";
            this.Load += new System.EventHandler(this.FormThongKeSinhVienKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSVKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMaKhoa;
        private System.Windows.Forms.TextBox tbTenKhoa;
        private System.Windows.Forms.DataGridView DataGridViewSVKhoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTongSoSV;
        private System.Windows.Forms.Label label3;
    }
}