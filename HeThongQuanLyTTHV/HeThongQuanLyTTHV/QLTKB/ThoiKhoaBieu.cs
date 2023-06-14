using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyTTHV.QLTKB
{
    class ThoiKhoaBieu
    {
        private string maLich, tenKH, capLop, lop, thu, khungGioHoc, phong, tenGV;
        private int soBuoi, soLuongHV;

        public ThoiKhoaBieu()
        {
            maLich = tenKH = capLop = lop = thu = khungGioHoc = phong = tenGV = null;
            soBuoi = soLuongHV = 0;
        }

        public string MaLich { get => maLich; set => maLich = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string CapLop { get => capLop; set => capLop = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Thu { get => thu; set => thu = value; }
        public string KhungGioHoc { get => khungGioHoc; set => khungGioHoc = value; }
        public string Phong { get => phong; set => phong = value; }
        public string TenGV { get => tenGV; set => tenGV = value; }
        public int SoBuoi { get => soBuoi; set => soBuoi = value; }
        public int SoLuongHV { get => soLuongHV; set => soLuongHV = value; }

        public ThoiKhoaBieu(string maLich, string tenKH, string capLop, string lop, string soBuoi, string soLuongHV, string thu, string khungGioHoc, string phong, string tenGV)
        {
            this.MaLich = maLich;
            this.TenKH = tenKH;
            this.CapLop = capLop;
            this.Lop = lop;
            this.Thu = thu;
            this.KhungGioHoc = khungGioHoc;
            this.Phong = phong;
            this.TenGV = tenGV;
            try
            {
                this.SoBuoi = Int32.Parse(soBuoi);
                this.SoLuongHV = Int32.Parse(soLuongHV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ThoiKhoaBieu(ThoiKhoaBieu t)
        {
            this.maLich = t.maLich;
            this.tenKH = t.tenKH;
            this.capLop = t.capLop;
            this.lop = t.lop;
            this.thu = t.thu;
            this.khungGioHoc = t.khungGioHoc;
            this.phong = t.phong;
            this.tenGV = t.tenGV;
            this.soBuoi = t.soBuoi;
            this.soLuongHV = t.soLuongHV;
        }
    }
}
