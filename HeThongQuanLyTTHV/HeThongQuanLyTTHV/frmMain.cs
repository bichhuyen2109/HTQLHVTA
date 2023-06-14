using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyTTHV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void quanLyTTHV_Click(object sender, EventArgs e)
        {
            QLHV.DanhSachHocVien mainQLHV = new QLHV.DanhSachHocVien();
            mainQLHV.Show();
        }

        private void quanLyKQHT_Click(object sender, EventArgs e)
        {
            QLKQHT.DSKQHT main = new QLKQHT.DSKQHT();
            main.Show();
        }
        private void quanLyTKB_Click(object sender, EventArgs e)
        {
            QLTKB.QLLH main = new QLTKB.QLLH();
            main.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FontFamily f = new FontFamily("Courier New");
            labelTitle.Width = ClientRectangle.Width;
            labelTitle.Height = ClientRectangle.Height - menuMain.Height;
            labelTitle.Font = new Font(f, 40);
            menuMain.Font = new Font(f, 13);
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

    }
}
