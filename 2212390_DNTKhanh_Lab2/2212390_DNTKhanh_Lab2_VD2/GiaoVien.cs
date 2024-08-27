using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212390_DNTKhanh_Lab2_VD2
{
    internal class GiaoVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public DoanhMucMonHoc dsMoHoc;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string Mail;
        public GiaoVien()
        {
            dsMoHoc = new DoanhMucMonHoc();
            NgoaiNgu = new string[10];
        }
        public GiaoVien(string maso, string hoten, DateTime ngaysinh, DoanhMucMonHoc ds, string gt, string[] nn, string sdt, string mail)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.dsMoHoc = ds;
            this.GioiTinh = gt;
            this.NgoaiNgu = nn;
            this.SoDT = sdt;
            this.Mail = mail;
        }
        public override string ToString()
        {
            string s = "Mã số:" + MaSo + "\n" + "Họ tên:" + HoTen + "\n" + "Ngày sinh:" + NgaySinh.ToString() + "\n" + "Giới tính:" + GioiTinh + "\n" + "Số điện thoại:" + SoDT + "\n" + "Mail:" + Mail + "\n";
            string sngoaingu = "Ngoại ngữ:";
            foreach (string t in NgoaiNgu)
            {
                sngoaingu += t + ";";
            }
            string Monday = "Danh sách môn dạy:";
            foreach (MonHoc mh in dsMoHoc.ds)
                Monday += mh + ";";
            s += "\n" + sngoaingu + "\n" + Monday;
            return s;
        }

    }
}
