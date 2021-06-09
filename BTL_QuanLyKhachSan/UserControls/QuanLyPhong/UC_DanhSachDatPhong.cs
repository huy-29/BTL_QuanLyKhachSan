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

namespace BTL_QuanLyKhachSan.UserControls.QuanLyPhong
{
    public partial class UC_DanhSachDatPhong : UserControl
    {
        public UC_DanhSachDatPhong()
        {
            InitializeComponent();

            LoadComboBoxPhong();
            EnableButton(1, 0, 0, 0, 0);
            LoadListView();

            lblCheck_NhanPhong.Visible = false;
        }

        void EnableButton(int them, int sua, int xoa, int xem, int nhanPhong)
        {
            if (them == 1) { btnThem.Enabled = true; }
            else { btnThem.Enabled = false; }

            if (sua == 1) { btnSua.Enabled = true; }
            else { btnSua.Enabled = false; }

            if (xoa == 1) { btnXoa.Enabled = true; }
            else { btnXoa.Enabled = false; }

            if (xem == 1) { btnXem.Enabled = true; }
            else { btnXem.Enabled = false; }

            if (nhanPhong == 1) { btnNhanPhong.Enabled = true; }
            else { btnNhanPhong.Enabled = false; }

        }

        void LoadComboBoxPhong()
        {
            List<Phong> list = new List<Phong>();

            list.Add(new Phong("Tất cả", "", "", ""));
            foreach (Phong item in PhongDAO.Instance.GetListPhong())
            {
                list.Add(item);
            }

            cbPhong.DataSource = list;
            cbPhong.DisplayMember = "MaPhong";
            //cbLoaiPhong.Text = "";
        }

        void LoadToListView(List<ThuePhong> list)
        {
            lvDanhSachDatPhong.Items.Clear();

            foreach(ThuePhong item in list)
            {
                if(item.TienDat != 0)
                {
                    ListViewItem lvItem = new ListViewItem(item.MaThuePhong);

                    foreach (KhachHang item1 in DatPhongDAO.Instance.GetListKhachHang())
                    {
                        if (item.MaKhachHang == item1.MaKhachHang)
                        {
                            lvItem.SubItems.Add(item1.TenKhachHang);
                            break;
                        }
                    }

                    lvItem.SubItems.Add(item.MaPhong);
                    lvItem.SubItems.Add(item.SoNguoi.ToString());

                    string Start = string.Format("{0:dd/MM/yyyy HH:mm}", item.CheckIn);
                    //string Start = item.CheckIn.ToString("dd/MM/yyyy HH:mm");
                    lvItem.SubItems.Add(Start);
                    string End = string.Format("{0:dd/MM/yyyy HH:mm}", item.CheckOut);
                    lvItem.SubItems.Add(End);

                    lvItem.SubItems.Add(item.TienDat.ToString());

                    lvDanhSachDatPhong.Items.Add(lvItem);
                }
            }
        }

        void LoadListView()
        {
            List<ThuePhong> list = DatPhongDAO.Instance.GetListThuePhong(cbSapXep.Text);

            LoadToListView(list);
        }

        void LoadTimKiem()
        {
            string KH = txbKhachHang.Text;

            string P = cbPhong.Text;
            if(P == "Tất cả") { P = ""; }
            
            string Start = "";
            string End = "";

            if (txbCheckIn.Text != "")
            {
                try
                {
                    DateTime d1 = Convert.ToDateTime(txbCheckIn.Text);
                    Start = d1.Year.ToString();
                    if (d1.Month < 10)
                    {
                        if (d1.Day < 10)
                        {
                            Start = Start + "0" + d1.Month.ToString() + "0" + d1.Day.ToString();
                        }
                        else if (d1.Day >= 10)
                        {
                            Start = Start + "0" + d1.Month.ToString() + d1.Day.ToString();
                        }
                    }
                    else if (d1.Month >= 10)
                    {
                        if (d1.Day < 10)
                        {
                            Start = Start + d1.Month.ToString() + "0" + d1.Day.ToString();
                        }
                        else if (d1.Day >= 10)
                        {
                            Start = Start + d1.Month.ToString() + d1.Day.ToString();
                        }
                    }

                    Start = Start + " " + d1.Hour + ":" + d1.Minute;
                }
                catch { Start = "err"; }
            }

            if (txbCheckOut.Text != "")
            {
                try
                {
                    DateTime d1 = Convert.ToDateTime(txbCheckOut.Text);
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

                    End = End + " " + d1.Hour + ":" + d1.Minute;
                }
                catch { End = "err"; }
            }

            List<ThuePhong> list = DatPhongDAO.Instance.TimDatPhong(KH, P, Start, End, cbSapXep.Text);

            LoadToListView(list);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadTimKiem();
        }

        private void dtCheckIn_CloseUp(object sender, EventArgs e)
        {
            txbCheckIn.Text = dtCheckIn.Text;
        }

        private void dtCheckOut_CloseUp(object sender, EventArgs e)
        {
            txbCheckOut.Text = dtCheckOut.Text;
        }

        private void lvDanhSachDatPhong_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvDanhSachDatPhong.CheckedItems.Count != 1)
            {
                EnableButton(1, 0, 0, 0, 0);
            }
            else if (lvDanhSachDatPhong.CheckedItems.Count == 1)
            {
                EnableButton(1, 1, 1, 1, 1);
            }
        }


        public delegate void delThuePhong(string P, string TP, string KH, string task);
        private void btnThem_Click(object sender, EventArgs e)
        {
            string TP = DatPhongDAO.Instance.GetMaThuePhong();
            string KH = DatPhongDAO.Instance.GetMaKH();

            UpdateNhanPhong f = new UpdateNhanPhong();
            delThuePhong del = new delThuePhong(f.NhanPhong);
            del("", TP, KH, "Đặt mới");
            f.ShowDialog();

            LoadTimKiem();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvDanhSachDatPhong.CheckedItems[0];

            string TP = item.Text;
            string P = item.SubItems[2].Text;
            string KH = DatPhongDAO.Instance.GetMaKhachHangByMaTP(TP);

            UpdateNhanPhong f = new UpdateNhanPhong();
            delThuePhong del = new delThuePhong(f.NhanPhong);
            del(P, TP, KH, "Sửa đặt phòng");
            f.ShowDialog();

            LoadTimKiem();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvDanhSachDatPhong.CheckedItems[0];

            string TP = item.Text;
            string P = item.SubItems[2].Text;
            string KH = DatPhongDAO.Instance.GetMaKhachHangByMaTP(TP);

            UpdateNhanPhong f = new UpdateNhanPhong();
            delThuePhong del = new delThuePhong(f.NhanPhong);
            del(P, TP, KH, "Xem");
            f.ShowDialog();

        }

        int CheckNhanPhong(string TP, string P)
        {

            string TT = DatPhongDAO.Instance.GetTrangThaiPhongByMaPhong(P);

            List<ThuePhong> list = DatPhongDAO.Instance.GetListDatPhongByMaTP(TP);
            DateTime now = DateTime.Now;
            DateTime d1 = new DateTime();
            DateTime d2 = new DateTime();
            int i = 0;

            foreach(ThuePhong item in list)
            {
                //d1 = item.CheckIn;
                d1 = Convert.ToDateTime(item.CheckIn);
                d2 = Convert.ToDateTime(item.CheckOut);

                if (now > d2)
                {
                    if (item.MaThuePhong == TP)
                    {
                        return 1;
                    }
                }
                if (TT != "Trống" && TT != "Đặt trước")
                {
                    return 2;
                }
                if (d1 <= now && now <= d2)
                {
                    if (item.MaThuePhong == TP)
                    {
                        return 0;
                    }
                    else if (item.MaThuePhong != TP)
                    {
                        return 3;
                    }
                }
                else if (now < d1)
                {
                    if (item.MaThuePhong == TP)
                    {
                        if (i == 0)
                        {
                            return 4;
                        }
                        else if (i != 0)
                        {
                            return 5;
                        }
                    }
                    else if (item.MaThuePhong != TP)
                    {
                        i++;
                    }
                }
     
            }

            return 0;
        }
        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            lblCheck_NhanPhong.Visible = false;

            ListViewItem item = lvDanhSachDatPhong.CheckedItems[0];
            string TP = item.Text;
            string P = item.SubItems[2].Text;

            int check = CheckNhanPhong(TP, P);
            if(check == 0)
            {
                DatPhongDAO.Instance.NhanPhong(TP, Convert.ToDecimal(item.SubItems[6].Text));
                ThuePhongDAO.Instance.UpdateTrangThaiPhong(P);
                LoadTimKiem();
            }
            else if (check == 1)
            {
                DialogResult result = MessageBox.Show("Đã quá thời hạn nhận phòng. Phiếu thuê phòng sẽ bị xóa khỏi hệ thống", "", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    XoaDatPhong();
                }
            }
            else if(check == 2)
            {
                lblCheck_NhanPhong.Visible = true;
                lblCheck_NhanPhong.Text = "Phòng đang có người thuê hoặc đang bảo trì";
            }
            else if (check == 3)
            {
                lblCheck_NhanPhong.Visible = true;
                lblCheck_NhanPhong.Text = "Đang trong thời gian đặt phòng của khách hàng khác";
            }
            else if (check == 4)
            {
                DialogResult result = MessageBox.Show("Vẫn chưa đến thời gian phải nhận phòng. Muốn nhận sớm??", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DatPhongDAO.Instance.NhanPhong(TP, Convert.ToDecimal(item.SubItems[6].Text));
                    ThuePhongDAO.Instance.UpdateTrangThaiPhong(P);
                    LoadTimKiem();
                }
            }
            else if (check == 5)
            {
                lblCheck_NhanPhong.Visible = true;
                lblCheck_NhanPhong.Text = "Chưa đến lượt để nhận phòng";
            }
            
        }

        void XoaDatPhong()
        {
            ListViewItem item = lvDanhSachDatPhong.CheckedItems[0];

            ThuePhongDAO.Instance.UpdateTrangThaiPhong(item.SubItems[2].Text);
            LoadTimKiem();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaDatPhong();
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


////-------------------------------------------TOOLTIP-----------------------------------------
//string m = string.Format("ngày 1" + "-" + "ngày 1.2" + "\n" + "ngày 2" + "-" + "ngày 2.2" + "\n" + "ngày 3" + "-" + "ngày 3.2" + "\n" + "ngày 4" + "-" + "ngày 4.2" + "\n" + "ngày 5" + "-" + "ngày 5.2" + "\n" + "ngày 6" + "-" + "ngày 6.2");
////MessageBox.Show(m);

//ListViewItem item1WithToolTip = new ListViewItem("Item with a tooltip");
//item1WithToolTip.ToolTipText = "This is the item tooltip.";
//ListViewItem item2WithToolTip = new ListViewItem("Second item with a tooltip");
//item2WithToolTip.ToolTipText = m;

//item2WithToolTip.SubItems.Add("SubItem 2 dffffffff");
//item2WithToolTip.SubItems.Add(m);


//lvDS.Items.Add(item1WithToolTip);
//lvDS.Items.Add(item2WithToolTip);




