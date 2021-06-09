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
    class DangNhapDAO
    {
        private static DangNhapDAO instance;

        internal static DangNhapDAO Instance
        {
            get { if (instance == null) instance = new DangNhapDAO(); return instance; }
            private set { instance = value; }
        }
        private DangNhapDAO() { }

        public bool Login(string username, string password)
        {
            //string query = string.Format("EXEC dbo.DangNhapTaiKhoan @TK = '{0}', @MK = '{1}'", username, password);

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.DangNhapTaiKhoan @TK , @MK ", new object[] { username , password});

            return data.Rows.Count > 0;
        }

        public DangNhap GetTaiKhoanByUsername(string username)
        {
            string query = string.Format("SELECT * FROM dbo.DangNhap WHERE TaiKhoan = '{0}'", username);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                return new DangNhap(item);
            }
            return null;
        }

        public List<DangNhap> GetListTaiKhoan()
        {
            List<DangNhap> list = new List<DangNhap>();

            string query = string.Format("SELECT * FROM dbo.DangNhap");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DangNhap dn = new DangNhap(item);
                list.Add(dn);
            }
            return list;
        }

        public List<DangNhap> GetListTaiKhoan_ChucVu()
        {
            List<DangNhap> list = new List<DangNhap>();

            string query = string.Format("SELECT * FROM dbo.DangNhap ORDER BY ChucVu");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DangNhap dn = new DangNhap(item);
                list.Add(dn);
            }
            return list;
        }

        public bool XoaTaiKhoan(string username)
        {
            string query = string.Format("DELETE dbo.DangNhap WHERE TaiKhoan = '{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public void UpdateTaiKhoan(string username, string password, string hoTen, string chucVu)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.UpdateTaiKhoan @username , @password , @hoTen , @chucVu  ", new object[] { username, password, hoTen, chucVu });
        }

        public List<DangNhap> GetListDangNhapByChucVu(string chucVu)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.TimTaiKhoanByChucVu @chucVu ", new object[] { chucVu });

            List<DangNhap> list = new List<DangNhap>();

            foreach (DataRow item in data.Rows)
            {
                DangNhap dn = new DangNhap(item);
                list.Add(dn);
            }
            return list;
        }
        public List<DangNhap> TimKiemAll(string tk, string chucVu)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.TimKiemAll @tk , @chucVu = ", new object[] { tk, chucVu });

            List<DangNhap> list = new List<DangNhap>();

            foreach (DataRow item in data.Rows)
            {
                DangNhap dn = new DangNhap(item);
                list.Add(dn);
            }
            return list;
        }


    }
}
