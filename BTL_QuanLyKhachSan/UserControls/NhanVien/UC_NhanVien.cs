using BTL_QuanLyKhachSan.DAO;
using BTL_QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyKhachSan.UserControls.NhanVien
{
    public partial class UC_NhanVien : UserControl
    {
        private DangNhap dangNhap;

        public DangNhap DangNhap { get => dangNhap; set => dangNhap = value; }
        public UC_NhanVien(DangNhap Login)
        {
            InitializeComponent();

            this.DangNhap = Login;

            EnableButton(1, 0, 0);
            LoadComboboxTimKiemChucVu();
            LoadListView();

            lblCheck_TenDangNhap.Visible = false;
            lblCheck_MatKhauCu.Visible = false;
            lblCheck_MatKhau.Visible = false;
            lblCheck_NhapLaiMK.Visible = false;
            lblCheck_HoTen.Visible = false; 
            lblCheck_ChucVu.Visible = false;

            flpThongTin.Visible = false;
        }

        void EnableButton(int them, int sua, int xoa)     //enable button
        {
            if(flpThongTin.Visible == false)
            {
                if (DangNhap.ChucVu != "Quản lý")
                {
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                }
                else if (DangNhap.ChucVu == "Quản lý")
                {
                    if (flpThongTin.Visible == false)
                    {
                        if (them == 1) { btnThem.Enabled = true; }
                        else { btnThem.Enabled = false; }

                        if (xoa == 1) { btnXoa.Enabled = true; }
                        else { btnXoa.Enabled = false; }
                    }
                }

                if (sua == 1) { btnSua.Enabled = true; }
                else { btnSua.Enabled = false; }
            }
        }

        private void lvNhanVien_ItemChecked(object sender, ItemCheckedEventArgs e)  
        {
            if (lvNhanVien.CheckedItems.Count == 0)
            {
                EnableButton(1, 0, 0);
            }
            else if (lvNhanVien.CheckedItems.Count == 1)
            {
                if (DangNhap.ChucVu == "Quản lý")
                {
                    EnableButton(1, 1, 1);
                }
                else if (DangNhap.ChucVu != "Quản lý")
                {
                    if (lvNhanVien.CheckedItems[0].SubItems[1].Text == DangNhap.TenDangNhap)
                    {
                        EnableButton(0, 1, 0);
                    }
                }
            }
            else
            {
                EnableButton(1, 0, 1);
            }
        }

        void LoadListView()    // Load list
        {
            List<DangNhap> list = DangNhapDAO.Instance.GetListTaiKhoan();
            LoadListViewByListDangNhap(list);
        }
        void LoadListViewByListDangNhap(List<DangNhap> list)
        { 
            lvNhanVien.Items.Clear();

            foreach (DangNhap item in list)
            {
                ListViewItem lvItem = new ListViewItem(item.TenDangNhap);
                lvItem.SubItems.Add(item.TenNguoiDung);
                lvItem.SubItems.Add(item.ChucVu);

               lvNhanVien.Items.Add(lvItem);
            }
        }

        void LoadComboboxTimKiemChucVu()  // load combo box tim kiem
        {
            cbTimChucVu.Items.Clear();

            cbTimChucVu.Items.Add("Tất cả");

            List<DangNhap> list = DangNhapDAO.Instance.GetListTaiKhoan_ChucVu();

            string chucVu = "";
            foreach (DangNhap item in list)
            {      
                if(string.Compare(chucVu, item.ChucVu, false) != 0)
                {
                    cbTimChucVu.Items.Add(item.ChucVu);
                    chucVu = item.ChucVu;
                }
            }
        }

        void LoadComboboxChucVu()
        {
            cbChucVu.Items.Clear();

            List<DangNhap> list = DangNhapDAO.Instance.GetListTaiKhoan_ChucVu();

            string chucVu = "";
            foreach (DangNhap item in list)
            {
                if (string.Compare(chucVu, item.ChucVu, false) != 0)
                {
                    cbChucVu.Items.Add(item.ChucVu);
                    chucVu = item.ChucVu;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lblCheck_TenDangNhap.Visible = false;
            lblCheck_MatKhauCu.Visible = false;
            lblCheck_MatKhau.Visible = false;
            lblCheck_NhapLaiMK.Visible = false;
            lblCheck_HoTen.Visible = false;
            lblCheck_ChucVu.Visible = false;

            flpThongTin.Visible = true;
            pnlTenDangNhap.Visible = true;
            pnlMatKhauCu.Visible = false;
            pnlMatKhau.Visible = true;
            pnlNhapLaiMK.Visible = true;
            pnlHoTen.Visible = true;
            pnlChucVu.Visible = true;

            lblMatKhau.Text = "Mật khẩu";
            LoadComboboxChucVu();
       
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lblCheck_TenDangNhap.Visible = false;
            lblCheck_MatKhauCu.Visible = false;
            lblCheck_MatKhau.Visible = false;
            lblCheck_NhapLaiMK.Visible = false;
            lblCheck_HoTen.Visible = false;
            lblCheck_ChucVu.Visible = false;

            flpThongTin.Visible = true;
            pnlTenDangNhap.Visible = true;
            pnlMatKhauCu.Visible = true;
            pnlMatKhau.Visible = true;
            pnlNhapLaiMK.Visible = true;
            pnlHoTen.Visible = true;
            pnlChucVu.Visible = true;

            lblMatKhau.Text = "Mật khẩu mới";

            ListViewItem item = lvNhanVien.CheckedItems[0];
            txbTenDangNhap.Text = item.Text;
            txbTenDangNhap.ReadOnly = true;

            txbHoTen.Text = item.SubItems[0].Text;
            cbChucVu.Text = item.SubItems[1].Text;
            if (DangNhap.ChucVu == "Quản lý")
            {
                cbChucVu.Enabled = true;
                LoadComboboxChucVu();
            }
            else if(DangNhap.ChucVu != "Quản lý")
            {
                cbChucVu.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xóa tài khoản ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                int i = 0;
                if (lvNhanVien.CheckedItems.Count > 0)
                {
                    foreach (ListViewItem item in lvNhanVien.CheckedItems)
                    {
                        if (DangNhapDAO.Instance.XoaTaiKhoan(item.Text))
                        {
                            i++;
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi xóa");
                        }
                    }
                }
                if (i > 0)
                {
                    LoadListView();
                    string del = string.Format("Xóa thành công {0} mục", i.ToString());
                    MessageBox.Show(del);
                }
            }
        }

        int Check()
        {
            List<DangNhap> list = DangNhapDAO.Instance.GetListTaiKhoan();

            if (txbTenDangNhap.ReadOnly == false)
            {
                //DangNhap info = DangNhapDAO.Instance.GetTaiKhoanByUsername(txbTenDangNhap.Text);

                foreach (DangNhap item in list)
                {
                    if(txbTenDangNhap.Text == item.TenDangNhap)
                    {
                        return 1;
                    }
                }
                if(txbNhapLaiMK.Text != txbMatKhau.Text)
                {
                    return 4;
                }
                if(txbHoTen.Text == "")
                {
                    return 5;
                }
                if(Regex.IsMatch(txbHoTen.Text, @"^[aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ ]*$") == false)
                {
                    return 6;
                }
                if(cbChucVu.Text == "")
                {
                    return 7;
                }
                if(Regex.IsMatch(cbChucVu.Text, @"^[aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ ]*$") == false)
                {
                    return 8;
                }
            }
            else if(txbTenDangNhap.ReadOnly == true)
            {
                DangNhap info = DangNhapDAO.Instance.GetTaiKhoanByUsername(txbTenDangNhap.Text);

                if (txbMatKhauCu.Text != info.MatKhau)
                {
                    return 2;
                }
                if(txbMatKhau.Text == info.MatKhau)
                {
                    return 3;
                }
                if(txbNhapLaiMK.Text != txbMatKhau.Text)
                {
                    return 4;
                }
                if (txbHoTen.Text == "")
                {
                    return 5;
                }
                if (Regex.IsMatch(txbHoTen.Text, @"^[aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ ]*$") == false)
                {
                    return 6;
                }
                if (cbChucVu.Text == "")
                {
                    return 7;
                }
                int a = 9;
                foreach(DangNhap item in cbChucVu.Items)
                {
                    if(cbChucVu.Text == item.ChucVu)
                    {
                        a = 0;
                        break;
                    }
                }
                if (a == 9) { return 9; }
            }

            return 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            lblCheck_TenDangNhap.Visible = false;
            lblCheck_MatKhauCu.Visible = false;
            lblCheck_MatKhau.Visible = false;
            lblCheck_NhapLaiMK.Visible = false;
            lblCheck_HoTen.Visible = false;
            lblCheck_ChucVu.Visible = false;

            if (Check() == 0)
            {
                DangNhapDAO.Instance.UpdateTaiKhoan(txbTenDangNhap.Text, txbMatKhau.Text, txbHoTen.Text, cbChucVu.Text);
                flpThongTin.Visible = false;
                EnableButton(1, 0, 0);
            }
            else if(Check() == 1)
            {
                lblCheck_TenDangNhap.Visible = true;
                lblCheck_TenDangNhap.Text = "Tên đăng nhập đã được sử dụng";
            }
            else if(Check() == 2)
            {
                lblCheck_MatKhauCu.Visible = true;
                lblCheck_MatKhauCu.Text = "Mật khẩu cũ không chính xác";
            }
            else if (Check() == 3)
            {
                lblCheck_MatKhau.Visible = true;
                lblCheck_MatKhau.Text = "Mật khẩu mới trùng với mật khẩu cũ";
            }
            else if (Check() == 4)
            {
                lblCheck_NhapLaiMK.Visible = true;
                lblCheck_NhapLaiMK.Text = "Mật khẩu nhập lại không chính xác";
            }
            else if (Check() == 5)
            {
                lblCheck_HoTen.Visible = true;
                lblCheck_HoTen.Text = "chưa điền họ tên";
            }
            else if (Check() == 6)
            {
                lblCheck_HoTen.Visible = true;
                lblCheck_HoTen.Text = "Họ tên chỉ chứa chữ cái và dấu cách";
            }
            else if (Check() == 7)
            {
                lblCheck_ChucVu.Visible = true;
                lblCheck_ChucVu.Text = "chưa điền chức vụ";
            }
            else if (Check() == 8)
            {
                lblCheck_ChucVu.Visible = true;
                lblCheck_ChucVu.Text = "Chức vụ chỉ chứa chữ cái và dấu cách";
            }
            else if (Check() == 9)
            {
                lblCheck_ChucVu.Visible = true;
                lblCheck_ChucVu.Text = "Chức vụ không hợp lệ";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            flpThongTin.Visible = false;
            EnableButton(1, 0, 0);
        }

        private void chkMe_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMe.Checked == true)
            {
                lvNhanVien.Items.Clear();

                ListViewItem lvItem = new ListViewItem(DangNhap.TenDangNhap);
                lvItem.SubItems.Add(DangNhap.TenNguoiDung);
                lvItem.SubItems.Add(DangNhap.ChucVu);

                lvNhanVien.Items.Add(lvItem);
            }
            else
            {
                LoadListView();
            }
        }

        private void cbTimChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTimChucVu.Text == "Tất cả")
            {
                LoadListView();
            }
            else
            {
                List<DangNhap> list =  DangNhapDAO.Instance.GetListDangNhapByChucVu(cbTimChucVu.Text);
                LoadListViewByListDangNhap(list);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string chucVu = "";
            if(chkMe.Checked == false)
            {
                if(cbTimChucVu.Text == "Tất cả" || cbTimChucVu.Text == "")
                {
                    chucVu = "";
                }

                List<DangNhap> list = DangNhapDAO.Instance.TimKiemAll(txbTimKiem.Text, chucVu);
                LoadListViewByListDangNhap(list);
            }
        }
    }
}
