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
    public partial class UC_DanhSachTang : UserControl
    {
        private DangNhap dangNhap;

        public DangNhap DangNhap { get => dangNhap; set => dangNhap = value; }
        public UC_DanhSachTang(DangNhap Login)
        {
            InitializeComponent();

            this.DangNhap = Login;

            LoadComboBoxTang();
            LockPanelUpdate(true);
            EnableButton(1,0,0);
            LoadListView();

            lblCheck_txbMaTang.Visible = false;
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
            List<Tang> listTang = TangDAO.Instance.GetListTang();
            lvDanhSachTang.Items.Clear();

            foreach(Tang item in listTang)
            {
                ListViewItem lvItem = new ListViewItem(item.MaTang.ToString());
                if(item.TenTang != null)
                {
                    lvItem.SubItems.Add(item.TenTang.ToString());
                }
                else
                {
                    lvItem.SubItems.Add("");
                }

                lvDanhSachTang.Items.Add(lvItem);
            }
        }

        void LoadComboBoxTang()
        {
            List<Tang> listTang = new List<Tang>();
            
            listTang.Add(new Tang("Tất cả","") );
            foreach(Tang item in TangDAO.Instance.GetListTang())
            {
                listTang.Add(item);
            }
            cbTang.DataSource = listTang;
            cbTang.DisplayMember = "MaTang";     
        }
        void LockPanelUpdate(bool e)
        {
            //txbGhiChu_BD.ReadOnly = e;
            //txbTang_BD.ReadOnly = e;
            //btnLuu.Enabled = !e;
            //btnHuy.Enabled = !e;

            pnlUpdate.Enabled = !e;
            btnLuu.Visible = !e;
            btnHuy.Visible = !e;
            if(e == true)
            {
                pnlUpdate.BackColor = SystemColors.ActiveCaption;
                lblCheck_txbMaTang.Visible = false;

                EnableButton(1, 0, 0);
            }
            else
            {
                pnlUpdate.BackColor = Color.White;
            }
        }
        void LoadListViewTheoComboBox()
        {
            string maTang = cbTang.Text;
            List<Tang> listTang = TangDAO.Instance.TimTang(maTang);

            lvDanhSachTang.Items.Clear();
            foreach (Tang item in listTang)
            {
                ListViewItem lvItem = new ListViewItem(item.MaTang.ToString());
                if (item.TenTang != null)
                {
                    lvItem.SubItems.Add(item.TenTang.ToString());
                }
                else
                {
                    lvItem.SubItems.Add("");
                }

                lvDanhSachTang.Items.Add(lvItem);
            }
        }
        private void lvDanhSachTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvDanhSachTang.SelectedItems)
            {
                txbMaTang_BD.Text = string.Format(item.SubItems[0].Text /*+ "1"*/);
                if(item.SubItems[1] != null)
                txbTenTang_BD.Text = string.Format(item.SubItems[1].Text /*+ "2"*/);
            }
        }

        int Check()
        {
            List<Tang> listTang = new List<Tang>();

            foreach (Tang item in TangDAO.Instance.GetListTang())
            {
                listTang.Add(item);
            }

            int a = 0;
            if(txbMaTang_BD.Text == "")
            {
                return 1;
            }

            if (Regex.IsMatch(txbMaTang_BD.Text, @"^[0-9]*[a-zA-Z]?$") == false)
            {
                return 2;
            }

            if(txbMaTang_BD.ReadOnly == false)
            {
                foreach (Tang item in listTang)
                {
                    if (item.MaTang == txbMaTang_BD.Text)
                    {
                        return 4;
                    }
                }
            }
            
            return a;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //pnlUpdate.BackColor = Color.White;
            txbMaTang_BD.ReadOnly = false;
            LockPanelUpdate(false);
            EnableButton(0, 0, 0);

            txbMaTang_BD.Text = "";
            txbTenTang_BD.Text = "";

            foreach (Tang item in TangDAO.Instance.GetListTang())
            {
                //MessageBox.Show(item.MaTang.ToString());
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            //pnlUpdate.BackColor = Color.White;
            LockPanelUpdate(false);
            EnableButton(0, 0, 0);

            if (lvDanhSachTang.CheckedItems.Count > 0)
            {
                ListViewItem item = lvDanhSachTang.CheckedItems[0];
                txbMaTang_BD.Text = item.Text;
                txbMaTang_BD.ReadOnly = true;
                txbTenTang_BD.Text = "";
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vẫn muốn xóa tầng ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                int i = 0;
                if (lvDanhSachTang.CheckedItems.Count > 0)
                {
                    foreach (ListViewItem item in lvDanhSachTang.CheckedItems)
                    {                        
                        if(TangDAO.Instance.CheckXoaTang(item.Text) > 0)
                        {
                            MessageBox.Show("Vẫn còn phòng trong tầng " + item.SubItems[0].Text);
                        }
                        else
                        {
                            if (TangDAO.Instance.XoaTang(item.Text))
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
                    LoadComboBoxTang();
                    txbMaTang_BD.Text = "";
                    txbTenTang_BD.Text = "";
                    string del = string.Format("Xóa thành công {0} mục", i.ToString());
                    MessageBox.Show(del);
                }    
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        { 
            lblCheck_txbMaTang.Visible = false;

            if (Check() == 0)
            {
                string maTang = txbMaTang_BD.Text;
                string tenTang = txbTenTang_BD.Text;

                TangDAO.Instance.UpdateTang(maTang, tenTang);

                //pnlUpdate.BackColor = SystemColors.ActiveCaption;
                LockPanelUpdate(true);
                EnableButton(1, 1, 1);
                LoadListView();
                txbMaTang_BD.Text = "";
                txbTenTang_BD.Text = "";

                LoadComboBoxTang();
            }
            else if (Check() == 1)
            {
                lblCheck_txbMaTang.Visible = true;
                lblCheck_txbMaTang.Text = "Điền mã tầng";
            }
            else if (Check() == 2)
            {
                lblCheck_txbMaTang.Visible = true;
                lblCheck_txbMaTang.Text = "Mã tầng chỉ chứa chữ số hoặc thêm 1 chữ cái đằng sau";
            }
            else if (Check() == 4)
            {
                lblCheck_txbMaTang.Visible = true;
                lblCheck_txbMaTang.Text = "Mã tầng đã được sử dụng";
            }  
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //pnlUpdate.BackColor = SystemColors.ActiveCaption;
            LockPanelUpdate(true);
            EnableButton(1, 0, 0);

            txbMaTang_BD.Text = "";
            txbTenTang_BD.Text = "";
        }
        private void cbTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTang.Text != "Tất cả")
            {
                LoadListViewTheoComboBox();
            }
            else
            {
                LoadListView();
            }
        }

        private void lvDanhSachTang_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if(lvDanhSachTang.CheckedItems.Count == 0)
            {
                EnableButton(1, 0, 0);
            }
            else if (lvDanhSachTang.CheckedItems.Count == 1)
            {
                EnableButton(1, 1, 1);
            }
            else
            {
                EnableButton(1, 0, 1);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<Tang> list = TangDAO.Instance.TimKiemTang(txbTimKiem.Text);

            lvDanhSachTang.Items.Clear();
            foreach (Tang item in list)
            {
                ListViewItem lvItem = new ListViewItem(item.MaTang.ToString());
                if (item.TenTang != null)
                {
                    lvItem.SubItems.Add(item.TenTang.ToString());
                }
                else
                {
                    lvItem.SubItems.Add("");
                }

                lvDanhSachTang.Items.Add(lvItem);
            }
        }
    }
}
