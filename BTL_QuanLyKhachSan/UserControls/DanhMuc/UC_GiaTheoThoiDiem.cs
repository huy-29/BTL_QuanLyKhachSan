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

namespace BTL_QuanLyKhachSan.UserControls.DanhMuc.GiaTheoThoiDiem
{
    public partial class UC_GiaTheoThoiDiem : UserControl
    {
        private DangNhap dangNhap;

        public DangNhap DangNhap { get => dangNhap; set => dangNhap = value; }
        public UC_GiaTheoThoiDiem(DangNhap Login)
        {
            InitializeComponent();

            this.DangNhap = Login;

            LoadComboBoxLoaiPhong();
            LoadComboBoxTenMucGia();
            EnableButton(1, 0, 0);
            LoadListView();      

        }
        void EnableButton(int them, int sua, int xoa)
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
            else if (DangNhap.ChucVu != "Quản lý")
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

            }


        }
        void LoadComboBoxLoaiPhong()
        {
            List<LoaiPhong> list = new List<LoaiPhong>();

            list.Add(new LoaiPhong("", "Tất cả", 0, ""));
            foreach (LoaiPhong item in MucGiaDAO.Instance.GetListLoaiPhong())
            {
                list.Add(item);
            }
            cbLoaiPhong.DataSource = list;
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
            //cbLoaiPhong.Text = "";
        }
        void LoadComboBoxTenMucGia()
        {
            List<MucGia> list = new List<MucGia>();

            list.Add(new MucGia("", "Tất cả", 0, 0, 0, DateTime.Now, DateTime.Now, ""));
            foreach (MucGia item in MucGiaDAO.Instance.GetListMucGia())
            {
                list.Add(item);
            }
            cbTenMucGia.DataSource = list;
            cbTenMucGia.DisplayMember = "TenMucGia";
            //cbLoaiPhong.Text = "";
        }
        void LoadTheoClassMucGia(MucGia item)
        {
            ListViewItem lvItem = new ListViewItem(item.MaMucGia.ToString());
            lvItem.SubItems.Add(item.TenMucGia.ToString());
            lvItem.SubItems.Add(item.DonGiaNgay.ToString());
            lvItem.SubItems.Add(item.DonGiaGio.ToString());
            lvItem.SubItems.Add(item.DonGiaThemNguoi.ToString());

            if (item.NgayBatDau.Year != 1900)
            {
                string Start = string.Format("{0:dd/MM/yyyy}", item.NgayBatDau);
                lvItem.SubItems.Add(Start);
                string End = string.Format("{0:dd/MM/yyyy}", item.NgayKetThuc);
                lvItem.SubItems.Add(End);
            }
            else
            {
                lvItem.SubItems.Add("");
                lvItem.SubItems.Add("");
            }
            foreach (LoaiPhong item1 in MucGiaDAO.Instance.GetListLoaiPhong())
            {
                if (item.MaLoaiPhong == item1.MaLoaiPhong)
                {
                    lvItem.SubItems.Add(item1.TenLoaiPhong.ToString());
                    break;
                }
            }

            lvGiaTheoThoiDiem.Items.Add(lvItem);
        }
        public void LoadListView()
        {
            List<MucGia> listMG = MucGiaDAO.Instance.GetListMucGia();

            lvGiaTheoThoiDiem.Items.Clear();

            foreach (MucGia item in listMG)
            {
                LoadTheoClassMucGia(item);
            }
        }

        public delegate void delUpdate(string MaMG);
        private void btnThem_Click(object sender, EventArgs e)
        {
            UpdateMucGia f = new UpdateMucGia();

            delUpdate del = new delUpdate(f.GetMaMucGia);
            del(MucGiaDAO.Instance.GetMaMG());

            f.ShowDialog();

            //LoadListView();
            LoadTimKiem();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UpdateMucGia f = new UpdateMucGia();

            string MaMucGia = lvGiaTheoThoiDiem.CheckedItems[0].SubItems[0].Text;
            delUpdate del = new delUpdate(f.GetListMucGiaToUpdate);
            del(MaMucGia);

            f.ShowDialog();
            //LoadListView();

            LoadTimKiem();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vẫn muốn xóa ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                int i = 0;
                if (lvGiaTheoThoiDiem.CheckedItems.Count > 0)
                {
                    foreach (ListViewItem item in lvGiaTheoThoiDiem.CheckedItems)
                    {
                        if (MucGiaDAO.Instance.CheckXoaMucGia(item.Text) > 0)
                        {
                            MessageBox.Show("Vẫn còn đơn thanh toán với mức giá \"" + item.SubItems[1].Text + "\" chưa được thanh toán");
                        }
                        else
                        {
                            if (MucGiaDAO.Instance.XoaMucGia(item.Text))
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

        void LoadTimKiem()
        {
            string tenMG = cbTenMucGia.Text;
            string LP = cbLoaiPhong.Text;
            string MinGio = txbMinGio.Text;
            string MaxGio = txbMaxGio.Text;
            string MinNgay = txbMinNgay.Text;
            string MaxNgay = txbMaxNgay.Text;
            string Start = "";
            string End = "";
            
            if(tenMG == "Tất cả") { tenMG = ""; }
            if(LP == "Tất cả") { LP = ""; }            

            if (txbNgayBatDau.Text != "")
            {   
                try
                {
                    DateTime d1 = Convert.ToDateTime(txbNgayBatDau.Text);
                    Start = d1.Year.ToString();
                    if (d1.Month < 10)
                    {
                        if(d1.Day < 10)
                        {
                            Start = Start + "0" + d1.Month.ToString() + "0" + d1.Day.ToString();
                        }
                        else if(d1.Day >= 10)
                        {
                            Start = Start + "0" + d1.Month.ToString() + d1.Day.ToString();
                        }
                    }
                    else if (d1.Month >= 10)
                    {
                        if(d1.Day < 10)
                        {
                            Start = Start + d1.Month.ToString() + "0" + d1.Day.ToString();
                        }
                        else if(d1.Day >= 10)
                        {
                            Start = Start + d1.Month.ToString() + d1.Day.ToString();
                        }
                    }
                }
                catch { Start = "err"; }
            }

            if (txbNgayKetThuc.Text != "")
            {         
                try
                {
                    DateTime d1 = Convert.ToDateTime(txbNgayKetThuc.Text);
                    End = d1.Year.ToString();
                    if (d1.Month < 10)
                    {
                        if (d1.Day < 10)
                        {
                            End = End + "0" + d1.Month.ToString() + "0" + d1.Day.ToString();
                        }
                        else if (d1.Day >= 10)
                        {
                            End = End + "0" + d1.Month.ToString() + d1.Day.ToString();
                        }
                    }
                    else if (d1.Month >= 10)
                    {
                        if (d1.Day < 10)
                        {
                            End = End + d1.Month.ToString() + "0" + d1.Day.ToString();
                        }
                        else if (d1.Day >= 10)
                        {
                            End = End + d1.Month.ToString() + d1.Day.ToString();
                        }
                    }
                }
                catch { End = "err"; }
            }

            List<MucGia> listMG = MucGiaDAO.Instance.TimMucGia(tenMG, LP, MinGio, MaxGio, MinNgay, MaxNgay, Start, End);
            lvGiaTheoThoiDiem.Items.Clear();

            foreach (MucGia item in listMG)
            {
                LoadTheoClassMucGia(item);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadTimKiem();
        }

        private void lvGiaTheoThoiDiem_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvGiaTheoThoiDiem.CheckedItems.Count == 0)
            {
                EnableButton(1, 0, 0);
            }
            else if (lvGiaTheoThoiDiem.CheckedItems.Count == 1)
            {
                EnableButton(1, 1, 1);
            }
            else
            {
                EnableButton(1, 0, 1);
            }
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtNgayBatDau_CloseUp(object sender, EventArgs e)
        {
            txbNgayBatDau.Text = dtNgayBatDau.Text;
        }

        private void dtNgayKetThuc_CloseUp(object sender, EventArgs e)
        {
            txbNgayKetThuc.Text = dtNgayKetThuc.Text;
        }
    }
}
//---------------------------------Format DateTime------------------------------------------------
/// Khởi tạo thời gian date time 2008-03-09 16:05:07.123
//DateTime dt = new DateTime(2008, 3, 9, 16, 5, 7, 123);
//String.Format("{0:y yy yyy yyyy}", dt);  // "8 08 008 2008"   năm
//String.Format("{0:M MM MMM MMMM}", dt);  // "3 03 Mar March"  tháng
//String.Format("{0:d dd ddd dddd}", dt);  // "9 09 Sun Sunday" ngày
//String.Format("{0:h hh H HH}", dt);  // "4 04 16 16"      giờ 12/24
//String.Format("{0:m mm}", dt);  // "5 05"            phút
//String.Format("{0:s ss}", dt);  // "7 07"            giây
//String.Format("{0:f ff fff ffff}", dt);  // "1 12 123 1230"   phần nhỏ của giây
//String.Format("{0:F FF FFF FFFF}", dt);  // "1 12 123 123"    phần nhỏ của giây(không có số 0)
//String.Format("{0:t tt}", dt);  // "P PM"            A.M. or P.M.
//String.Format("{0:z zz zzz}", dt);  // "-6 -06 -06:00"   muối giờ

////Dấu phân cách trong định dạng của người Đức là "." (chuyển "/" =>".")
//String.Format("{0:d/M/yyyy HH:mm:ss}", dt); // "9/3/2008 16:05:07" - english (en-US)
//String.Format("{0:d/M/yyyy HH:mm:ss}", dt); // "9.3.2008 16:05:07" - german (de-DE)

////Dưới đây là một vài ví dụ về tùy chỉnh định dạng kiểu DateTime
////Định dạng tháng/ngày/năm với ký tự "0" và không có ký tự "0"
//String.Format("{0:M/d/yyyy}", dt);            // "3/9/2008"
//String.Format("{0:MM/dd/yyyy}", dt);          // "03/09/2008"

////Lấy tên của ngày/tháng
//String.Format("{0:ddd, MMM d, yyyy}", dt);    // "Sun, Mar 9, 2008"
//String.Format("{0:dddd, MMMM d, yyyy}", dt);  // "Sunday, March 9, 2008"

////Lấy năm với 2, 4 ký tự
//String.Format("{0:MM/dd/yy}", dt);            // "03/09/08"
//String.Format("{0:MM/dd/yyyy}", dt); // "03/09/2008"


// Tạo Delegate
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

//------------------------------TẠO TOOLTIP CHO CONTROLS (TOOLTIP CHƯA CÓ SẴN)---------------
//string tooltip = "";
//foreach (ThuePhong item in SoDoPhongDAO.Instance.GetListThuePhongByMaPhong(cbPhong.Text))
//{
//    if (item.MaKhachHang != txbMaKH.Text)
//    {
//        tooltip = string.Format(tooltip + item.CheckIn.ToString("dd/MM/yyyy HH:mm") + " - " + item.CheckOut.ToString("dd/MM/yyyy HH:mm") + "\n");
//    }
//}
//ToolTip tt = new ToolTip() { ToolTipTitle = "Các ngày đã thuê", IsBalloon = true, ShowAlways = true };
//tt.AutoPopDelay = 20000;
//tt.SetToolTip(dtCheckOut, tooltip);
//tt.SetToolTip(dtCheckIn, tooltip);

