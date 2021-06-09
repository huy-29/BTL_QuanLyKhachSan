using BTL_QuanLyKhachSan.DTO;
using QuanLyThuHocPhi.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyKhachSan.DAO
{
    class PhongDAO
    {
        private static PhongDAO instance;

        internal static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return instance; }
            private set { instance = value; }
        }
        private PhongDAO() { }

        public List<Phong> GetListPhong()
        {
            List<Phong> list = new List<Phong>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Phong ORDER BY MaPhong");

            foreach (DataRow item in data.Rows)
            {
                Phong p = new Phong(item);
                list.Add(p);
            }
            return list;
        }
        public List<Tang> GetListTang()
        {
            List<Tang> list = new List<Tang>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Tang ORDER BY CAST(MaTang AS INT)");

            foreach (DataRow item in data.Rows)
            {
                Tang tang = new Tang(item);
                list.Add(tang);
            }
            return list;
        }
        public List<LoaiPhong> GetListLoaiPhong()
        {
            List<LoaiPhong> list = new List<LoaiPhong>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.LoaiPhong ORDER BY CAST(MaLoaiPhong AS INT)");

            foreach (DataRow item in data.Rows)
            {
                LoaiPhong LP = new LoaiPhong(item);
                list.Add(LP);
            }
            return list;
        }

        public bool UpdatePhong(string MP, string T, string TenLP)
        {
            string query = string.Format("UpdatePhong @maPhong = '{0}', @Tang = '{1}', @TenLP = N'{2}'", MP, T, TenLP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int CheckXoaPhong(string P)
        {
            string query = string.Format("SELECT COUNT(*) FROM dbo.ThuePhong WHERE MaPhong = '{0}'", P);
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result;
        }
        public bool XoaPhong(string MP)
        {
            string query = string.Format("DELETE dbo.Phong WHERE MaPhong = '{0}'", MP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Phong> TimPhong(string T, string LP)
        {
            List<Phong> list = new List<Phong>();

            string query = string.Format("SELECT a.* FROM dbo.Phong AS a, dbo.Tang AS b, dbo.LoaiPhong AS c WHERE a.MaTang = b.MaTang AND a.MaLoaiPhong = c.MaLoaiPhong AND b.MaTang LIKE N'%{0}%' AND c.TenLoaiPhong LIKE N'%{1}%' ORDER BY MaPhong", T, LP);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Phong p = new Phong(item);
                list.Add(p);
            }

            return list;
        }

        public List<Phong> TimKiemAll(string T)
        {
            List<Phong> list = new List<Phong>();

            string query = string.Format("SELECT b.* FROM dbo.Tang AS a, dbo.Phong AS b, dbo.LoaiPhong AS c WHERE a.MaTang = b.MaTang AND b.MaLoaiPhong = c.MaLoaiPhong AND (b.MaPhong LIKE N'%{0}%' OR a.MaTang LIKE N'%{0}%' OR c.TenLoaiPhong LIKE N'%{0}%') ORDER BY MaPhong", T);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Phong p = new Phong(item);
                list.Add(p);
            }

            return list;
        }
    }
}
