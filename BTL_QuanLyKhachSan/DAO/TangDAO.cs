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
    class TangDAO
    {
        private static TangDAO instance;

        internal static TangDAO Instance
        {
            get { if (instance == null) instance = new TangDAO(); return instance; }
            private set { instance = value; }
        }
        private TangDAO() { }
        public List<Tang> GetListTang1()
        {
            List<Tang> list = new List<Tang>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Tang");

            foreach (DataRow item in data.Rows)
            {
                Tang tang = new Tang(item);
                list.Add(tang);
            }
            return list;
        }
        public List<Tang> GetListTang()
        {
            List<Tang> list = new List<Tang>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Tang ORDER BY CAST(MaTang AS INT)");
            
            foreach(DataRow item in data.Rows)
            {
                Tang tang = new Tang(item);
                list.Add(tang);
            }

            return list;
        }
        //public List<Tang> GetListMaTang()
        //{
        //    List<Tang> list = GetListTang();
        //    List<Tang> listTang = new List<Tang>();

        //    foreach (Tang item in list)
        //    {          

        //        listTang.Add(item.MaTang);
        //    }

        //    return listTang;
        //}
        public bool UpdateTang(string maTang, string tenTang)
        {
            string query = string.Format("UpdateTang @maTang = '{0}', @tenTang = N'{1}' ",maTang, tenTang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int CheckXoaTang(string T)
        {
            string query = string.Format("SELECT COUNT(*) FROM dbo.Tang AS a, dbo.Phong AS b WHERE a.MaTang = b.MaTang AND a.MaTang = '{0}'", T);
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result;
        }
        public bool XoaTang(string maTang)
        {
            string query = string.Format("DELETE dbo.Tang WHERE MaTang = '{0}'", maTang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<Tang> TimTang(string maTang)
        {
            List<Tang> list = new List<Tang>();
            
            string query = string.Format("SELECT* FROM dbo.Tang WHERE MaTang LIKE '%{0}%' ORDER BY CAST(MaTang AS INT)", maTang);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Tang tang = new Tang(item);
                list.Add(tang);
            }

            return list;
        }

        public List<Tang> TimKiemTang(string t)
        {
            List<Tang> list = new List<Tang>();

            string query = string.Format("SELECT* FROM dbo.Tang WHERE MaTang LIKE '%{0}%' OR TenTang LIKE N'%{0}%' ORDER BY CAST(MaTang AS INT)", t);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Tang tang = new Tang(item);
                list.Add(tang);
            }

            return list;
        }
    }
}
