
namespace HeThongQuanLyTTHV.QLHV
{
    partial class DanhSachHocVien
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.listHV = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.khoaHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.capHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btSort = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbSum = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Brown;
            this.lbTitle.Location = new System.Drawing.Point(2, 1);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1387, 81);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "DANH SÁCH HỌC VIÊN";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listHV
            // 
            this.listHV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.name,
            this.DOB,
            this.gender,
            this.email,
            this.phoneNumber,
            this.adress,
            this.khoaHoc,
            this.capHoc,
            this.lop});
            this.listHV.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHV.HideSelection = false;
            this.listHV.Location = new System.Drawing.Point(4, 85);
            this.listHV.Name = "listHV";
            this.listHV.Size = new System.Drawing.Size(1385, 560);
            this.listHV.TabIndex = 9;
            this.listHV.UseCompatibleStateImageBehavior = false;
            this.listHV.View = System.Windows.Forms.View.Details;
            this.listHV.SelectedIndexChanged += new System.EventHandler(this.listHV_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "Số CCCD";
            this.ID.Width = 104;
            // 
            // name
            // 
            this.name.Text = "Họ và tên";
            this.name.Width = 230;
            // 
            // DOB
            // 
            this.DOB.Text = "Ngày sinh";
            this.DOB.Width = 147;
            // 
            // gender
            // 
            this.gender.Text = "Giới tính";
            this.gender.Width = 129;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 196;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Text = "Số điện thoại";
            this.phoneNumber.Width = 183;
            // 
            // adress
            // 
            this.adress.Text = "Địa chỉ";
            this.adress.Width = 265;
            // 
            // khoaHoc
            // 
            this.khoaHoc.Text = "Khóa học";
            this.khoaHoc.Width = 120;
            // 
            // capHoc
            // 
            this.capHoc.Text = "Cấp học";
            this.capHoc.Width = 112;
            // 
            // lop
            // 
            this.lop.Text = "Lớp";
            this.lop.Width = 116;
            // 
            // btSort
            // 
            this.btSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSort.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSort.Location = new System.Drawing.Point(1024, 668);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(187, 55);
            this.btSort.TabIndex = 5;
            this.btSort.Text = "Sắp xếp (A-Z)";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // btExit
            // 
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(1244, 668);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(107, 55);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSum.Location = new System.Drawing.Point(38, 685);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(322, 24);
            this.lbSum.TabIndex = 7;
            this.lbSum.Text = "Tổng số lượng học viên: ";
            // 
            // txtSum
            // 
            this.txtSum.BackColor = System.Drawing.Color.White;
            this.txtSum.Enabled = false;
            this.txtSum.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.Location = new System.Drawing.Point(351, 680);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(100, 32);
            this.txtSum.TabIndex = 8;
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(655, 668);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(90, 55);
            this.btEdit.TabIndex = 11;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDel
            // 
            this.btDel.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.Location = new System.Drawing.Point(779, 668);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(90, 55);
            this.btDel.TabIndex = 11;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(899, 668);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(90, 55);
            this.btAdd.TabIndex = 11;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // DanhSachHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1394, 745);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lbSum);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.listHV);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "DanhSachHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Học Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DanhSachHocVien_FormClosing);
            this.Load += new System.EventHandler(this.DanhSachHocVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ListView listHV;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader DOB;
        private System.Windows.Forms.ColumnHeader gender;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader phoneNumber;
        private System.Windows.Forms.ColumnHeader adress;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.ColumnHeader khoaHoc;
        private System.Windows.Forms.ColumnHeader capHoc;
        private System.Windows.Forms.ColumnHeader lop;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btAdd;
    }
}