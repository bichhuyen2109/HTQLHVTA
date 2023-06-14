using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HeThongQuanLyTTHV.QLKQHT
{
    public partial class XemDS : Form
    {
        public XemDS()
        {
            InitializeComponent();
        }
        List<PhieuKetQua> listDS = new List<PhieuKetQua>(1000);
        private void SapXep()
        {
            ListViewItem item;
            string[] att;
            listView1.Items.Clear();
            foreach (PhieuKetQua p in listDS)
            {
                listDS.Sort((x1, x2) =>
                {
                    return x1.HoTen.CompareTo(x2.HoTen);
                });
            }
            foreach (PhieuKetQua p in listDS)
            {
                att = new string[] { p.MaPhieu, p.HoTen, p.Cccd, p.CapHoc, p.KhoaHoc, p.Lop,
                    p.Sdt, p.Ngaysinh, p.Diem.ToString(), p.GioiTinh, p.GhiChu};
                item = new ListViewItem(att);
                listView1.Items.Add(item);
            }
        }
        private void btSapXep_Click(object sender, EventArgs e)
        {
            SapXep();   
        }

        private void XemDS_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Data\DSP.txt";
            try
            {
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;

                listView1.Columns[0].Width = (int)(listView1.Width * 0.09);
                listView1.Columns[1].Width = (int)(listView1.Width * 0.12);
                listView1.Columns[2].Width = (int)(listView1.Width * 0.1);
                listView1.Columns[3].Width = (int)(listView1.Width * 0.1);
                listView1.Columns[4].Width = (int)(listView1.Width * 0.1);
                listView1.Columns[5].Width = (int)(listView1.Width * 0.1);
                listView1.Columns[6].Width = (int)(listView1.Width * 0.1);
                listView1.Columns[7].Width = (int)(listView1.Width * 0.1);
                listView1.Columns[8].Width = (int)(listView1.Width * 0.08);
                listView1.Columns[9].Width = (int)(listView1.Width * 0.1);
                listView1.Columns[10].Width = (int)(listView1.Width * 0.1);

                if (File.Exists(path))
                {
                    using (StreamReader s = new StreamReader(path))
                    {
                        string line;
                        string[] att;
                        ListViewItem item;
                        while (s.Peek() >= 0)
                        {
                            line = s.ReadLine();
                            att = line.Split(new string[] { "#" }, StringSplitOptions.None);
                            item = new ListViewItem(att);
                            listView1.Items.Add(item);
                            PhieuKetQua p = new PhieuKetQua(att[0], att[1], att[2],att[3], att[4], 
                                att[5], att[6], att[7],att[8], att[9], att[10]);
                            listDS.Add(p);
                        }
                    }
                }
                else
                    MessageBox.Show("Danh sách rỗng!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // danh sách rỗng khi list.count > 0. nếu file chưa tồn tại thì báo chưa tồn tại chứ
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    SapXep();
                    return true;
                case Keys.Escape:
                    this.Close();
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
