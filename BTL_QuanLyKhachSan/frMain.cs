using BTL_QuanLyKhachSan.DTO;
using BTL_QuanLyKhachSan.UserControls;
using BTL_QuanLyKhachSan.UserControls.DanhMuc.CaiDatChung;
using BTL_QuanLyKhachSan.UserControls.DanhMuc.CauHinhKS;
using BTL_QuanLyKhachSan.UserControls.DanhMuc.GiaTheoThoiDiem;
using BTL_QuanLyKhachSan.UserControls.NhanVien;
using BTL_QuanLyKhachSan.UserControls.QuanLyPhong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyKhachSan
{
    public partial class frMain : Form
    {
        private DangNhap dangNhap;

        public DangNhap DangNhap { get => dangNhap; set => dangNhap = value; }

        public frMain(DangNhap Login)
        {
            InitializeComponent();

            this.DangNhap = Login;
            txbTen.Text = string.Format(DangNhap.TenNguoiDung + " (" + DangNhap.ChucVu + ")");
        }

        private void tvMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.Toggle();
            
            if (e.Node.Name == "CauHinhKhachSan")
            {
                UC_CauHinhKS add = new UC_CauHinhKS(DangNhap);
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(add);
            }
            else if (e.Node.Name == "GiaTheoThoiDiem")
            {
                UC_GiaTheoThoiDiem add = new UC_GiaTheoThoiDiem(DangNhap);
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(add);
            }
            else if (e.Node.Name == "CaiDatChung")
            {
                UC_CaiDatChung add = new UC_CaiDatChung();
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(add);
            }
            else if (e.Node.Name == "NhanVien")
            {
                UC_NhanVien add = new UC_NhanVien(DangNhap);
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(add);
            }
            else if (e.Node.Name == "SoDoPhong")
            {
                UC_SoDoPhong add = new UC_SoDoPhong();
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(add);
            }
            else if (e.Node.Name == "DanhSachDatPhong")
            {
                UC_DanhSachDatPhong add = new UC_DanhSachDatPhong();
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(add);
            }
            else if (e.Node.Name == "DanhSachThuePhong")
            {
                UC_DanhSachThuePhong add = new UC_DanhSachThuePhong();
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(add);
            }
            else if (e.Node.Name == "CachTinhChiPhi")
            {
                UC_CachTinhChiPhi add = new UC_CachTinhChiPhi();
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(add);
            }
        }

        private void tvMenu_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            tvMenu.CollapseAll();
        }

        #region TestAddToComboBox
        //public List<Food> GetList ()
        //{
        //    List<Food> list = new List<Food>()
        //    {
        //        new Food() { name = "mon 1", price = 20001},
        //        new Food() { name = "mon 2", price = 20002 },
        //        new Food() { name = "mon 3", price = 20003 }
        //    };
        //    return list;
        //}
        //void Load()
        //{
        //    List<Food> list = new List<Food>();
        //    //list = GetList();
        //    //list.Add(new Food() { name = "mon bonus", price = 300000 });

        //    list.Add(new Food() { name = "mon bonus", price = 300000 });
        //    foreach(Food item in GetList())
        //    {
        //        list.Add(item);
        //    }
        //    cbTest.DataSource = list;
        //    cbTest.DisplayMember = "price";

        //}
        //public class Food
        //{
        //    public string name { get; set; }
        //    public int price { get; set; }
        //}
        //private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    //e.Node.BackColor = Color.Red;

        //}

        //private void treeView1_Click(object sender, EventArgs e)
        //{
        ////    treeView1.CollapseAll();
        ////    treeView1.ExpandAll();
        ////    treeView1.Select();
        ////    treeView1.Show();     
        //}
        #endregion

    }
}
