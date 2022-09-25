using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diem_danh
{
    class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;

        public TaiKhoan() // constructor k chua tham so
        {

        }
        public TaiKhoan(string tenTaiKhoan, string matKhau)// constructor k chua tham so
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; } // encapsulate fields
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
 
}
