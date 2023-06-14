
namespace HeThongQuanLyTTHV.QLTKB
{
    partial class QLLH
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
            this.gbChucNang = new System.Windows.Forms.GroupBox();
            this.rjXemTKB = new HeThongQuanLyTTHV.QLTKB.RJButton();
            this.rjChinhTKB = new HeThongQuanLyTTHV.QLTKB.RJButton();
            this.rjThemTKB = new HeThongQuanLyTTHV.QLTKB.RJButton();
            this.rjThoat = new HeThongQuanLyTTHV.QLTKB.RJButton();
            this.gbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieuDe.Enabled = false;
            this.lbTieuDe.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(582, 111);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "QUẢN LÝ LỊCH HỌC";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbChucNang
            // 
            this.gbChucNang.Controls.Add(this.rjXemTKB);
            this.gbChucNang.Controls.Add(this.rjChinhTKB);
            this.gbChucNang.Controls.Add(this.rjThemTKB);
            this.gbChucNang.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChucNang.Location = new System.Drawing.Point(13, 118);
            this.gbChucNang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbChucNang.Size = new System.Drawing.Size(556, 309);
            this.gbChucNang.TabIndex = 1;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Chọn Chức Năng";
            // 
            // rjXemTKB
            // 
            this.rjXemTKB.BackColor = System.Drawing.Color.LightPink;
            this.rjXemTKB.BackgroundColor = System.Drawing.Color.LightPink;
            this.rjXemTKB.BorderColor = System.Drawing.Color.IndianRed;
            this.rjXemTKB.BorderRadius = 40;
            this.rjXemTKB.BorderSize = 1;
            this.rjXemTKB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjXemTKB.FlatAppearance.BorderSize = 0;
            this.rjXemTKB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjXemTKB.ForeColor = System.Drawing.Color.Brown;
            this.rjXemTKB.Location = new System.Drawing.Point(86, 140);
            this.rjXemTKB.Name = "rjXemTKB";
            this.rjXemTKB.Size = new System.Drawing.Size(382, 40);
            this.rjXemTKB.TabIndex = 0;
            this.rjXemTKB.Text = "Xem TKB";
            this.rjXemTKB.TextColor = System.Drawing.Color.Brown;
            this.rjXemTKB.UseVisualStyleBackColor = false;
            this.rjXemTKB.Click += new System.EventHandler(this.RjThemTKB_Click);
            // 
            // rjChinhTKB
            // 
            this.rjChinhTKB.AutoSize = true;
            this.rjChinhTKB.BackColor = System.Drawing.Color.LightPink;
            this.rjChinhTKB.BackgroundColor = System.Drawing.Color.LightPink;
            this.rjChinhTKB.BorderColor = System.Drawing.Color.IndianRed;
            this.rjChinhTKB.BorderRadius = 40;
            this.rjChinhTKB.BorderSize = 1;
            this.rjChinhTKB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjChinhTKB.FlatAppearance.BorderSize = 0;
            this.rjChinhTKB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjChinhTKB.ForeColor = System.Drawing.Color.Brown;
            this.rjChinhTKB.Location = new System.Drawing.Point(86, 198);
            this.rjChinhTKB.Name = "rjChinhTKB";
            this.rjChinhTKB.Size = new System.Drawing.Size(382, 47);
            this.rjChinhTKB.TabIndex = 0;
            this.rjChinhTKB.Text = "Chỉnh sửa TKB";
            this.rjChinhTKB.TextColor = System.Drawing.Color.Brown;
            this.rjChinhTKB.UseVisualStyleBackColor = false;
            this.rjChinhTKB.Click += new System.EventHandler(this.RjThemTKB_Click);
            // 
            // rjThemTKB
            // 
            this.rjThemTKB.BackColor = System.Drawing.Color.LightPink;
            this.rjThemTKB.BackgroundColor = System.Drawing.Color.LightPink;
            this.rjThemTKB.BorderColor = System.Drawing.Color.IndianRed;
            this.rjThemTKB.BorderRadius = 40;
            this.rjThemTKB.BorderSize = 1;
            this.rjThemTKB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjThemTKB.FlatAppearance.BorderSize = 0;
            this.rjThemTKB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjThemTKB.ForeColor = System.Drawing.Color.Brown;
            this.rjThemTKB.Location = new System.Drawing.Point(86, 84);
            this.rjThemTKB.Name = "rjThemTKB";
            this.rjThemTKB.Size = new System.Drawing.Size(382, 40);
            this.rjThemTKB.TabIndex = 0;
            this.rjThemTKB.Text = "Thêm TKB";
            this.rjThemTKB.TextColor = System.Drawing.Color.Brown;
            this.rjThemTKB.UseVisualStyleBackColor = false;
            this.rjThemTKB.Click += new System.EventHandler(this.RjThemTKB_Click);
            // 
            // rjThoat
            // 
            this.rjThoat.BackColor = System.Drawing.Color.Gainsboro;
            this.rjThoat.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.rjThoat.BorderColor = System.Drawing.Color.Gray;
            this.rjThoat.BorderRadius = 15;
            this.rjThoat.BorderSize = 1;
            this.rjThoat.FlatAppearance.BorderSize = 0;
            this.rjThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjThoat.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjThoat.ForeColor = System.Drawing.Color.Brown;
            this.rjThoat.Location = new System.Drawing.Point(418, 458);
            this.rjThoat.Name = "rjThoat";
            this.rjThoat.Size = new System.Drawing.Size(150, 40);
            this.rjThoat.TabIndex = 2;
            this.rjThoat.Text = "Thoát";
            this.rjThoat.TextColor = System.Drawing.Color.Brown;
            this.rjThoat.UseVisualStyleBackColor = false;
            this.rjThoat.Click += new System.EventHandler(this.RjThoat_Click);
            // 
            // QLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(582, 509);
            this.Controls.Add(this.rjThoat);
            this.Controls.Add(this.gbChucNang);
            this.Controls.Add(this.lbTieuDe);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Brown;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QLLH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lịch học";
            this.Load += new System.EventHandler(this.QLLH_Load);
            this.gbChucNang.ResumeLayout(false);
            this.gbChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.GroupBox gbChucNang;
        private RJButton rjXemTKB;
        private RJButton rjChinhTKB;
        private RJButton rjThemTKB;
        private RJButton rjThoat;
    }
}

