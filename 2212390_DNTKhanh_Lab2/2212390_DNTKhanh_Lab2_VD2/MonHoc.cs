using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212390_DNTKhanh_Lab2_VD2
{
    internal class MonHoc
    {
        public int Id { get; set; }
        public string TenMH { get; set; }
        public int soTC { get; set; }
        public MonHoc()
        {
        }
        public MonHoc(string ten)
        {
            this.TenMH = ten;
        }
        public MonHoc(int id, string ten, int tc)
        {
            this.Id = id;
            this.TenMH = ten;
            this.soTC = tc;
        }
        public override string ToString()
        {
            return TenMH;
        }
    }
}
