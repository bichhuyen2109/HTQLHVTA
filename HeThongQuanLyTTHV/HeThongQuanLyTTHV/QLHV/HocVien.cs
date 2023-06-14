using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyTTHV.QLHV
{
    class HocVien
    {
        private string id, name, dob, gender, email, phoneNumber, adress, khoaHoc, capHoc, lop;

        public HocVien()
        {
            id = name = dob = gender = email = phoneNumber = adress = null;
            khoaHoc = capHoc = lop = null;
        }

        public HocVien(string id, string name, string dob, string gender, string email, 
            string phoneNumber, string adress, string khoaHoc, string capHoc, string lop)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
            this.gender = gender;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.adress = adress;
            this.khoaHoc = khoaHoc;
            this.capHoc = capHoc;
            this.lop = lop;
        }

        public HocVien(HocVien h)
        {
            this.id = h.id;
            this.name = h.name;
            this.dob = h.dob;
            this.gender = h.gender;
            this.email = h.email;
            this.phoneNumber = h.phoneNumber;
            this.adress = h.adress;
            this.khoaHoc = h.khoaHoc;
            this.capHoc = h.capHoc;
            this.lop = h.lop;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Adress { get => adress; set => adress = value; }
        public string KhoaHoc { get => khoaHoc; set => khoaHoc = value; }
        public string CapHoc { get => capHoc; set => capHoc = value; }
        public string Lop { get => lop; set => lop = value; }
    }
}
