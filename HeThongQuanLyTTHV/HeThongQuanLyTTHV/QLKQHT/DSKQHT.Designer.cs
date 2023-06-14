namespace HeThongQuanLyTTHV.QLKQHT
{
    partial class DSKQHT
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
            this.btThemm = new System.Windows.Forms.Button();
            this.btChinh = new System.Windows.Forms.Button();
            this.btXem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThemm
            // 
            this.btThemm.BackColor = System.Drawing.Color.LightCyan;
            this.btThemm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThemm.Location = new System.Drawing.Point(60, 57);
            this.btThemm.Margin = new System.Windows.Forms.Padding(2);
            this.btThemm.Name = "btThemm";
            this.btThemm.Size = new System.Drawing.Size(197, 62);
            this.btThemm.TabIndex = 0;
            this.btThemm.Text = "Thêm";
            this.btThemm.UseVisualStyleBackColor = false;
            this.btThemm.Click += new System.EventHandler(this.btThemm_Click);
            // 
            // btChinh
            // 
            this.btChinh.BackColor = System.Drawing.Color.LightCyan;
            this.btChinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btChinh.Location = new System.Drawing.Point(311, 57);
            this.btChinh.Margin = new System.Windows.Forms.Padding(2);
            this.btChinh.Name = "btChinh";
            this.btChinh.Size = new System.Drawing.Size(199, 62);
            this.btChinh.TabIndex = 1;
            this.btChinh.Text = "Chỉnh Sửa";
            this.btChinh.UseVisualStyleBackColor = false;
            this.btChinh.Click += new System.EventHandler(this.btChinh_Click);
            // 
            // btXem
            // 
            this.btXem.BackColor = System.Drawing.Color.LightCyan;
            this.btXem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btXem.Location = new System.Drawing.Point(313, 161);
            this.btXem.Margin = new System.Windows.Forms.Padding(2);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(197, 62);
            this.btXem.TabIndex = 3;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = false;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btXem);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btChinh);
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btThemm);
            this.groupBox1.Location = new System.Drawing.Point(142, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 372);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.LightCyan;
            this.btXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btXoa.Location = new System.Drawing.Point(60, 161);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(197, 62);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.LightCyan;
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThoat.Location = new System.Drawing.Point(193, 260);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(199, 62);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 43);
            this.label1.TabIndex = 51;
            this.label1.Text = "Quản Lý Phiếu Kết Quả Học Tập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DSKQHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DSKQHT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSKQHT";
            this.Load += new System.EventHandler(this.DSKQHT_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btThemm;
        private System.Windows.Forms.Button btChinh;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXoa;
    }
}