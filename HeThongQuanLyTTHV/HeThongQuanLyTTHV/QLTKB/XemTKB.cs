using HeThongQuanLyTTHV.QLHV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = System.Windows.Forms.Application;
using ComboBox = System.Windows.Forms.ComboBox;

namespace HeThongQuanLyTTHV.QLTKB
{
    public partial class XemTKB : Form
    {
        public XemTKB()
        {
            InitializeComponent();
        }

        List<ThoiKhoaBieu> listTKB = new List<ThoiKhoaBieu>(1000);
        List<ThoiKhoaBieu> listTKB_tam = new List<ThoiKhoaBieu>(1000);
        //Để sắp xếp vào đây

        string pathKhoa;
        string pathCap;
        string pathLop;
        string text;

        private void DocFileDSTKB()
        {
            try
            {
                string path = Application.StartupPath + @"\Data\DSTKB.txt";
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
                        }
                    }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void XemTKB_Load(object sender, EventArgs e)
        {
            cbbDang.Focus();
            DocFileDSTKB();

            //cbbDang.Height = cbbChon.Height = 50;

            //ComboBox chọn dạng xem TKB
            cbbDang.Items.Add("----Chọn----");
            cbbDang.Items.Add("Xem theo khoá học");
            cbbDang.Items.Add("Xem theo cấp học");
            cbbDang.Items.Add("Xem theo lớp học");
            cbbDang.SelectedIndex = 0;

            //ComboBox chọn item xem TKB
            cbbChon.Items.Clear();
            cbbChon.Items.Add("----Chọn----");
            cbbChon.SelectedIndex = 0;

            //ListView - xem tkb các khoá học
            lvTKB.View = View.Details;
            lvTKB.GridLines = true;
            lvTKB.FullRowSelect = true;

            gbDSTKB.Width = ClientRectangle.Width - 10;
            lvTKB.Width = gbDSTKB.Width -10;
        }

        private void cbbDang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDang.SelectedIndex != 0)
            {
                lvTKB.Items.Clear();
                cbbChon.Items.Clear();
                cbbChon.Items.Add("-----Chọn-----");
                cbbChon.SelectedIndex = 0;
                text = cbbDang.SelectedItem.ToString();
                switch (cbbDang.Text)
                {
                    case "Xem theo khoá học":
                        pathKhoa = Application.StartupPath + @"\Data\SubjectList.txt";
                        try
                        {
                            if (File.Exists(pathKhoa))
                            {
                                using (StreamReader s = new StreamReader(pathKhoa))
                                {
                                    while (s.Peek() >= 0)
                                    {
                                        cbbChon.Items.Add(s.ReadLine());
                                    }
                                    cbbChon.Items.RemoveAt(1);
                                }
                            }                            
                            else
                                MessageBox.Show("Danh sách rỗng!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case "Xem theo cấp học":
                        pathCap = Application.StartupPath + @"\Data\LevelList.txt";
                        try
                        {
                            if (File.Exists(pathCap))
                            {
                                using (StreamReader s = new StreamReader(pathCap))
                                {
                                    string line;
                                    while (s.Peek() >= 0)
                                    {
                                        cbbChon.Items.Add(s.ReadLine());
                                    }
                                }
                            }
                            else
                                MessageBox.Show("Danh sách rỗng!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case "Xem theo lớp học":
                        pathLop = Application.StartupPath + @"\Data\ClassList.txt";
                        try
                        {
                            if (File.Exists(pathLop))
                            {
                                using (StreamReader s = new StreamReader(pathLop))
                                {
                                    string line;
                                    while (s.Peek() >= 0)
                                    {
                                        cbbChon.Items.Add(s.ReadLine());
                                    }
                                }
                            }
                            else
                                MessageBox.Show("Danh sách rỗng!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        break;
                    default:
                        break;
                }

            }

        }

        private void cbbChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Data\DSTKB.txt";
            if (cbbChon.SelectedIndex != 0)
            {
                lvTKB.Items.Clear();
                listTKB_tam.Clear();
                text = cbbChon.SelectedItem.ToString();
                switch (cbbDang.Text)
                {
                    case "Xem theo khoá học":
                        foreach (ThoiKhoaBieu item in listTKB)
                        {
                            if (item.TenKH == text)
                            {
                                string[] attributes = new string[]
                                {item.MaLich, item.TenKH, item.CapLop, item.Lop, item.SoBuoi.ToString(),
                                    item.SoLuongHV.ToString(), item.Thu, item.KhungGioHoc, item.Phong, item.TenGV};
                                lvTKB.Items.Add(new ListViewItem(attributes));
                                listTKB_tam.Add(item);
                            }
                        }
                        break;
                    case "Xem theo cấp học":
                        foreach (ThoiKhoaBieu item in listTKB)
                        {
                            if (item.CapLop == text)
                            {
                                string[] attributes = new string[]
                                {item.MaLich, item.TenKH, item.CapLop, item.Lop, item.SoBuoi.ToString(),
                                    item.SoLuongHV.ToString(), item.Thu, item.KhungGioHoc, item.Phong, item.TenGV};
                                lvTKB.Items.Add(new ListViewItem(attributes));
                                listTKB_tam.Add(item);
                            }
                        }
                        break;
                    case "Xem theo lớp học":
                        foreach (ThoiKhoaBieu item in listTKB)
                        {
                            if (item.Lop == text)
                            {
                                string[] attributes = new string[]
                                {item.MaLich, item.TenKH, item.CapLop, item.Lop, item.SoBuoi.ToString(),
                                    item.SoLuongHV.ToString(), item.Thu, item.KhungGioHoc, item.Phong, item.TenGV};
                                lvTKB.Items.Add(new ListViewItem(attributes));
                                listTKB_tam.Add(item);
                            }
                        }
                        break;
                    default:
                        break;
                }

            }
        }

        private void rjSapXep_Click(object sender, EventArgs e)
        {
            switch (cbbDang.Text)
            {
                case "Xem theo khoá học":
                    //Sắp xếp theo tên khoá học
                    ListViewItem item;
                    string[] attributes;
                    lvTKB.Items.Clear();
                    foreach (ThoiKhoaBieu t in listTKB_tam)
                    {
                        listTKB_tam.Sort((x1, x2) =>
                        {
                            return x1.CapLop.CompareTo(x2.CapLop);
                        });
                    }
                    foreach (ThoiKhoaBieu t in listTKB_tam)
                    {
                        attributes = new string[] { t.MaLich, t.TenKH, t.CapLop, t.Lop, t.Thu,
                                            t.KhungGioHoc, t.Phong, t.TenGV};
                        item = new ListViewItem(attributes);
                        lvTKB.Items.Add(item);
                    }
                    break;
                case "Xem theo cấp học":
                    //Sắp xếp theo tên khoá học
                    ListViewItem item1;
                    string[] attributes1;
                    lvTKB.Items.Clear();
                    foreach (ThoiKhoaBieu t in listTKB_tam)
                    {
                        listTKB_tam.Sort((x1, x2) =>
                        {
                            return x1.TenKH.CompareTo(x2.TenKH);
                        });
                    }
                    foreach (ThoiKhoaBieu t in listTKB_tam)
                    {
                        attributes1 = new string[] { t.MaLich, t.TenKH, t.CapLop, t.Lop, t.Thu,
                                            t.KhungGioHoc, t.Phong, t.TenGV};
                        item1 = new ListViewItem(attributes1);
                        lvTKB.Items.Add(item1);
                    }
                    break;
                case "Xem theo lớp học":
                    ListViewItem item2;
                    string[] attributes2;
                    lvTKB.Items.Clear();
                    foreach (ThoiKhoaBieu t in listTKB_tam)
                    {
                        listTKB_tam.Sort((x1, x2) =>
                        {
                            return x1.TenKH.CompareTo(x2.TenKH);
                        });
                    }
                    foreach (ThoiKhoaBieu t in listTKB_tam)
                    {
                        attributes2 = new string[] { t.MaLich, t.TenKH, t.CapLop, t.Lop, t.Thu,
                                            t.KhungGioHoc, t.Phong, t.TenGV};
                        item2 = new ListViewItem(attributes2);
                        lvTKB.Items.Add(item2);
                    }
                    break;
                default:
                    break;
            }            
        }

        private void rjBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbChon_Click(object sender, EventArgs e)
        {

        }
    }
}
