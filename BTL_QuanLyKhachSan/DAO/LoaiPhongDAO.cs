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
    class LoaiPhongDAO
    {
        private static LoaiPhongDAO instance;

        internal static LoaiPhongDAO Instance
        {
            get { if (instance == null) instance = new LoaiPhongDAO(); return instance; }
            private set { instance = value; }
        }
        private LoaiPhongDAO() { }

        public List<LoaiPhong> GetListLoaiPhong()
        {
            List<LoaiPhong> list = new List<LoaiPhong>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.LoaiPhong ORDER BY CAST(MaLoaiPhong AS INT)");

            foreach (DataRow item in data.Rows)
            {
                LoaiPhong tang = new LoaiPhong(item);
                list.Add(tang);
            }
            return list;
        }

        public bool UpdateLoaiPhong(string maLP, string tenLP, int soNguoi, string ghiChu)
        {
            string query = string.Format("UpdateLoaiPhong @maLP = '{0}', @tenLP = N'{1}', @soNguoi = {2}, @ghiChu=N'{3}'", maLP, tenLP, soNguoi, ghiChu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int CheckXoaLoaiPhong_Phong(string LP)
        {
            string query = string.Format("SELECT COUNT(*) FROM dbo.LoaiPhong AS a, dbo.Phong AS b WHERE a.MaLoaiPhong = b.MaLoaiPhong AND a.MaLoaiPhong = '{0}'", LP);
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result;
        }
        public int CheckXoaLoaiPhong_ThanhToan(string LP)
        {
            string query = string.Format("SELECT COUNT(*) FROM dbo.LoaiPhong AS a, dbo.MucGia AS b, dbo.ThanhToan AS c WHERE a.MaLoaiPhong = b.MaLoaiPhong AND b.MaMucGia = c.MaMucGia AND b.MaLoaiPhong = '{0}'", LP);
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result;
        }
        public bool XoaLoaiPhong(string maLP)
        {
            string query = string.Format("DELETE dbo.LoaiPhong WHERE MaLoaiPhong = '{0}'", maLP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<LoaiPhong> TimLoaiPhong(string LP, string P, string MG)
        {
            List<LoaiPhong> list = new List<LoaiPhong>();

            string query = string.Format("SELECT b.* FROM dbo.Phong AS a, dbo.LoaiPhong AS b, dbo.MucGia AS c WHERE a.MaLoaiPhong = b.MaLoaiPhong AND b.MaLoaiPhong = c.MaLoaiPhong AND TenLoaiPhong LIKE N'%{0}%' AND MaPhong LIKE '%{1}%' AND TenMucGia LIKE N'%{2}%' GROUP BY b.MaLoaiPhong, b.TenLoaiPhong, b.SoNguoi,b.GhiChu ORDER BY CAST(b.MaLoaiPhong AS INT)", LP, P, MG);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LoaiPhong lp = new LoaiPhong(item);
                list.Add(lp);
            }

            return list;
        }
        //public List<LoaiPhong> TimLoaiPhongAll(string LP)
        //{
        //    List<LoaiPhong> list = new List<LoaiPhong>();

        //    string query = string.Format("SELECT * " +
        //                                    "FROM dbo.LoaiPhong" +
        //                                    " WHERE MaLoaiPhong IN(SELECT MaLoaiPhong" +
        //                                        " FROM dbo.v_1" +
        //                                        " WHERE TenLoaiPhong LIKE N'%{0}%' OR SoNguoi LIKE '%{0}%' OR GhiChu LIKE N'%{0}%' OR MaPhong LIKE '%{0}%'" +
        //                                                         ")" +
        //                                    " OR" +
        //                                        " MaLoaiPhong IN(SELECT MaLoaiPhong" +
        //                                        " FROM dbo.v_2" +
        //                                        " WHERE TenLoaiPhong LIKE N'%{0}%' OR SoNguoi LIKE '%{0}%' OR GhiChu LIKE N'%{0}%' OR TenMucGia LIKE N'%{0}%'" +
        //                                                        ")"
        //                                  , LP);

        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);

        //    foreach (DataRow item in data.Rows)
        //    {
        //        LoaiPhong lp = new LoaiPhong(item);
        //        list.Add(lp);
        //    }

        //    return list;
        //}
        public List<LoaiPhong> TimLoaiPhongAll(string LP)
        {
            List<LoaiPhong> list = new List<LoaiPhong>();

            string query = string.Format("EXEC dbo.TimKiemLoaiPhongAll @TK = N'{0}'", LP);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LoaiPhong lp = new LoaiPhong(item);
                list.Add(lp);
            }

            return list;
        }
        public string GetMaLP()
        {
            string query = string.Format("SELECT dbo.TaoMaLoaiPhong()");
            string MaLP = DataProvider.Instance.ExecuteScalar(query).ToString();

            return MaLP;
        }

        public List<MucGia> GetListMucGiaFromMaLP(string MaLP)
        {
            List<MucGia> list = new List<MucGia>();
            string query = string.Format("SELECT * FROM dbo.MUCGIA WHERE MALOAIPHONG = '{0}'", MaLP);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MucGia mucgia = new MucGia(item);
                list.Add(mucgia);
            }

            return list;
        }
        public List<Phong> GetListPhongFromMaLP(string MaLP)
        {
            List<Phong> list = new List<Phong>();
            string query = string.Format("SELECT * FROM dbo.PHONG WHERE MALOAIPHONG = '{0}'", MaLP);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                list.Add(phong);
            }

            return list;
        }
    }
}
