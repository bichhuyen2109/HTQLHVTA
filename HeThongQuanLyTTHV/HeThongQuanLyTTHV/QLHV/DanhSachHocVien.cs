using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyTTHV.QLHV
{
    public partial class DanhSachHocVien : Form
    {
        public DanhSachHocVien()
        {
            InitializeComponent();
        }

        List<HocVien> hocViens = new List<HocVien>(1000);
        HocVien h;
        bool trangThai;

        internal List<HocVien> HocViens { get => hocViens; set => hocViens = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }

        private void StudentListFromFile()
        {
            string path = Application.StartupPath + @"\Data\StudentList.txt";
            hocViens.Clear();
            listHV.Items.Clear();
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader s = new StreamReader(path))
                    {
                        string line;
                        string[] attributes;
                        ListViewItem item;
                        while (s.Peek() >= 0)
                        {
                            line = s.ReadLine();
                            attributes = line.Split(new string[] { "#" }, StringSplitOptions.None);
                            item = new ListViewItem(attributes);
                            listHV.Items.Add(item);
                            HocVien h = new HocVien(attributes[0], attributes[1], attributes[2],
                            attributes[3], attributes[4], attributes[5], attributes[6], attributes[7],
                            attributes[8], attributes[9]);
                            HocViens.Add(h);
                        }
                    }
                    txtSum.Text = HocViens.Count.ToString();
                }
                else
                    MessageBox.Show("Danh sách rỗng!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            trangThai = true;
            this.Close();
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

        private void DanhSachHocVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trangThai && MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void DanhSachHocVien_Load(object sender, EventArgs e)
        {
            StudentListFromFile();
            btDel.Visible = btEdit.Visible = false;
            trangThai = false;
            foreach (ColumnHeader item in listHV.Columns)
            {
                switch (item.Index)
                {
                    case 0:
                    case 5:
                    case 2:
                        item.Width = (int)(listHV.Width * (0.105));
                        break;
                    case 1:
                    case 4:
                    case 6:
                        item.Width = (int)(listHV.Width * (0.128));
                        break;
                    default:
                        item.Width = (int)(listHV.Width * (0.075));
                        break;
                }                    
            }
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            string[] attributes;
            listHV.Items.Clear();
            foreach (HocVien h in HocViens)
            {
                HocViens.Sort((x1, x2) =>
                {
                    return x1.Name.CompareTo(x2.Name);
                });
            }
            foreach (HocVien h in HocViens)
            {
                attributes = new string[] { h.Id, h.Name, h.Dob, h.Gender, h.Email, h.PhoneNumber,
                    h.Adress, h.KhoaHoc, h.CapHoc, h.Lop };
                item = new ListViewItem(attributes);
                listHV.Items.Add(item);
            }
            
        }

        private void listHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listHV.SelectedItems.Count > 0)
            {
                btEdit.Visible = btDel.Visible = true;
                h = new HocVien(listHV.SelectedItems[0].SubItems[0].Text, listHV.SelectedItems[0].SubItems[1].Text,
                listHV.SelectedItems[0].SubItems[2].Text, listHV.SelectedItems[0].SubItems[3].Text, listHV.SelectedItems[0].SubItems[4].Text,
                listHV.SelectedItems[0].SubItems[5].Text, listHV.SelectedItems[0].SubItems[6].Text, listHV.SelectedItems[0].SubItems[7].Text,
                listHV.SelectedItems[0].SubItems[8].Text, listHV.SelectedItems[0].SubItems[9].Text);
            }
            else
            {
                btEdit.Visible = btDel.Visible = false;
            }    
                
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            ThongTinHocVien fTTHV = new ThongTinHocVien();
            if (listHV.SelectedItems.Count > 0)
            {
                Button ctrl = (Button)sender;
                switch (ctrl.Name)
                {
                    case "btEdit":
                        fTTHV.ChucNang = "Edit";
                        break;
                    case "btDel":
                        fTTHV.ChucNang = "Delete";
                        break;
                    default:
                        fTTHV.ChucNang = "Add";
                        break;
                }
                fTTHV.HvSelected = new HocVien(h);
            }
            else
                fTTHV.ChucNang = "Add";
            this.Close();
            fTTHV.Show();
        }
    }
}
