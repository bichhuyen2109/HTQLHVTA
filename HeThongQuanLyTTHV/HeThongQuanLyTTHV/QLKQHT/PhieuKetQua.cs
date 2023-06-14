using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyTTHV
{
    internal class PhieuKetQua
    {
        
        private string maPhieu, hoTen, capHoc, khoaHoc, lop, ngaysinh, gioiTinh, ghiChu, cccd, sdt;
        private double  diem;

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string CapHoc { get => capHoc; set => capHoc = value; }
        public string KhoaHoc { get => khoaHoc; set => khoaHoc = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public double Diem { get => diem; set => diem = value; }

        public PhieuKetQua()
        {
            MaPhieu = HoTen = CapHoc = KhoaHoc = Lop = Ngaysinh = GioiTinh = GhiChu = Cccd = Sdt = null;
            Diem=0;    
        }
        public PhieuKetQua(string maPhieu, string hoTen, string cccd, string capHoc, string khoaHoc, string lop,
            string sdt, string ngaySinh, string diem, string gioiTinh, string ghiChu)
        {
            //p.MaPhieu, p.HoTen, p.Cccd, p.CapHoc, p.KhoaHoc, p.Lop, p.Sdt, p.Ngaysinh,
            //p.Diem, p.GioiTinh, p.GhiChu
            this.MaPhieu = maPhieu;
            this.HoTen = hoTen;
            this.Cccd = cccd;
            this.CapHoc = capHoc;
            this.KhoaHoc = khoaHoc;
            this.Lop = lop;
            this.Sdt = sdt;
            this.Ngaysinh = ngaySinh;
            this.GioiTinh = gioiTinh;

            try
            {
                this.diem = double.Parse(diem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.GhiChu = ghiChu;
        }  
        public PhieuKetQua(double diem)
        {
            this.Diem = diem;
        }

        public PhieuKetQua(PhieuKetQua p)
        {
            this.MaPhieu = p.MaPhieu;
            this.HoTen=p.HoTen;
            this.Cccd = p.Cccd;
            this.CapHoc=p.CapHoc;   
            this.KhoaHoc=p.KhoaHoc; 
            this.Lop=p.Lop;
            this.Sdt = p.Sdt;
            this.Ngaysinh=p.Ngaysinh;   
            this.GioiTinh=p.GioiTinh;
            this.Diem = p.Diem;
            this.GhiChu = p.GhiChu;
        }
    }
}
