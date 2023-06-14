using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongQuanLyTTHV;

namespace HeThongQuanLyTTHV.QLKQHT
{
    public partial class DSKQHT : Form
    {
        public DSKQHT()
        {
            InitializeComponent();
        }

        private void btThemm_Click(object sender, EventArgs e)
        {
            Them f = new Them();
            f.Chucnang = "add";
            f.Show();
        }

        private void btChinh_Click(object sender, EventArgs e)
        {
            Them f = new Them();
            f.Chucnang = "chinh";
            f.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Them f = new Them();
            f.Chucnang = "xoa"; 
            f.Show();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            XemDS f = new XemDS();
            f.Show();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    this.Close();
                    return true;
                case Keys.D1:
                    Them f = new Them();
                    f.Chucnang = "add";
                    f.Show();
                    return true;
                case Keys.D2:
                    Them c = new Them();
                    c.Chucnang = "chinh";
                    c.Show();
                    return true;
                case Keys.D3:
                    Them x = new Them();
                    x.Chucnang = "xoa";
                    x.Show();
                    return true;
                case Keys.D4:
                    XemDS d = new XemDS();
                    d.Show();
                    return true;
                case Keys.D5:
                    this.Close();
                    return true;
               

            }
            return base.ProcessDialogKey(keyData);
        }

        private void DSKQHT_Load(object sender, EventArgs e)
        {

        }
    }
}
