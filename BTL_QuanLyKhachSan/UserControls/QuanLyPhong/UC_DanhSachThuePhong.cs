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
    public partial class UC_DanhSachThuePhong : UserControl
    {
        public UC_DanhSachThuePhong()
        {
            InitializeComponent();

            LoadComboBoxPhong();
            EnableButton(1, 0, 0, 0, 0);
            LoadListView();

            lblCheck_ChuyenPhong.Visible = false;
        }

        void EnableButton(int them, int sua, int traPhong, int xem, int chuyenPhong)
        {
            if (them == 1) { btnThem.Enabled = true; }
            else { btnThem.Enabled = false; }

            if (sua == 1) { btnSua.Enabled = true; }
            else { btnSua.Enabled = false; }

            if (traPhong == 1) { btnTraPhong.Enabled = true; }
            else { btnTraPhong.Enabled = false; }

            if (xem == 1) { btnXem.Enabled = true; }
            else { btnXem.Enabled = false; }

            if (chuyenPhong == 1) { btnChuyenPhong.Enabled = true; }
            else { btnChuyenPhong.Enabled = false; }

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
            lvDanhSachThuePhong.Items.Clear();

            foreach (ThuePhong item in list)
            {
                if (item.TienDat == 0)
                {
                    ListViewItem lvItem = new ListViewItem(item.MaThuePhong);

                    foreach (KhachHang item1 in ThuePhongDAO.Instance.GetListKhachHang())
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

                    string GhiChu = ThuePhongDAO.Instance.GetGhiChuByMaTP(item.MaThuePhong);
                    lvItem.SubItems.Add(GhiChu);

                    lvDanhSachThuePhong.Items.Add(lvItem);
                }
            }
        }

        void LoadListView()
        {
            List<ThuePhong> list = ThuePhongDAO.Instance.GetListThuePhong(cbSapXep.Text);

            LoadToListView(list);
        }

        void LoadTimKiem()
        {
            string KH = txbKhachHang.Text;

            string P = cbPhong.Text;
            if (P == "Tất cả") { P = ""; }

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

            int EndMuon = 0;
            if(chkCheckOutMuon.Checked == true)
            {
                EndMuon = 1;
            }
            List<ThuePhong> list = ThuePhongDAO.Instance.TimThuePhong(KH, P, Start, End, EndMuon, cbSapXep.Text);

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

        private void lvDanhSachThuePhong_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            lblCheck_ChuyenPhong.Visible = false;
            if (lvDanhSachThuePhong.CheckedItems.Count != 1)
            {
                EnableButton(1, 0, 0, 0, 0);
            }
            else if (lvDanhSachThuePhong.CheckedItems.Count == 1)
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
            del("", TP, KH, "Thêm");
            f.ShowDialog();

            LoadTimKiem();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvDanhSachThuePhong.CheckedItems[0];

            string TP = item.Text;
            string P = item.SubItems[2].Text;
            string KH = DatPhongDAO.Instance.GetMaKhachHangByMaTP(TP);

            UpdateNhanPhong f = new UpdateNhanPhong();
            delThuePhong del = new delThuePhong(f.NhanPhong);
            del(P, TP, KH, "Sửa thuê phòng");
            f.ShowDialog();

            LoadTimKiem();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvDanhSachThuePhong.CheckedItems[0];

            string TP = item.Text;
            string P = item.SubItems[2].Text;
            string KH = DatPhongDAO.Instance.GetMaKhachHangByMaTP(TP);

            UpdateNhanPhong f = new UpdateNhanPhong();
            delThuePhong del = new delThuePhong(f.NhanPhong);
            del(P, TP, KH, "Xem");
            f.ShowDialog();
        }

        public delegate void delChuyenPhong(string P, string newP);
        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {
            lblCheck_ChuyenPhong.Visible = false;

            ListViewItem item = lvDanhSachThuePhong.CheckedItems[0];

            if (Convert.ToDateTime(item.SubItems[5].Text) > DateTime.Now)
            {
                UpdateChuyenPhong f = new UpdateChuyenPhong();
                delChuyenPhong del = new delChuyenPhong(f.ChuyenPhong);
                del(item.SubItems[2].Text, "");
                f.ShowDialog();
                LoadTimKiem();
            }
            else if (Convert.ToDateTime(item.SubItems[5].Text) <= DateTime.Now)
            {
                lblCheck_ChuyenPhong.Visible = true;
                lblCheck_ChuyenPhong.Text = "Phòng đã quá hạn check-out";
            }
    
        }
        public delegate void delTraPhong(string TP);
        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvDanhSachThuePhong.CheckedItems[0];

            string TP = item.Text;

            UpdateHoaDon f = new UpdateHoaDon();
            delTraPhong del = new delTraPhong(f.TinhHoaDon);
            del(TP);
            f.ShowDialog();
        }
     
    }
}

//-------------------------CỘNG TRỪ THỜI GIAN-------------------------------------------
//    public static void Main(string[] args)
//    {
//        // Thời điểm hiện tại.
//        DateTime aDateTime = DateTime.Now;

//        Console.WriteLine("Now is " + aDateTime);

//        // Một khoảng thời gian. 
//        // 1 giờ + 1 phút
//        TimeSpan aInterval = new System.TimeSpan(0, 1, 1, 0);

//        // Thêm một khoảng thời gian.
//        DateTime newTime1 = aDateTime.Add(aInterval);


//        Console.WriteLine("After add 1 hour, 1 minute: " + newTime1);

//        // Trừ khoảng thời gian.
//        DateTime newTime2 = aDateTime.Subtract(aInterval);

//        Console.WriteLine("After subtract 1 hour, 1 minute: " + newTime2);

//        Console.WriteLine("After subtract each other: {0}", newTime2 - newTime1);

//        Console.Read();
//    }
//-------Kết QUẢ
//Now is 5 / 11 / 2021 2:35:33 PM
//After add 1 hour, 1 minute: 5 / 11 / 2021 3:36:33 PM
//After subtract 1 hour, 1 minute: 5 / 11 / 2021 1:34:33 PM
//After subtract each other: -02:02:00


//-------------------------------------Hiện FORRM VÀO PANEL, CHỈNH THÀNH USERCONTROL-------------
//private void button1_Click(object sender, EventArgs e)
//{
//    Form2 frm2 = new Form2();
//    frm2.TopLevel = false;
//    panel1.Controls.Add(frm2);
//    if (checkBox1.Checked)
//    {
//        frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
//    }
//    frm2.Dock = DockStyle.Fill;
//    frm2.Show();
//}