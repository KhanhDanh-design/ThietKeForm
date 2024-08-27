using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212390_DNTKhanh_Lab2_VD2
{
    internal class DoanhMucMonHoc
    {
        public ArrayList ds;
        public DoanhMucMonHoc()
        {
            ds = new ArrayList();
        }
        public MonHoc this[int index]
        {
            get { return ds[index] as MonHoc; }
            set { ds[index] = value; }
        }
        public void Them(MonHoc mh)
        {
            ds.Add(mh);
        }
        public override string ToString()
        {
            string s = "Danh sach mon hoc:";
            foreach (object mh in ds)
            {
                s += mh as MonHoc + ";";
            }
            return s;
        }

    }
}
