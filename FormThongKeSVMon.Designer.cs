namespace BT45_QLSV_SQL_MUlTIPLE_FORMS
{
    partial class FormThongKeSVMon
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
            this.tbSoTiet = new System.Windows.Forms.TextBox();
            this.comboBoxMaMonHoc = new System.Windows.Forms.ComboBox();
            this.tbTenMonHoc = new System.Windows.Forms.TextBox();
            this.DataGridViewMH = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMH)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSoTiet
            // 
            this.tbSoTiet.Location = new System.Drawing.Point(364, 59);
            this.tbSoTiet.Name = "tbSoTiet";
            this.tbSoTiet.Size = new System.Drawing.Size(104, 20);
            this.tbSoTiet.TabIndex = 52;
            // 
            // comboBoxMaMonHoc
            // 
            this.comboBoxMaMonHoc.FormattingEnabled = true;
            this.comboBoxMaMonHoc.Location = new System.Drawing.Point(113, 64);
            this.comboBoxMaMonHoc.Name = "comboBoxMaMonHoc";
            this.comboBoxMaMonHoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaMonHoc.TabIndex = 51;
            this.comboBoxMaMonHoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaMonHoc_SelectedIndexChanged);
            // 
            // tbTenMonHoc
            // 
            this.tbTenMonHoc.Location = new System.Drawing.Point(113, 94);
            this.tbTenMonHoc.Name = "tbTenMonHoc";
            this.tbTenMonHoc.Size = new System.Drawing.Size(255, 20);
            this.tbTenMonHoc.TabIndex = 50;
            // 
            // DataGridViewMH
            // 
            this.DataGridViewMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMH.Location = new System.Drawing.Point(9, 130);
            this.DataGridViewMH.Name = "DataGridViewMH";
            this.DataGridViewMH.Size = new System.Drawing.Size(635, 244);
            this.DataGridViewMH.TabIndex = 49;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(561, 60);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 53);
            this.btnThoat.TabIndex = 48;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 47;
            this.label6.Text = "Tên Môn Học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(303, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "Số Tiết:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã Môn Học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(96, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 36);
            this.label1.TabIndex = 44;
            this.label1.Text = "Thống Kê Sinh Viên Theo Môn Học";
            // 
            // FormThongKeSVMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 386);
            this.Controls.Add(this.tbSoTiet);
            this.Controls.Add(this.comboBoxMaMonHoc);
            this.Controls.Add(this.tbTenMonHoc);
            this.Controls.Add(this.DataGridViewMH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThongKeSVMon";
            this.Text = "FormThongKeSVMon";
            this.Load += new System.EventHandler(this.FormThongKeSVMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSoTiet;
        private System.Windows.Forms.ComboBox comboBoxMaMonHoc;
        private System.Windows.Forms.TextBox tbTenMonHoc;
        private System.Windows.Forms.DataGridView DataGridViewMH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}