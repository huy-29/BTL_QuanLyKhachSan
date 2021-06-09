using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyKhachSan.DTO
{
    class Tang
    {
        private string maTang;
        private string tenTang;

        public string MaTang { get => maTang; set => maTang = value; }
        public string TenTang { get => tenTang; set => tenTang = value; }
        
        public Tang(string maTang, string tenTang)
        {
            this.MaTang = maTang;
            this.TenTang = tenTang;
        }

        public Tang(DataRow row)
        {
            this.MaTang = row["MaTang"].ToString();

            var CheckGhiChu = row["TenTang"];
            if(CheckGhiChu != "")
            this.TenTang = row["TenTang"].ToString();
        }
    }
}
