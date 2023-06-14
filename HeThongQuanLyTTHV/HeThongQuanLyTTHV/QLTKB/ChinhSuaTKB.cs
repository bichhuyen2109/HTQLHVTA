using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace HeThongQuanLyTTHV.QLTKB
{
    public partial class ChinhSuaTKB : Form
    {
        public ChinhSuaTKB()
        {
            InitializeComponent();
        }

        List<ThoiKhoaBieu> listTKB = new List<ThoiKhoaBieu>(1000);

        int viTri = -1, vtXoa = -1;
        string path, text;

        private void DocFileDSTKB()
        {
            try
            {
                path = Application.StartupPath + @"\Data\DSTKB.txt";
                if (File.Exists(path))
                    using (StreamReader s = new StreamReader(path))
                    {
                        string line;
                        string[] attributes;
                        while (s.Peek() >= 0)
                        {
                            line = s.ReadLine();
                            attributes = line.Split(new string[] { "#" }, StringSplitOptions.None);
                            ThoiKhoaBieu t = new ThoiKhoaBieu(attributes[0], attributes[1], attributes[2],
                                attributes[3], attributes[4], attributes[5], attributes[6],
                                attributes[7], attributes[8], attributes[9]);
                            listTKB.Add(t);
                            lvDSKH.Items.Add(new ListViewItem(attributes));
                        }
                    }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void GhiFileDSTKB(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
            if (lvDSKH.Items.Count > 0)
                using (StreamWriter s = new StreamWriter(path))
                {
                    foreach (ListViewItem item in lvDSKH.Items)
                    {                        
                        s.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}#{7}#{8}#{9}",
                        item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text,
                        item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text,
                        item.SubItems[6].Text, item.SubItems[7].Text, item.SubItems[8].Text,
                        item.SubItems[9].Text);
                    }
                }
            else
                return;
        }

        private void CheckDataKH(string path, ComboBox box, string keys)
        {
            try
            {
                if (File.Exists(path))
                    using (StreamReader s = new StreamReader(path))
                    {
                        string line;
                        while (s.Peek() >= 0)
                        {
                            line = s.ReadLine();
                            if (line.StartsWith(keys))
                                box.Items.Add(line);
                        }
                    }
                else
                    MessageBox.Show("Không có dữ liệu cho khóa học", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ChinhSuaTKB_Load(object sender, EventArgs e)
        {
            rjMaLich.Focus();

            DocFileDSTKB();

            lvDSKH.View = View.Details;
            lvDSKH.GridLines = true;
            lvDSKH.FullRowSelect = true;

            path = Application.StartupPath + @"\Data\SubjectList.txt";
            cbbCTDT.Items.Clear();
            CheckDataKH(path, cbbCTDT, "");
            cbbCTDT.SelectedIndex = 0;
            cbbCapLop.Items.Add("----Chọn----");
            cbbCapLop.SelectedIndex = 0;
            cbbLop.Items.Add("----Chọn----");
            cbbLop.SelectedIndex = 0;

            //ComboBox chọn thứ
            cbbThu.Items.Add("----Chọn----");
            cbbThu.Items.Add("Thứ 2-4");
            cbbThu.Items.Add("Thứ 3-5");
            cbbThu.Items.Add("Thứ 4-6");
            cbbThu.Items.Add("Thứ 7-CN");
            cbbThu.SelectedIndex = 0;

            //ComboBox chọn khung giờ học
            cbbKhungGioHoc.Items.Add("----Chọn----");
            cbbKhungGioHoc.Items.Add("Từ 7:45 - 9:45");
            cbbKhungGioHoc.Items.Add("Từ 8:30 - 10:30");
            cbbKhungGioHoc.Items.Add("Từ 17:15 - 19:15");
            cbbKhungGioHoc.Items.Add("Từ 19:15 - 21:15");
            cbbKhungGioHoc.SelectedIndex = 0;
        }

        private void cbbCTDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCTDT.SelectedIndex != 0)
            {
                cbbCapLop.Items.Clear();
                cbbCapLop.Items.Add("----Chọn----");
                cbbCapLop.SelectedIndex = 0;
                text = cbbCTDT.SelectedItem.ToString();
                text = "K" + text.Substring(text.Length - 2, 2);
                path = Application.StartupPath + @"\Data\LevelList.txt";
                CheckDataKH(path, cbbCapLop, text);
            }
        }

        private void CbbCapLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCapLop.SelectedIndex != 0)
            {
                cbbLop.Items.Clear();
                cbbLop.Items.Add("----Chọn----");
                cbbLop.SelectedIndex = 0;
                text = cbbCapLop.SelectedItem.ToString();
                text = text.Substring(0, 5);
                path = Application.StartupPath + @"\Data\ClassList.txt";
                CheckDataKH(path, cbbLop, text);
            }
        }

        private int TimTKB(String maLich)
        {
            if (listTKB.Count > 0)
            {
                for (int i = 0; i < listTKB.Count; i++)
                {
                    if (listTKB[i].MaLich == maLich)
                        return i;
                }
                return -1;
            }
            return -1;
        }

        public void Clear()
        {
            rjMaLich.Texts = "";
            rjTenGV.Texts = "";
            rjSoBuoi.Texts = "";
            rjSLHV.Texts = "";
            rjPhong.Texts = "";
            cbbCTDT.SelectedIndex = 0;
            cbbThu.SelectedIndex = 0;
            cbbKhungGioHoc.SelectedIndex = 0;
            cbbCapLop.Items.Clear();
            cbbCapLop.Items.Add("----Chọn----");
            cbbCapLop.SelectedIndex = 0;
            cbbLop.Items.Clear();
            cbbLop.Items.Add("----Chọn----");
            cbbLop.SelectedIndex = 0;
        }

        private void rjXoa_Click(object sender, EventArgs e)
        {
            if (lvDSKH.SelectedItems.Count > 0)
            {
                lvDSKH.Items.Remove(lvDSKH.SelectedItems[0]);
            }
            else
            {
                if (vtXoa != -1)
                    lvDSKH.Items.RemoveAt(vtXoa);
                else
                    MessageBox.Show("Vui lòng chọn lịch cần xóa!");
            }
            Clear();
        }

        private void rjCapNhat_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(lvDSKH.SelectedItems.Count > 0)
            {
                lvDSKH.SelectedItems[i].SubItems[0].Text = rjMaLich.Texts;
                lvDSKH.SelectedItems[i].SubItems[1].Text = cbbCTDT.Text;
                lvDSKH.SelectedItems[i].SubItems[2].Text = cbbCapLop.Text;
                lvDSKH.SelectedItems[i].SubItems[3].Text = cbbLop.Text;
                lvDSKH.SelectedItems[i].SubItems[4].Text = rjSoBuoi.Texts;
                lvDSKH.SelectedItems[i].SubItems[5].Text = rjSLHV.Texts;
                lvDSKH.SelectedItems[i].SubItems[6].Text = cbbThu.Text;
                lvDSKH.SelectedItems[i].SubItems[7].Text = cbbKhungGioHoc.Text;
                lvDSKH.SelectedItems[i].SubItems[8].Text = rjPhong.Texts;
                lvDSKH.SelectedItems[i].SubItems[9].Text = rjTenGV.Texts;
            }    
            else
            {
                if (vtXoa != -1)
                {
                    lvDSKH.Items.RemoveAt(vtXoa);
                    System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(new string[] {
                                rjMaLich.Texts, cbbCTDT.Text, cbbCapLop.Text, cbbLop.Text, rjSoBuoi.Texts,
                                rjSLHV.Texts, cbbThu.Text, cbbKhungGioHoc.Text, rjPhong.Texts, rjTenGV.Texts});

                    this.lvDSKH.Items.Add(item);
                }
                else
                    MessageBox.Show("Vui lòng chọn lịch cần xóa!");
            }    
            Clear();
        }

        private void rjBack_Click(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\Data\DSTKB.txt";
            GhiFileDSTKB(path);
            this.Close();
        }

        private void lvDSKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSKH.SelectedItems.Count > 0)
            {
                rjMaLich.Texts = lvDSKH.SelectedItems[0].SubItems[0].Text;
                cbbCTDT.SelectedItem = lvDSKH.SelectedItems[0].SubItems[1].Text;
                cbbCapLop.SelectedItem = lvDSKH.SelectedItems[0].SubItems[2].Text;
                cbbLop.SelectedItem = lvDSKH.SelectedItems[0].SubItems[3].Text;
                rjSoBuoi.Texts = lvDSKH.SelectedItems[0].SubItems[4].Text;
                rjSLHV.Texts = lvDSKH.SelectedItems[0].SubItems[5].Text;
                cbbThu.SelectedItem = lvDSKH.SelectedItems[0].SubItems[6].Text;
                cbbKhungGioHoc.SelectedItem = lvDSKH.SelectedItems[0].SubItems[7].Text;
                rjPhong.Texts = lvDSKH.SelectedItems[0].SubItems[8].Text;
                rjTenGV.Texts = lvDSKH.SelectedItems[0].SubItems[9].Text;
            }
        }

        private void cbbCapLop_Click(object sender, EventArgs e)
        {
            viTri = TimTKB(rjMaLich.Texts);
            if (viTri != -1)
            {
                cbbCTDT.SelectedItem = listTKB[viTri].TenKH;
                cbbCapLop.SelectedItem = listTKB[viTri].CapLop;
                cbbLop.SelectedItem = listTKB[viTri].Lop;
                rjSoBuoi.Texts = listTKB[viTri].SoBuoi.ToString();
                rjPhong.Texts = listTKB[viTri].Phong;
                cbbThu.SelectedItem = listTKB[viTri].Thu;
                cbbKhungGioHoc.SelectedItem = listTKB[viTri].KhungGioHoc;
                rjSLHV.Texts = listTKB[viTri].SoLuongHV.ToString();
                rjTenGV.Texts = listTKB[viTri].TenGV;
                vtXoa = viTri;
            } 
        }
    }
}
