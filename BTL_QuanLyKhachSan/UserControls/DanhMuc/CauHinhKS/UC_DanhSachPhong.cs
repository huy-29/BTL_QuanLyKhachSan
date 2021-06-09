using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QuanLyKhachSan.DTO;
using BTL_QuanLyKhachSan.DAO;
using System.Text.RegularExpressions;

namespace BTL_QuanLyKhachSan.UserControls.DanhMuc.CauHinhKS
{
    public partial class UC_DanhSachPhong : UserControl
    {
        private DangNhap dangNhap;

        public DangNhap DangNhap { get => dangNhap; set => dangNhap = value; }
        public UC_DanhSachPhong(DangNhap Login)
        {
            InitializeComponent();

            this.DangNhap = Login;

            LoadComboBoxTang();
            LoadComboBoxLoaiPhong();
            LockPanelUpdate(true);
            EnableButton(1, 0, 0);
            LoadListView();

            lblCheck_MaPhong.Visible = false;
            lblCheck_Tang.Visible = false;
            lblCheck_LoaiPhong.Visible = false;
        }

        void EnableButton(int them, int sua, int xoa)
        {
            if(pnlUpdate.Enabled == false && DangNhap.ChucVu == "Quản lý")
            {
                if (them == 1) { btnThem.Enabled = true; }
                else { btnThem.Enabled = false; }

                if (sua == 1) { btnSua.Enabled = true; }
                else { btnSua.Enabled = false; }

                if (xoa == 1) { btnXoa.Enabled = true; }
                else { btnXoa.Enabled = false; }
            }
            else if(DangNhap.ChucVu != "Quản lý")
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

            }
        }

        void LoadListView()
        {
            List<Phong> list = PhongDAO.Instance.GetListPhong();
            lvDanhSachPhong.Items.Clear();

            foreach (Phong item in list)
            {
                ListViewItem lvItem = new ListViewItem(item.MaPhong.ToString());
                lvItem.SubItems.Add(item.MaTang);
                
                foreach(LoaiPhong item1 in PhongDAO.Instance.GetListLoaiPhong())
                {
                    if(item1.MaLoaiPhong == item.MaLoaiPhong)
                    {
                        lvItem.SubItems.Add(item1.TenLoaiPhong);
                        lvItem.SubItems.Add(item1.SoNguoi.ToString());
                        break;
                    } 
                }

                lvDanhSachPhong.Items.Add(lvItem);
            }
        }

        void LoadComboBoxTang()
        {
            List<Tang> list = new List<Tang>();

            list.Add(new Tang("Tất cả", ""));
            foreach (Tang item in PhongDAO.Instance.GetListTang())
            {
                list.Add(item);
            }
            cbTang.DataSource = list;
            cbTang.DisplayMember = "MaTang";

        }

        void LoadComboBoxLoaiPhong()
        {
            List<LoaiPhong> list = new List<LoaiPhong>();

            list.Add(new LoaiPhong("", "Tất cả", 0, ""));
            foreach (LoaiPhong item in PhongDAO.Instance.GetListLoaiPhong())
            {
                list.Add(item);
            }
            cbLoaiPhong.DataSource = list;
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
        }

        void LockPanelUpdate(bool e)
        {
            pnlUpdate.Enabled = !e;
            btnLuu.Visible = !e;
            btnHuy.Visible = !e;

            if (e == true)
            {
                pnlUpdate.BackColor = SystemColors.ActiveCaption;
                lblCheck_MaPhong.Visible = false;
                lblCheck_Tang.Visible = false;
                lblCheck_LoaiPhong.Visible = false;
                EnableButton(1, 0, 0);
            }
            else
            {
                pnlUpdate.BackColor = Color.White;
            }
        }

        private void lvDanhSachPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvDanhSachPhong.SelectedItems)
            {
                txbMaPhong_BD.Text = item.Text;
                cbTang_BD.Text = item.SubItems[1].Text;
                cbLoaiPhong_BD.Text = item.SubItems[2].Text;
                txbSoNguoi_BD.Text = item.SubItems[3].Text;
            }
        }
        void LoadListViewTheoComboBox()
        {
            string T = cbTang.Text;
            string LP = cbLoaiPhong.Text;

            if(T == "Tất cả") { T = ""; }
            if(LP == "Tất cả"){ LP = ""; }

            List<Phong> list = PhongDAO.Instance.TimPhong(T, LP);

            lvDanhSachPhong.Items.Clear();

            foreach (Phong item in list)
            {
                ListViewItem lvItem = new ListViewItem(item.MaPhong);
                lvItem.SubItems.Add(item.MaTang);

                foreach (LoaiPhong item1 in PhongDAO.Instance.GetListLoaiPhong())
                {
                    if (item1.MaLoaiPhong == item.MaLoaiPhong)
                    {
                        lvItem.SubItems.Add(item1.TenLoaiPhong);
                        lvItem.SubItems.Add(item1.SoNguoi.ToString());
                        break;
                    }
                }

                lvDanhSachPhong.Items.Add(lvItem);
            }
        }
        private void cbTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListViewTheoComboBox();
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListViewTheoComboBox();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string T = txbTimKiem.Text;

            List<Phong> list = PhongDAO.Instance.TimKiemAll(T);

            lvDanhSachPhong.Items.Clear();

            foreach (Phong item in list)
            {
                ListViewItem lvItem = new ListViewItem(item.MaPhong);
                lvItem.SubItems.Add(item.MaTang);

                foreach (LoaiPhong item1 in PhongDAO.Instance.GetListLoaiPhong())
                {
                    if (item1.MaLoaiPhong == item.MaLoaiPhong)
                    {
                        lvItem.SubItems.Add(item1.TenLoaiPhong);
                        lvItem.SubItems.Add(item1.SoNguoi.ToString());
                        break;
                    }
                }

                lvDanhSachPhong.Items.Add(lvItem);
            }
        }
        private void cbLoaiPhong_BD_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<LoaiPhong> list = PhongDAO.Instance.GetListLoaiPhong();

            foreach(LoaiPhong item in list)
            {
                if(item.TenLoaiPhong == cbLoaiPhong_BD.Text)
                {
                    txbSoNguoi_BD.Text = item.SoNguoi.ToString();
                    txbMaLoaiPhong.Text = item.MaLoaiPhong;
                    break;
                }
            }
        }

        int Check()
        {
            List<Tang> listT = PhongDAO.Instance.GetListTang();
            List<LoaiPhong> listLP = PhongDAO.Instance.GetListLoaiPhong();
            List<Phong> listP = PhongDAO.Instance.GetListPhong();

            int a = 0;
            if (txbMaPhong_BD.Text == "")
            {
                return 1;
            }
            foreach(Phong item in listP)
            {
                if(string.Compare(txbMaPhong_BD.Text, item.MaPhong, true) == 0)
                {
                    return 2;
                }
            }
            if (Regex.IsMatch(txbMaPhong_BD.Text, @"^[0-9]*$") == false)
            {
                return 7;
            }
            if (cbTang_BD.Text == "")
            {
                return 3;
            }
            a = 4;
            foreach (Tang item in listT)
            {
                if (cbTang_BD.Text == item.MaTang)
                {
                    a = 0;
                    break;
                }
            }
            if (a == 4) { return 4; }
            if (cbLoaiPhong_BD.Text == "")
            {
                return 5;
            }
            a = 6;
            foreach (LoaiPhong item in listLP)
            {
                if (cbLoaiPhong_BD.Text == item.TenLoaiPhong)
                {
                    a = 0;
                    break;
                }
            }
            if (a == 6) { return 6; }

            return a;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            LockPanelUpdate(false);
            EnableButton(0, 0, 0);
            cbTang_BD.DataSource = PhongDAO.Instance.GetListTang();
            cbTang_BD.DisplayMember = "MaTang";
            cbLoaiPhong_BD.DataSource = PhongDAO.Instance.GetListLoaiPhong();
            cbLoaiPhong_BD.DisplayMember = "TenLoaiPhong";

            txbMaPhong_BD.Text = "";
            cbTang_BD.Text = "";
            cbLoaiPhong_BD.Text = "";
            txbSoNguoi_BD.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LockPanelUpdate(false);
            EnableButton(0, 0, 0);
            cbTang_BD.DataSource = PhongDAO.Instance.GetListTang();
            cbTang_BD.DisplayMember = "MaTang";
            cbLoaiPhong_BD.DataSource = PhongDAO.Instance.GetListLoaiPhong();
            cbLoaiPhong_BD.DisplayMember = "TenLoaiPhong";

            txbMaPhong_BD.Text = lvDanhSachPhong.CheckedItems[0].Text;
            txbMaPhong_BD.ReadOnly = true;
            cbTang_BD.Text = "";
            cbLoaiPhong_BD.Text = "";
            txbSoNguoi_BD.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vẫn muốn xóa tầng ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                int i = 0;
                if (lvDanhSachPhong.CheckedItems.Count > 0)
                {
                    foreach (ListViewItem item in lvDanhSachPhong.CheckedItems)
                    {
                        if(PhongDAO.Instance.CheckXoaPhong(item.Text) > 0)
                        {
                            MessageBox.Show("Phòng {0} vẫn đang được cho thuê hoặc đặt trước", item.Text);
                        }
                        else
                        {
                            if (PhongDAO.Instance.XoaPhong(item.Text))
                            {
                                i++;
                            }
                            else
                            {
                                MessageBox.Show("Có lỗi khi xóa");
                            }
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            lblCheck_MaPhong.Visible = false;
            lblCheck_Tang.Visible = false;
            lblCheck_LoaiPhong.Visible = false;

            if (Check() == 0)
            {
                string P = txbMaPhong_BD.Text;
                string T = cbTang_BD.Text;
                string LP = cbLoaiPhong_BD.Text;

                PhongDAO.Instance.UpdatePhong(P, T, LP);

                //pnlUpdate.BackColor = SystemColors.ActiveCaption;
                LockPanelUpdate(true);
                EnableButton(1, 0, 0);
                LoadListView();
            }
            else if (Check() == 1)
            {
                lblCheck_MaPhong.Visible = true;
                lblCheck_MaPhong.Text = "Điền tên phòng";
            }
            else if (Check() == 2)
            {
                lblCheck_MaPhong.Visible = true;
                lblCheck_MaPhong.Text = "tên phòng đã được sử dụng";
            }
            else if (Check() == 7)
            {
                lblCheck_MaPhong.Visible = true;
                lblCheck_MaPhong.Text = "Tên phòng chỉ chứa chữ số";
            }
            else if (Check() == 3)
            {
                lblCheck_Tang.Visible = true;
                lblCheck_Tang.Text = "Điền số tầng chứa phòng";
            }
            else if (Check() == 4)
            {
                lblCheck_Tang.Visible = true;
                lblCheck_Tang.Text = "tầng không tồn tại";
            }
            else if (Check() == 5)
            {
                lblCheck_LoaiPhong.Visible = true;
                lblCheck_LoaiPhong.Text = "điền loại phòng sử dụng";
            }
            else if (Check() == 6)
            {
                lblCheck_LoaiPhong.Visible = true;
                lblCheck_LoaiPhong.Text = "loại phòng không tồn tại";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LockPanelUpdate(true);
            EnableButton(1, 0, 0);

            txbMaPhong_BD.Text = "";
            cbTang_BD.Text = "";
            cbLoaiPhong_BD.Text = "";
            txbSoNguoi_BD.Text = "";
        }

        private void lvDanhSachPhong_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvDanhSachPhong.CheckedItems.Count == 0)
            {
                EnableButton(1, 0, 0);
            }
            else if (lvDanhSachPhong.CheckedItems.Count == 1)
            {
                EnableButton(1, 1, 1);
            }
            else
            {
                EnableButton(1, 0, 1);
            }
        }

    }
}
