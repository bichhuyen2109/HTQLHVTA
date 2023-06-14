namespace HeThongQuanLyTTHV.QLTKB
{
    partial class XemTKB
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
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.cbbDang = new System.Windows.Forms.ComboBox();
            this.lbChon = new System.Windows.Forms.Label();
            this.lvTKB = new System.Windows.Forms.ListView();
            this.colMaLich = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoBuoiHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSLHV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKhungGioHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbChon = new System.Windows.Forms.ComboBox();
            this.gbDSTKB = new System.Windows.Forms.GroupBox();
            this.rjSapXep = new HeThongQuanLyTTHV.QLTKB.RJButton();
            this.rjBack = new HeThongQuanLyTTHV.QLTKB.RJButton();
            this.gbDSTKB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieuDe.Enabled = false;
            this.lbTieuDe.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.ForeColor = System.Drawing.Color.Brown;
            this.lbTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lbTieuDe.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(840, 89);
            this.lbTieuDe.TabIndex = 2;
            this.lbTieuDe.Text = "THỜI KHOÁ BIỂU";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbDang
            // 
            this.cbbDang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDang.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDang.FormattingEnabled = true;
            this.cbbDang.Location = new System.Drawing.Point(19, 122);
            this.cbbDang.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cbbDang.Name = "cbbDang";
            this.cbbDang.Size = new System.Drawing.Size(356, 26);
            this.cbbDang.TabIndex = 3;
            this.cbbDang.SelectedIndexChanged += new System.EventHandler(this.cbbDang_SelectedIndexChanged);
            // 
            // lbChon
            // 
            this.lbChon.AutoSize = true;
            this.lbChon.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChon.Location = new System.Drawing.Point(15, 93);
            this.lbChon.Name = "lbChon";
            this.lbChon.Size = new System.Drawing.Size(192, 23);
            this.lbChon.TabIndex = 7;
            this.lbChon.Text = "Xem theo dạng:";
            this.lbChon.Click += new System.EventHandler(this.lbChon_Click);
            // 
            // lvTKB
            // 
            this.lvTKB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvTKB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaLich,
            this.colTenKH,
            this.colCap,
            this.colLop,
            this.colSoBuoiHoc,
            this.colSLHV,
            this.colThu,
            this.colKhungGioHoc,
            this.colPhong,
            this.colGV});
            this.lvTKB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTKB.HideSelection = false;
            this.lvTKB.Location = new System.Drawing.Point(6, 28);
            this.lvTKB.Name = "lvTKB";
            this.lvTKB.Size = new System.Drawing.Size(810, 260);
            this.lvTKB.TabIndex = 9;
            this.lvTKB.UseCompatibleStateImageBehavior = false;
            this.lvTKB.View = System.Windows.Forms.View.Details;
            // 
            // colMaLich
            // 
            this.colMaLich.Text = "Mã Lịch";
            this.colMaLich.Width = 100;
            // 
            // colTenKH
            // 
            this.colTenKH.Text = "Tên Khoá Học";
            this.colTenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTenKH.Width = 300;
            // 
            // colCap
            // 
            this.colCap.Text = "Cấp Lớp";
            this.colCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCap.Width = 200;
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp";
            this.colLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLop.Width = 200;
            // 
            // colSoBuoiHoc
            // 
            this.colSoBuoiHoc.Text = "Số Buổi Học";
            this.colSoBuoiHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSoBuoiHoc.Width = 250;
            // 
            // colSLHV
            // 
            this.colSLHV.Text = "Số Lượng Học Viên";
            this.colSLHV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSLHV.Width = 250;
            // 
            // colThu
            // 
            this.colThu.Text = "Thứ";
            this.colThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colThu.Width = 250;
            // 
            // colKhungGioHoc
            // 
            this.colKhungGioHoc.Text = "Khung Giờ Học";
            this.colKhungGioHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colKhungGioHoc.Width = 250;
            // 
            // colPhong
            // 
            this.colPhong.Text = "Phòng";
            this.colPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPhong.Width = 150;
            // 
            // colGV
            // 
            this.colGV.Text = "Giảng Viên";
            this.colGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGV.Width = 250;
            // 
            // cbbChon
            // 
            this.cbbChon.DropDownHeight = 80;
            this.cbbChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChon.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChon.FormattingEnabled = true;
            this.cbbChon.IntegralHeight = false;
            this.cbbChon.Location = new System.Drawing.Point(19, 167);
            this.cbbChon.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cbbChon.Name = "cbbChon";
            this.cbbChon.Size = new System.Drawing.Size(356, 26);
            this.cbbChon.TabIndex = 11;
            this.cbbChon.SelectedIndexChanged += new System.EventHandler(this.cbbChon_SelectedIndexChanged);
            // 
            // gbDSTKB
            // 
            this.gbDSTKB.Controls.Add(this.rjSapXep);
            this.gbDSTKB.Controls.Add(this.lvTKB);
            this.gbDSTKB.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDSTKB.ForeColor = System.Drawing.Color.Brown;
            this.gbDSTKB.Location = new System.Drawing.Point(6, 241);
            this.gbDSTKB.Name = "gbDSTKB";
            this.gbDSTKB.Size = new System.Drawing.Size(822, 362);
            this.gbDSTKB.TabIndex = 12;
            this.gbDSTKB.TabStop = false;
            this.gbDSTKB.Text = "Danh sách Thời Khoá Biểu";
            // 
            // rjSapXep
            // 
            this.rjSapXep.AutoSize = true;
            this.rjSapXep.BackColor = System.Drawing.Color.Gainsboro;
            this.rjSapXep.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.rjSapXep.BorderColor = System.Drawing.Color.Gray;
            this.rjSapXep.BorderRadius = 30;
            this.rjSapXep.BorderSize = 1;
            this.rjSapXep.FlatAppearance.BorderSize = 0;
            this.rjSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjSapXep.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjSapXep.ForeColor = System.Drawing.Color.Brown;
            this.rjSapXep.Location = new System.Drawing.Point(706, 307);
            this.rjSapXep.Name = "rjSapXep";
            this.rjSapXep.Size = new System.Drawing.Size(103, 36);
            this.rjSapXep.TabIndex = 36;
            this.rjSapXep.Text = "Sắp xếp";
            this.rjSapXep.TextColor = System.Drawing.Color.Brown;
            this.rjSapXep.UseVisualStyleBackColor = false;
            this.rjSapXep.Click += new System.EventHandler(this.rjSapXep_Click);
            // 
            // rjBack
            // 
            this.rjBack.BackColor = System.Drawing.Color.Gainsboro;
            this.rjBack.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.rjBack.BorderColor = System.Drawing.Color.Gray;
            this.rjBack.BorderRadius = 15;
            this.rjBack.BorderSize = 1;
            this.rjBack.FlatAppearance.BorderSize = 0;
            this.rjBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjBack.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjBack.ForeColor = System.Drawing.Color.Brown;
            this.rjBack.Location = new System.Drawing.Point(682, 622);
            this.rjBack.Name = "rjBack";
            this.rjBack.Size = new System.Drawing.Size(146, 37);
            this.rjBack.TabIndex = 10;
            this.rjBack.Text = "Trở lại";
            this.rjBack.TextColor = System.Drawing.Color.Brown;
            this.rjBack.UseVisualStyleBackColor = false;
            this.rjBack.Click += new System.EventHandler(this.rjBack_Click);
            // 
            // XemTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(840, 671);
            this.Controls.Add(this.gbDSTKB);
            this.Controls.Add(this.cbbChon);
            this.Controls.Add(this.rjBack);
            this.Controls.Add(this.lbChon);
            this.Controls.Add(this.cbbDang);
            this.Controls.Add(this.lbTieuDe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "XemTKB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemTKB";
            this.Load += new System.EventHandler(this.XemTKB_Load);
            this.gbDSTKB.ResumeLayout(false);
            this.gbDSTKB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.ComboBox cbbDang;
        private System.Windows.Forms.Label lbChon;
        private System.Windows.Forms.ListView lvTKB;
        private System.Windows.Forms.ColumnHeader colMaLich;
        private System.Windows.Forms.ColumnHeader colTenKH;
        private System.Windows.Forms.ColumnHeader colCap;
        private System.Windows.Forms.ColumnHeader colLop;
        private System.Windows.Forms.ColumnHeader colSoBuoiHoc;
        private System.Windows.Forms.ColumnHeader colSLHV;
        private System.Windows.Forms.ColumnHeader colThu;
        private System.Windows.Forms.ColumnHeader colKhungGioHoc;
        private System.Windows.Forms.ColumnHeader colPhong;
        private System.Windows.Forms.ColumnHeader colGV;
        private RJButton rjBack;
        private System.Windows.Forms.ComboBox cbbChon;
        private System.Windows.Forms.GroupBox gbDSTKB;
        private RJButton rjSapXep;
    }
}