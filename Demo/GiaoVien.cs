using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class GiaoVien : Person
    {
        public GiaoVien(string hoTen, string cmnd, string diaChi, string ngaySinh)
        {
            this.hoTen = hoTen;
            this.cmnd = cmnd;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
        }
        public GiaoVien() { }
    }
}
