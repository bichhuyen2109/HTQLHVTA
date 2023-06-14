namespace HeThongQuanLyTTHV.QLKQHT
{
    partial class XemDS
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CCCD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CapHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KhoaHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btSapXep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ma,
            this.HoTen,
            this.CCCD,
            this.CapHoc,
            this.KhoaHoc,
            this.Lop,
            this.SDT,
            this.NgaySinh,
            this.Diem,
            this.GioiTinh,
            this.GhiChu});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 104);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1512, 551);
            this.listView1.TabIndex = 74;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ma
            // 
            this.ma.Text = "Mã Phiếu";
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ Tên";
            this.HoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CCCD
            // 
            this.CCCD.Text = "CCCD";
            this.CCCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CapHoc
            // 
            this.CapHoc.Text = "Cấp Học";
            this.CapHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KhoaHoc
            // 
            this.KhoaHoc.Text = "Khóa Học";
            this.KhoaHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lop
            // 
            this.Lop.Text = "Lớp";
            this.Lop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SDT
            // 
            this.SDT.Text = "SĐT";
            this.SDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Text = "Ngày Sinh";
            this.NgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Diem
            // 
            this.Diem.Text = "Điểm";
            this.Diem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Text = "Giới Tính";
            this.GioiTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GhiChu
            // 
            this.GhiChu.Text = "GhiChu";
            this.GhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSapXep
            // 
            this.btSapXep.Location = new System.Drawing.Point(1198, 675);
            this.btSapXep.Name = "btSapXep";
            this.btSapXep.Size = new System.Drawing.Size(144, 49);
            this.btSapXep.TabIndex = 0;
            this.btSapXep.Text = "Sắp Xếp";
            this.btSapXep.UseVisualStyleBackColor = true;
            this.btSapXep.Click += new System.EventHandler(this.btSapXep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(248, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 40);
            this.label1.TabIndex = 76;
            this.label1.Text = "Danh Sách Phiếu Kết Quả Học Tập";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(1380, 675);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(144, 49);
            this.btThoat.TabIndex = 1;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // XemDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 752);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSapXep);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XemDS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách phiếu kết quả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.XemDS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ma;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader CCCD;
        private System.Windows.Forms.ColumnHeader CapHoc;
        private System.Windows.Forms.ColumnHeader KhoaHoc;
        private System.Windows.Forms.ColumnHeader Lop;
        private System.Windows.Forms.ColumnHeader SDT;
        private System.Windows.Forms.ColumnHeader NgaySinh;
        private System.Windows.Forms.ColumnHeader Diem;
        private System.Windows.Forms.ColumnHeader GioiTinh;
        private System.Windows.Forms.ColumnHeader GhiChu;
        private System.Windows.Forms.Button btSapXep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThoat;
    }
}