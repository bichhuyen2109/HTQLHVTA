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
using HeThongQuanLyTTHV;


namespace HeThongQuanLyTTHV.QLKQHT
{
    public partial class Them : Form
    {
        //Tạo biến chức năng
        private string chucnang;
        //Tạo list phiếu kết quả
        List<PhieuKetQua> listDSP = new List<PhieuKetQua>(1000);

        public string Chucnang { get => chucnang; set => chucnang = value; }
        internal List<PhieuKetQua> ListDSP { get => listDSP; set => listDSP = value; }

        public Them()
        {
            InitializeComponent();
        }

        string path, click;
        int viTri = -1, idVT;
        
        private int TimKiem(String x)
        {
            if (listDSP.Count > 0)
            {
                for (int i = 0; i < listDSP.Count; i++)
                {
                    if (listDSP[i].MaPhieu == x)
                        return i;
                }
                return -1;
            }

            return -1;
        }
       
        private void Reset()
        {
            txtCap.Text = txtCCCD.Text = txtDiem.Text = txtGhiChu.Text = txtHoTen.Text = txtKhoa.Text
                = txtLop.Text = txtMaPhieu.Text = txtSDT.Text = "";
            dtNgaySinh.Value = DateTime.Now;
            txtMaPhieu.Focus();
        }
      
        private void GhiFile(string path, List<PhieuKetQua> phieuKetQua)
        {
            if (File.Exists(path))
                File.Delete(path);
            if (listDSP.Count > 0)
                using (StreamWriter s = new StreamWriter(path))
                {
                    foreach (PhieuKetQua p in phieuKetQua)
                    {
                        if(p.GhiChu == String.Empty)
                            p.GhiChu = "None";
                        s.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}#{7}#{8}#{9}#{10}",
                        p.MaPhieu, p.HoTen, p.Cccd, p.CapHoc, p.KhoaHoc, p.Lop, p.Sdt, p.Ngaysinh,
                        p.Diem, p.GioiTinh, p.GhiChu);
                    }
                }
            else
                return;
        }
      
        private void DocFile()
        {
            try
            {
                path = Application.StartupPath + @"\Data\DSP.txt";
                if (File.Exists(path))
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
                            listDSP.Add(p);
                        }
                    }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Them_Load(object sender, EventArgs e)
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
            DocFile();
            if (chucnang == "add")
            {
                btXoa.Visible = false;
                btLuu.Visible = true;
            }
            if (chucnang =="xoa")
            {
                btLuu.Visible = false;
                btXoa.Visible = true;
            }
            if (chucnang=="chinh")
            {
                btLuu.Visible = true;
                btXoa.Visible = false;
            }
            
        }

        private void Thoat()
        {
            path = Application.StartupPath + @"\Data\DSP.txt";
            GhiFile(path, listDSP);
            this.Close();
        }

        private void btTroLai_Click(object sender, EventArgs e)
        {
            Thoat();
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập vào 1 số!");
            }
        }

        private void txtHoTen_Click(object sender, EventArgs e)
        {
            viTri = TimKiem(txtMaPhieu.Text);
            try
            {
                if (viTri != -1)
                {
                    if (chucnang == "add")
                    {
                        MessageBox.Show("Phiếu kết quả đã tồn tại!\nVui lòng chọn chức năng chỉnh sửa!",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Reset();

                    }

                    if (chucnang == "chinh" || chucnang == "xoa")
                    {
                        idVT = viTri;
                        txtHoTen.Text = listDSP[viTri].HoTen;
                        txtKhoa.Text = listDSP[viTri].KhoaHoc;
                        txtLop.Text = listDSP[viTri].Lop;
                        txtSDT.Text = listDSP[viTri].Sdt;
                        txtCap.Text = listDSP[viTri].CapHoc;
                        txtMaPhieu.Text = listDSP[viTri].MaPhieu;
                        txtGhiChu.Text = listDSP[viTri].GhiChu;
                        txtDiem.Text = listDSP[viTri].Diem.ToString();
                        dtNgaySinh.Value = DateTime.Parse(listDSP[viTri].Ngaysinh);
                        txtCCCD.Text = listDSP[viTri].Cccd;
                        if (listDSP[viTri].GioiTinh == "Nam")
                        {
                            rbNam.Checked = true;
                            rbNu.Checked = false;
                        }
                        else
                        {
                            rbNam.Checked = false;
                            rbNu.Checked = true;
                        }
                    } 
                }
                if(txtDiem.Text != String.Empty)
                {
                    double score = double.Parse(txtDiem.Text);
                    if(score > 10)
                    {
                        MessageBox.Show("Vui lòng nhập giá trị từ 0 đến 10!", "Notification",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDiem.Text = String.Empty;
                        txtDiem.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Luu()
        {
            //Xử lý không điền đủ thông tin
            try
            {
                if (string.IsNullOrEmpty(txtMaPhieu.Text) || string.IsNullOrEmpty(txtHoTen.Text)
                       || string.IsNullOrEmpty(txtCCCD.Text) || string.IsNullOrEmpty(txtDiem.Text)
                       || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtLop.Text)
                       || string.IsNullOrEmpty(txtKhoa.Text) || string.IsNullOrEmpty(txtCap.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                else
                {
                    string gTinh;

                    if (rbNam.Checked == true)
                    {
                        gTinh = "nam";
                    }
                    else
                    {
                        gTinh = "nữ";
                    }

                    string[] item = {txtMaPhieu.Text, txtHoTen.Text, txtCCCD.Text, txtCap.Text,
                            txtKhoa.Text, txtLop.Text, txtSDT.Text, dtNgaySinh.Value.ToString (),
                            txtDiem.Text, gTinh, txtGhiChu.Text};
                    PhieuKetQua p = new PhieuKetQua();
                    p.MaPhieu = item[0];
                    p.HoTen = item[1];
                    p.Cccd = item[2];
                    p.CapHoc = item[3];
                    p.KhoaHoc = item[4];
                    p.Lop = item[5];
                    p.Sdt = item[6];
                    p.Ngaysinh = item[7];
                    p.Diem = double.Parse(item[8]);
                    p.GioiTinh = item[9];
                    p.GhiChu = item[10];
                    if (chucnang == "add")
                    {
                        ListViewItem listp = new ListViewItem(item);
                        listView1.Items.Add(listp);
                        listDSP.Add(p);
                        Reset();
                        MessageBox.Show("lưu thành công");
                       
                    }
                    if (chucnang == "chinh")
                    {
                        listDSP.RemoveAt(idVT);
                        listDSP.Add(p);
                        if(listView1.SelectedItems.Count > 0)
                        {
                            listView1.SelectedItems[0].SubItems[0].Text = txtMaPhieu.Text;
                            listView1.SelectedItems[0].SubItems[1].Text = txtHoTen.Text;
                            listView1.SelectedItems[0].SubItems[2].Text = txtCCCD.Text;
                            listView1.SelectedItems[0].SubItems[3].Text = txtCap.Text;
                            listView1.SelectedItems[0].SubItems[4].Text = txtKhoa.Text;
                            listView1.SelectedItems[0].SubItems[5].Text = txtLop.Text;
                            listView1.SelectedItems[0].SubItems[6].Text =txtSDT.Text;
                            listView1.SelectedItems[0].SubItems[7].Text = dtNgaySinh.Value.ToString();
                            listView1.SelectedItems[0].SubItems[8].Text = txtDiem.Text;
                            listView1.SelectedItems[0].SubItems[9].Text = (rbNam.Checked) ? "nam" : "nữ";
                            listView1.SelectedItems[0].SubItems[10].Text = txtGhiChu.Text;
                            //tuong tu nef lafm di
                        }
                        MessageBox.Show("Sửa thành công!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                    }      
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            Luu(); 
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' ||
                (e.KeyChar == '.' && (txtDiem.Text.Length == 0 || txtDiem.Text.IndexOf('.') != -1))))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập vào 1 số thực!");
            }
        }

        private void Xoa()
        {
            if (viTri != -1 || click == "true")
            {
                listDSP.RemoveAt(idVT);
                MessageBox.Show("Xóa thành công!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                listView1.Items.RemoveAt(idVT);
                click = "";
            }
            else
            {
                txtMaPhieu.Focus();
                txtMaPhieu.SelectionStart = txtMaPhieu.Text.Length;
                MessageBox.Show("Phiếu kết quả không tồn tại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void Them_FormClosed(object sender, FormClosedEventArgs e)
        {
            path = Application.StartupPath + @"\Data\DSP.txt";
            GhiFile(path, listDSP);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i;
            i = listView1.FocusedItem.Index;
            txtMaPhieu.Text = listView1.Items[i].SubItems[0].Text;
            txtHoTen.Text = listView1.Items[i].SubItems[1].Text;
            txtCCCD.Text = listView1.Items[i].SubItems[2].Text;
            txtCap.Text = listView1.Items[i].SubItems[3].Text;
            txtKhoa.Text = listView1.Items[i].SubItems[4].Text;
            txtLop.Text = listView1.Items[i].SubItems[5].Text;
            txtSDT.Text = listView1.Items[i].SubItems[6].Text;
            dtNgaySinh.Text = listView1.Items[i].SubItems[7].Text;
            txtDiem.Text = listView1.Items[i].SubItems[8].Text;
            txtGhiChu.Text = listView1.Items[i].SubItems[10].Text;
            if (listView1.Items[i].SubItems[9].Text == "nam")
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
            click = "true";
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                
                case Keys.Enter: // enter là lưu file thì ở đây có rồi nè. thêm nữa để lam dì v?
                    if (chucnang=="add"||chucnang=="chinh")
                    {
                        Luu();
                    }
                    if (chucnang=="xoa")
                    {
                        Xoa();
                    }
                    return true;
                case Keys.Escape:
                    Thoat();    
                    return true;
                case Keys.Delete:
                    Reset();
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }  
}

