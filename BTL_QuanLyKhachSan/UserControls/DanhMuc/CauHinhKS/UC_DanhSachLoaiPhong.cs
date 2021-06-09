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

namespace BTL_QuanLyKhachSan.UserControls.DanhMuc.CauHinhKS
{
    public partial class UC_DanhSachLoaiPhong : UserControl
    {
        private DangNhap dangNhap;

        public DangNhap DangNhap { get => dangNhap; set => dangNhap = value; }
        public UC_DanhSachLoaiPhong(DangNhap Login)
        {
            InitializeComponent();

            this.DangNhap = Login;

            LoadComboBoxLoaiPhong();
            LoadComboBoxPhong();
            LoadComboBoxMucGia();
            EnableButton(1,0,0,0);
            LoadListView();
            //Load();
        }

        void EnableButton(int them, int sua, int xoa, int xem)
        {
            if(DangNhap.ChucVu == "Quản lý")
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

            if (xem == 1) { btnXem.Enabled = true; }
            else { btnXem.Enabled = false; }
        }

        public void LoadListLoaiPhong(List<LoaiPhong> list)
        {
            lvDanhSachLoaiPhong.Items.Clear();

            foreach (LoaiPhong item in list)
            {
                ListViewItem lvItem = new ListViewItem(item.MaLoaiPhong.ToString());
                lvItem.SubItems.Add(item.TenLoaiPhong.ToString());
                lvItem.SubItems.Add(item.SoNguoi.ToString());
                if (item.GhiChu != null)
                {
                    lvItem.SubItems.Add(item.GhiChu.ToString());
                }
                else
                {
                    lvItem.SubItems.Add("");
                }
                //--------------SubItem MucGia--------------------
                string MucGiaSD = "";
                int i = 0;
                List<MucGia> listMG = LoaiPhongDAO.Instance.GetListMucGiaFromMaLP(item.MaLoaiPhong);
                foreach (MucGia item1 in listMG)
                {
                    if (i != 0)
                    {
                        MucGiaSD = string.Format(MucGiaSD + ", " + item1.TenMucGia);
                    }
                    if (i == 0)
                    {
                        MucGiaSD = string.Format(MucGiaSD + item1.TenMucGia);
                        i = 1;
                    }
                }
                //MucGiaSD.Remove(MucGiaSD.Length - 2, 2);
                lvItem.SubItems.Add(MucGiaSD);

                //--------------SubItem Phong----------------------
                string PhongSD = "";
                i = 0;
                List<Phong> listPhong = LoaiPhongDAO.Instance.GetListPhongFromMaLP(item.MaLoaiPhong);
                foreach (Phong item2 in listPhong)
                {
                    if (i != 0)
                    {
                        PhongSD = string.Format(PhongSD + ", " + item2.MaPhong);
                    }
                    if (i == 0)
                    {
                        PhongSD = string.Format(PhongSD + item2.MaPhong);
                        i = 1;
                    }
                }
                //PhongSD.Remove(PhongSD.Length - 2, 2);
                lvItem.SubItems.Add(PhongSD);

                lvDanhSachLoaiPhong.Items.Add(lvItem);
            }
        }
        public void LoadListView()
        {
            List<LoaiPhong> listLP = LoaiPhongDAO.Instance.GetListLoaiPhong();

            LoadListLoaiPhong(listLP);
        }

        void LoadComboBoxLoaiPhong()
        {
            List<LoaiPhong> listLP = new List<LoaiPhong>();

            listLP.Add(new LoaiPhong("", "Tất cả", 0, ""));
            foreach (LoaiPhong item in LoaiPhongDAO.Instance.GetListLoaiPhong())
            {
                listLP.Add(item);
            }
            cbLoaiPhong.DataSource = listLP;
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
        }
        void LoadComboBoxPhong()
        {
            List<Phong> listLP = new List<Phong>();

            listLP.Add(new Phong("Tất cả", "", "", ""));
            foreach (Phong item in PhongDAO.Instance.GetListPhong())
            {
                listLP.Add(item);
            }
            cbPhong.DataSource = listLP;
            cbPhong.DisplayMember = "MaPhong";
        }
        void LoadComboBoxMucGia()
        {
            List<MucGia> listLP = new List<MucGia>();

            listLP.Add(new MucGia("", "Tất cả", 0, 0, 0, DateTime.Now, DateTime.Now, ""));
            foreach (MucGia item in MucGiaDAO.Instance.GetListMucGia())
            {
                listLP.Add(item);
            }
            cbMucGia.DataSource = listLP;
            cbMucGia.DisplayMember = "TenMucGia";
        }

        void LoadListViewTheoComboBox()
        {
            string LP = cbLoaiPhong.Text;
            if(LP == "Tất cả") { LP = ""; }

            string P = cbPhong.Text;
            if (P == "Tất cả") { P = ""; }
            
            string MG = cbMucGia.Text;
            if (MG == "Tất cả") { MG = ""; }

            List<LoaiPhong> listLP;

            if (LP == "" && P == "" && MG == "")
            {
                listLP = LoaiPhongDAO.Instance.GetListLoaiPhong();
            }
            else
            {
                listLP = LoaiPhongDAO.Instance.TimLoaiPhong(LP, P, MG);
            }

            LoadListLoaiPhong(listLP);
        }
        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadComboBoxLoaiPhong();
            LoadListViewTheoComboBox();
        }
        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListViewTheoComboBox();
        }
        private void cbMucGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListViewTheoComboBox();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string LP = txbTimKiem.Text;

            List<LoaiPhong> listLP = LoaiPhongDAO.Instance.TimLoaiPhongAll(LP);

            LoadListLoaiPhong(listLP);
        }
        private void lvDanhSachLoaiPhong_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            if (lvDanhSachLoaiPhong.CheckedItems.Count == 0)
            {
                EnableButton(1, 0, 0, 0);
            }
            else if (lvDanhSachLoaiPhong.CheckedItems.Count == 1)
            {
                EnableButton(1, 1, 1, 1);
            }
            else
            {
                EnableButton(1, 0, 1, 0);
            }
        }

        #region Test Binding + Pass data to Listview
        //void BindingLoaiPhong()
        //{
        //    txbLoaiPhong_BD.DataBindings.Add(new Binding("Text", lvDanhSachLoaiPhong.Items, "LoaiPhong", true, DataSourceUpdateMode.Never));
        //    txbSoNguoi_BD.DataBindings.Add(new Binding("Text", lvDanhSachLoaiPhong.Items, "SoNguoi", true, DataSourceUpdateMode.Never));
        //}

        //void Load()
        //{

        //    foreach (ListLoaiPhong item in GetList())
        //    {
        //        ListViewItem item1 = new ListViewItem();
        //        item1.Text = item.LoaiPhong;
        //        item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.SoNguoi.ToString() });

        //        lvDanhSachLoaiPhong.Items.Add(item1);
        //    }
        //}
        //public List<ListLoaiPhong> GetList()
        //{
        //    List<ListLoaiPhong> list = new List<ListLoaiPhong>()    
        //    {
        //        new ListLoaiPhong() { LoaiPhong = "phong 1", SoNguoi = 2},
        //        new ListLoaiPhong() { LoaiPhong = "phong 2", SoNguoi = 3 },
        //        new ListLoaiPhong() { LoaiPhong = "phong 3", SoNguoi = 1 }
        //    };
        //    return list;
        //}
        //public class ListLoaiPhong
        //{
        //    public string LoaiPhong { get; set; }
        //    public int SoNguoi { get; set; }
        //}
        #endregion

        public delegate void delUpdate(string MaLP);
        private void btnThem_Click(object sender, EventArgs e)
        {
            UpdateLoaiPhong f = new UpdateLoaiPhong();

            delUpdate del = new delUpdate(f.GetMaLoaiPhong);
            del(LoaiPhongDAO.Instance.GetMaLP());
            //--------Form 1
            //private void btnSend_Click(object sender, System.EventArgs e)
            //{
            //    Form2 frm = new Form2();
            //    delPassData del = new delPassData(frm.funData);
            //    del(this.textBox1);
            //    frm.Show();
            //}
            //-----------Form 2
            //public void funData(TextBox txtForm1)
            //{
            //    label1.Text = txtForm1.Text;
            //}
            f.ShowDialog();

            if (cbLoaiPhong.Text != "Tất cả")
            {
                LoadListViewTheoComboBox();
            }
            else
            {
                LoadListView();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UpdateLoaiPhong f = new UpdateLoaiPhong();

            string MaLoaiPhong = lvDanhSachLoaiPhong.CheckedItems[0].SubItems[0].Text;
            delUpdate del = new delUpdate(f.GetMaLoaiPhong);
            del(MaLoaiPhong);

            f.ShowDialog();

            if (cbLoaiPhong.Text != "Tất cả")
            {
                LoadListViewTheoComboBox();
            }
            else
            {
                LoadListView();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vẫn muốn xóa ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                int i = 0;
                if (lvDanhSachLoaiPhong.CheckedItems.Count > 0)
                {                    
                    foreach (ListViewItem item in lvDanhSachLoaiPhong.CheckedItems)
                    {
                        int checkTT = LoaiPhongDAO.Instance.CheckXoaLoaiPhong_ThanhToan(item.Text);
                        int checkP = LoaiPhongDAO.Instance.CheckXoaLoaiPhong_Phong(item.Text);

                        if (checkTT > 0 || checkP > 0)
                        {
                            if (checkTT > 0)
                            {
                                MessageBox.Show("Vẫn còn hóa đơn chưa được thanh toán với loại phòng \"" + item.SubItems[1].Text + "\"");
                            }
                            else if(checkP > 0)
                            {
                                MessageBox.Show("Loại phòng \"" + item.SubItems[1].Text + "\"đang được sử dụng");
                            }
                        }
                        else
                        {
                            if (LoaiPhongDAO.Instance.XoaLoaiPhong(item.Text))
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
                    string del = string.Format("Xóa thành công {0} mục", i.ToString());
                    MessageBox.Show(del);
                    LoadListView();
                }
            }
        }

        public delegate void delShow(ListViewItem lv);
        private void btnXem_Click(object sender, EventArgs e)
        {
            UpdateLoaiPhong f = new UpdateLoaiPhong();
            delShow del = new delShow(f.GetListLoaiPhong);
            del(lvDanhSachLoaiPhong.CheckedItems[0]);

            f.ShowDialog();

            if (cbLoaiPhong.Text != "Tất cả")
            {
                LoadListViewTheoComboBox();
            }
            else
            {
                LoadListView();
            }
        }

    }
}


// //-------------------------------------------Tạo Delegate--------------------------------------
//public delegate void delPassData(TextBox text);
//--------Form 1
//private void btnSend_Click(object sender, System.EventArgs e)
//{
//    Form2 frm = new Form2();
//    delPassData del = new delPassData(frm.funData);
//    del(this.textBox1);
//    frm.Show();
//}
//-----------Form 2
//public void funData(TextBox txtForm1)
//{
//    label1.Text = txtForm1.Text;
//}



////------------------hiện toolTip cho listviewItems-----------------------------------------------
// Declare the ListView.
//private ListView ListViewWithToolTips;
//private void InitializeItemsWithToolTips()
//{

//    // Construct and set the View property of the ListView.
//    ListViewWithToolTips = new ListView();
//    ListViewWithToolTips.Width = 200;
//    ListViewWithToolTips.View = View.List;

//    // Show item tooltips.
//    ListViewWithToolTips.ShowItemToolTips = true;

//    // Create items with a tooltip.
//    ListViewItem item1WithToolTip = new ListViewItem("Item with a tooltip");
//    item1WithToolTip.ToolTipText = "This is the item tooltip.";
//    ListViewItem item2WithToolTip = new ListViewItem("Second item with a tooltip");
//    item2WithToolTip.ToolTipText = "A different tooltip for this item.";

//    // Create an item without a tooltip.
//    ListViewItem itemWithoutToolTip = new ListViewItem("Item without tooltip.");

//    // Add the items to the ListView.
//    ListViewWithToolTips.Items.AddRange(new ListViewItem[]{item1WithToolTip,
//        item2WithToolTip, itemWithoutToolTip});

//    // Add the ListView to the form.
//    this.Controls.Add(ListViewWithToolTips);
//    this.Controls.Add(button1);
//}
////----------------------------------------------------------------------------------------------

