
namespace HeThongQuanLyTTHV
{
    partial class frmMain
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTTHV = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyKQHT = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTKB = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTitle = new System.Windows.Forms.Label();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.exit});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuMain.Size = new System.Drawing.Size(644, 27);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyTTHV,
            this.quanLyKQHT,
            this.quanLyTKB});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // quanLyTTHV
            // 
            this.quanLyTTHV.Name = "quanLyTTHV";
            this.quanLyTTHV.Size = new System.Drawing.Size(310, 22);
            this.quanLyTTHV.Text = "Quản lý thông tin học viên";
            this.quanLyTTHV.Click += new System.EventHandler(this.quanLyTTHV_Click);
            // 
            // quanLyKQHT
            // 
            this.quanLyKQHT.Name = "quanLyKQHT";
            this.quanLyKQHT.Size = new System.Drawing.Size(310, 22);
            this.quanLyKQHT.Text = "Quản lý kết quả học tập";
            this.quanLyKQHT.Click += new System.EventHandler(this.quanLyKQHT_Click);
            // 
            // quanLyTKB
            // 
            this.quanLyTKB.Name = "quanLyTKB";
            this.quanLyTKB.Size = new System.Drawing.Size(310, 22);
            this.quanLyTKB.Text = "Quản lý thời khóa biểu";
            this.quanLyTKB.Click += new System.EventHandler(this.quanLyTKB_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(65, 21);
            this.exit.Text = "Thoát";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Brown;
            this.labelTitle.Location = new System.Drawing.Point(0, 27);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(644, 441);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Hệ thống quản lý học viên";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 471);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý học viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyTTHV;
        private System.Windows.Forms.ToolStripMenuItem quanLyKQHT;
        private System.Windows.Forms.ToolStripMenuItem quanLyTKB;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.Label labelTitle;
    }
}