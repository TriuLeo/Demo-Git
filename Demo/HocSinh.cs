using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class HocSinh
    {
        private string hoTen;
        private string cmnd;
        private string diaChi;
        private string ngaySinh;

        public HocSinh(string hoTen, string cmnd, string diaChi, string ngaySinh)
        {
            this.hoTen = hoTen;
            this.cmnd = cmnd;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
        }
        public HocSinh() { }

    }
}
