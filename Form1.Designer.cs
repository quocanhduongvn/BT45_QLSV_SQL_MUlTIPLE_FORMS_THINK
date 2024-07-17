namespace BT45_QLSV_SQL_MUlTIPLE_FORMS
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTBThongKeSVKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripThongKeSVMon = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.toolStripTimKQHT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(440, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhViênToolStripMenuItem,
            this.khoaToolStripMenuItem,
            this.kếtQuảToolStripMenuItem});
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cậpNhậtToolStripMenuItem.Text = "Cập Nhật";
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.sinhViênToolStripMenuItem.Text = "Sinh Viên";
            this.sinhViênToolStripMenuItem.Click += new System.EventHandler(this.sinhViênToolStripMenuItem_Click);
            // 
            // khoaToolStripMenuItem
            // 
            this.khoaToolStripMenuItem.Name = "khoaToolStripMenuItem";
            this.khoaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.khoaToolStripMenuItem.Text = "Khoa";
            this.khoaToolStripMenuItem.Click += new System.EventHandler(this.khoaToolStripMenuItem_Click);
            // 
            // kếtQuảToolStripMenuItem
            // 
            this.kếtQuảToolStripMenuItem.Name = "kếtQuảToolStripMenuItem";
            this.kếtQuảToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.kếtQuảToolStripMenuItem.Text = "Kết Quả";
            this.kếtQuảToolStripMenuItem.Click += new System.EventHandler(this.kếtQuảToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTBThongKeSVKhoa,
            this.toolStripThongKeSVMon});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // toolStripTBThongKeSVKhoa
            // 
            this.toolStripTBThongKeSVKhoa.Name = "toolStripTBThongKeSVKhoa";
            this.toolStripTBThongKeSVKhoa.Size = new System.Drawing.Size(235, 22);
            this.toolStripTBThongKeSVKhoa.Text = "Thống Kê Sinh Viên Theo Khoa";
            this.toolStripTBThongKeSVKhoa.Click += new System.EventHandler(this.toolStripTBThongKeSVKhoa_Click);
            // 
            // toolStripThongKeSVMon
            // 
            this.toolStripThongKeSVMon.Name = "toolStripThongKeSVMon";
            this.toolStripThongKeSVMon.Size = new System.Drawing.Size(235, 22);
            this.toolStripThongKeSVMon.Text = "Thống Kê Sinh Viên Theo Môn";
            this.toolStripThongKeSVMon.Click += new System.EventHandler(this.toolStripTBThongKeSVMon_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTimKQHT,
            this.thôngTinSinhViênToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            // 
            // thôngTinSinhViênToolStripMenuItem
            // 
            this.thôngTinSinhViênToolStripMenuItem.Name = "thôngTinSinhViênToolStripMenuItem";
            this.thôngTinSinhViênToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinSinhViênToolStripMenuItem.Text = "Thông Tin Sinh Viên";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSinhVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhVien.Location = new System.Drawing.Point(0, 63);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(75, 31);
            this.btnSinhVien.TabIndex = 1;
            this.btnSinhVien.Text = "Sinh Viên";
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(2, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chương Trình Quản Lý Sinh Viên";
            // 
            // btnKhoa
            // 
            this.btnKhoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoa.Location = new System.Drawing.Point(0, 100);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(75, 31);
            this.btnKhoa.TabIndex = 3;
            this.btnKhoa.Text = "Khoa";
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(365, 63);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStripTimKQHT
            // 
            this.toolStripTimKQHT.Name = "toolStripTimKQHT";
            this.toolStripTimKQHT.Size = new System.Drawing.Size(180, 22);
            this.toolStripTimKQHT.Text = "Kết Quả Học Tập";
            this.toolStripTimKQHT.Click += new System.EventHandler(this.toolStripTimKQHT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BT45_QLSV_SQL_MUlTIPLE_FORMS.Properties.Resources.UNI;
            this.ClientSize = new System.Drawing.Size(440, 309);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSinhVien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Chương Trình Quản Lý Sinh Viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolStripMenuItem toolStripTBThongKeSVKhoa;
        private System.Windows.Forms.ToolStripMenuItem toolStripThongKeSVMon;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtQuảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripTimKQHT;
    }
}

