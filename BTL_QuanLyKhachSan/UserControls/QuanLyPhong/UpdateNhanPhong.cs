using BTL_QuanLyKhachSan.DAO;
using BTL_QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BTL_QuanLyKhachSan.UserControls.QuanLyPhong
{
    public partial class UpdateNhanPhong : Form
    {
        public UpdateNhanPhong()
        {
            InitializeComponent();
            lblCheck_TenKH.Visible = false;
            lblCheck_DienThoai.Visible = false;
            lblCheck_DiaChi.Visible = false;
            lblCheck_Phong.Visible = false;
            lblCheck_MucGia.Visible = false;
            lblCheck_PhuongThuc.Visible = false;
            lblCheck_CheckOut.Visible = false;
            lblCheck_TienDat.Visible = false;
            lblCheck_SoNguoi.Visible = false;
            txbTienDat.ReadOnly = true;
            pnlGiaTrongKhoangNgay.Visible = false;

            tt.Hide(dtCheckIn);
            tt.Hide(dtCheckOut);

            LoadComboBoxPhong();

        }

        public static string Task;
        public void NhanPhong(string P, string TP, string KH, string task)
        {
            
            Task = task;

            txbMaKH.Text = KH;
            txbMaThuePhong.Text = TP;

            cbPhong.SelectedIndex = -1; //---Lấy sự kiện combobox selected changed---------??????????????
            cbPhong.Text = P;

            if (Task == "Thêm")
            {
                chkDatPhong.Checked = false;
            }
            else if(Task == "Đặt mới")
            {
                chkDatPhong.Checked = true;
            }
            else  if(Task == "Xem")
            {
                FillInfo(TP, KH);
                chkDatPhong.Checked = true;
                pnlThongTin.Enabled = false;
                btnLuu.Visible = false;
            }
            else if (Task == "Sửa đặt phòng")
            {
                FillInfo(TP, KH);
                chkDatPhong.Checked = true;
                chkDatPhong.Enabled = false;
            }

        }
        void FillInfo(string TP, string KH)
        {
            List<ThuePhong> listTP = SoDoPhongDAO.Instance.GetListThuePhongByMaThuePhong(TP);
            foreach(ThuePhong item in listTP)
            {
                txbTienDat.Text = item.TienDat.ToString();
                dtCheckIn.Value = item.CheckIn;
                dtCheckOut.Value = item.CheckOut;
                txbSoNguoi.Text = item.SoNguoi.ToString();
            }

            List<KhachHang> listKH = SoDoPhongDAO.Instance.GetListKhachHangByMaKH(KH);
            foreach(KhachHang item in listKH)
            {
                txbTenKH.Text = item.TenKhachHang;
                txbDienThoai.Text = item.DienThoai;
                txbDiaChi.Text = item.DiaChi;
            }

            List<ThanhToan> listTT = SoDoPhongDAO.Instance.GetListThanhToanHienTaiByMaThuePhong(TP);
            string PhuongThuc = "";
            foreach(ThanhToan item in listTT)
            {
                foreach(MucGia item1 in SoDoPhongDAO.Instance.GetListMucGiaByMaMucGia(item.MaMucGia))
                {
                    if(item1.MaMucGia == item.MaMucGia)
                    {
                        cbMucGia.Text = item1.TenMucGia;
                        txbGiaThemNguoi.Text = item1.DonGiaThemNguoi.ToString() + "/ Người";
                        
                        if(item.PhuongThucTT == "Giờ")
                        {
                            PhuongThuc = string.Format(item1.DonGiaGio.ToString() + "/ " + "Giờ");
                        }
                        else if(item.PhuongThucTT == "Ngày")
                        {
                            PhuongThuc = string.Format(item1.DonGiaNgay.ToString() + "/ " + "Ngày");
                        }
                        break;
                    }
                }
                cbPhuongThuc.Text = PhuongThuc;
            }
               
            
        }
        void LoadComboBoxPhong()
        {
            List<Phong> list = PhongDAO.Instance.GetListPhong();

            cbPhong.DataSource = list;
            cbPhong.DisplayMember = "MaPhong";
        }

        private void chkDatPhong_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDatPhong.Checked == true)
            {
                txbTienDat.ReadOnly = false;
            }
            else if(chkDatPhong.Checked == false)
            {
                txbTienDat.ReadOnly = true;
                txbTienDat.Text = "0";
            }
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbMucGia.Text = "";
            //txbGiaThemNguoi.Text = "";
            cbPhuongThuc.Items.Clear();
            //cbPhuongThuc.Text = "";
            pnlGiaTrongKhoangNgay.Visible = false;

            //string a = cbPhong.Text;
            List<MucGia> listMG = SoDoPhongDAO.Instance.GetListMucGiaByMaPhong(cbPhong.Text);

            cbMucGia.DataSource = listMG;
            cbMucGia.DisplayMember = "TenMucGia";            
        }

        private void cbMucGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<MucGia> listMG = SoDoPhongDAO.Instance.GetListMucGiaByTenMucGia(cbMucGia.Text);
            //DateTime dtSoSanh = new DateTime(1900, 10, 10);

            //foreach (MucGia item in listMG)
            //{
            //    txbGiaThemNguoi.Text = string.Format(item.DonGiaThemNguoi.ToString() + "/ người");
            //    cbPhuongThuc.Items.Clear();
            //    cbPhuongThuc.Items.Add(item.DonGiaNgay.ToString() + "/ Ngày");
            //    cbPhuongThuc.Items.Add(item.DonGiaGio.ToString() + "/ Giờ");

            //    if (item.NgayBatDau.Date == dtSoSanh)
            //    {
            //        pnlGiaTrongKhoangNgay.Visible = false;
            //    }
            //    else if (item.NgayBatDau != dtSoSanh)
            //    {
            //        pnlGiaTrongKhoangNgay.Visible = true;
            //        dtNgayBatDau.Value = item.NgayBatDau;
            //        dtNgayKetThuc.Value = item.NgayKetThuc;
            //    }
            //}
        }
 
        private void cbMucGia_SelectedValueChanged(object sender, EventArgs e)
        {
            List<MucGia> listMG = SoDoPhongDAO.Instance.GetListMucGiaByTenMucGia(cbMucGia.Text);
            DateTime dtSoSanh = new DateTime(1900, 10, 10);

            foreach (MucGia item in listMG)
            {
                txbGiaThemNguoi.Text = string.Format(item.DonGiaThemNguoi.ToString() + "/ người");
                cbPhuongThuc.Items.Clear();
                cbPhuongThuc.Items.Add(item.DonGiaNgay.ToString() + "/ Ngày");
                cbPhuongThuc.Items.Add(item.DonGiaGio.ToString() + "/ Giờ");

                if (item.NgayBatDau.Date == dtSoSanh)
                {
                    pnlGiaTrongKhoangNgay.Visible = false;
                }
                else if (item.NgayBatDau != dtSoSanh)
                {
                    pnlGiaTrongKhoangNgay.Visible = true;
                    dtNgayBatDau.Value = item.NgayBatDau;
                    dtNgayKetThuc.Value = item.NgayKetThuc;
                }
            }
        }
        int Check()
        {
            int a = 0;
            decimal b = 1;
            if (txbTenKH.Text == "")
            {
                return 1;
            }

            if (Regex.IsMatch(txbTenKH.Text, @"^[aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ ]*$") == false)
            {
                return 2;
            }
            if (txbDienThoai.Text == "")
            {
                return 3;
            }
            if (Regex.IsMatch(txbDienThoai.Text, @"^[\+]?[0-9]*$") == false)
            {
                return 4;
            }
            if (txbDiaChi.Text == "")
            {
                return 5;
            }
            if (Regex.IsMatch(txbDiaChi.Text, @"^[/0-9aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ ]*$") == false)
            {
                return 6;
            }
            if (txbSoNguoi.Text == "")
            {
                return 7;
            }
            if (Regex.IsMatch(txbSoNguoi.Text, @"^[0-9]*$") == false)
            {
                return 8;
            }

            DateTime dt1 = dtCheckIn.Value;
            DateTime dt2 = dtCheckOut.Value;
            DateTime now = DateTime.Now;

            if(dt1 < now) { return 9; }
            else if(dt1 >= now)
            {
                if (dt2.Year < dt1.Year) { a = 9; }
                else if (dt2.Year == dt1.Year)
                {
                    if (dt2.Month < dt1.Month) { a = 9; }
                    else if (dt2.Month == dt1.Month)
                    {
                        if (dt2.Day < dt1.Day) { a = 9; }
                        else if (dt2.Day == dt1.Day)
                        {
                            if (dt2.Hour < dt1.Hour) { a = 9; }
                            else if (dt2.Hour >= dt1.Hour)
                            {
                                TimeSpan span = dt2 - dt1;
                                TimeSpan spanSS = new TimeSpan(1, 0, 0);
                                if (span < spanSS) { a = 9; }
                            }
                        }
                    }
                }
            }
            if (a == 9) { return 9; }

            if(chkDatPhong.Checked == true)
            {
                if(txbTienDat.Text == "") { return 10; }
                if(Decimal.TryParse(txbTienDat.Text, out b) == false || txbTienDat.Text.Contains(",") == true || txbTienDat.Text.Contains(".") == true || b == 0)
                {
                    return 11;
                }
            }

            a = 12;
            foreach(Phong item in cbPhong.Items)
            {
                if(cbPhong.Text == item.MaPhong)
                {
                    a = 0;
                    break;
                }
            }
            if (a == 12) { return 12; }
            if(SoDoPhongDAO.Instance.GetTrangThaiPhongByMaPhong(cbPhong.Text) != "Trống" && chkDatPhong.Checked == false)
            {
                return 13;
            }
            if (SoDoPhongDAO.Instance.GetTrangThaiPhongByMaPhong(cbPhong.Text) == "Bảo trì" && chkDatPhong.Checked == false)
            {
                return 14;
            }
            foreach (ThuePhong item in SoDoPhongDAO.Instance.GetListThuePhongByMaPhong(cbPhong.Text))
            {
                if (((dt1 > item.CheckIn && dt1 < item.CheckOut) || (dt2 > item.CheckIn && dt2 < item.CheckOut)
                     || (dt1 <= item.CheckIn && dt2 >= item.CheckOut)) && item.MaKhachHang != txbMaKH.Text)
                {
                    return 15;

                }
            }

            a = 16;
            foreach (MucGia item in cbMucGia.Items)
            {
                if (cbMucGia.Text == item.TenMucGia)
                {
                    a = 0;
                    break;
                }
            }
            if (a == 16) { return 16; }
            if (cbPhuongThuc.Text == "")
            {
                return 17;
            }
            if (cbPhuongThuc.Text.Contains("Ngày") && (dt1.Hour != 12 || dt1.Minute != 00 || dt2.Hour != 12 || dt2.Minute != 00) )
            {
                return 18;
            }

            return a;
        }

        void UpdateTP()
        {
            string MaTP = txbMaThuePhong.Text;
            string MaKH = txbMaKH.Text;
            string MaP= cbPhong.Text;
            int Nguoi = Convert.ToInt32(txbSoNguoi.Text);

            string Start = "";
            string End = "";

            DateTime d1 = dtCheckIn.Value;
            DateTime d2 = dtCheckOut.Value;

            if (d1.Month < 10)
            {
                if (d1.Day < 10)
                {
                    Start = string.Format(d1.Year.ToString() + "0" + d1.Month.ToString() + "0" + d1.Day.ToString() + " " +d1.Hour.ToString() + ":" + d1.Minute.ToString());                
                }
                else if (d1.Day >= 10)
                {
                    Start = string.Format(d1.Year.ToString() + "0" + d1.Month.ToString() + d1.Day.ToString() + " " +d1.Hour.ToString() + ":" + d1.Minute.ToString());
                }
            }
            else if (d1.Month >= 10)
            {
                if (d1.Day < 10)
                {
                    Start = string.Format(d1.Year.ToString() + d1.Month.ToString() + "0" + d1.Day.ToString() + " " + d1.Hour.ToString() + ":" + d1.Minute.ToString());
                }
                else if (d1.Day >= 10)
                {
                    Start = string.Format(d1.Year.ToString() + d1.Month.ToString() + d1.Day.ToString() + " "  +d1.Hour.ToString() + ":" + d1.Minute.ToString());
                }
            }

            if (d2.Month < 10)
            {
                if (d2.Day < 10)
                {
                    End = string.Format(d2.Year.ToString() + "0" + d2.Month.ToString() + "0" + d2.Day.ToString() + " " + d2.Hour.ToString() + ":" + d2.Minute.ToString());
                }
                else if (d1.Day >= 10)
                {
                    End = string.Format(d2.Year.ToString() + "0" + d2.Month.ToString() + d2.Day.ToString() + " " + d2.Hour.ToString() + ":" + d2.Minute.ToString());
                }
            }
            else if (d2.Month >= 10)
            {
                if (d2.Day < 10)
                {
                    End = string.Format(d2.Year.ToString() + d2.Month.ToString() + "0" + d2.Day.ToString() + " " + d2.Hour.ToString() + ":" + d2.Minute.ToString());
                }
                else if (d2.Day >= 10)
                {
                    End = string.Format(d2.Year.ToString() + d2.Month.ToString() + d2.Day.ToString() + " " + d2.Hour.ToString() + ":" + d2.Minute.ToString());
                }
            }

            decimal TienDat;
            if (chkDatPhong.Checked)
            {
                TienDat = Convert.ToDecimal(txbTienDat.Text);
            }
            else
            {
                TienDat = 0;
            }

            string TenKH = txbTenKH.Text;
            string DT = txbDienThoai.Text;
            string DiaChi = txbDiaChi .Text;
            string TenMG = cbMucGia.Text;
            string PhuongThuc = "";

            if(cbPhuongThuc.Text.Contains("Ngày") == true)
            {
                PhuongThuc = "Ngày";
            }
            else if (cbPhuongThuc.Text.Contains("Giờ"))
            {
                PhuongThuc = "Giờ";
            }
            SoDoPhongDAO.Instance.UpdateThuePhong(Task, MaTP, MaKH, MaP, Nguoi, Start, End, TienDat, TenKH, DT, DiaChi, TenMG, PhuongThuc);
            
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            lblCheck_TenKH.Visible = false;
            lblCheck_DienThoai.Visible = false;
            lblCheck_DiaChi.Visible = false;
            lblCheck_Phong.Visible = false;
            lblCheck_MucGia.Visible = false;
            lblCheck_PhuongThuc.Visible = false;
            lblCheck_CheckOut.Visible = false;
            lblCheck_TienDat.Visible = false;
            lblCheck_SoNguoi.Visible = false;

            tt.SetToolTip(dtCheckIn, null);
            tt.SetToolTip(dtCheckOut, null);

            //pnlGiaTrongKhoangNgay.Visible = false;
            if (Check() == 0)
            {
                UpdateTP();
                ThuePhongDAO.Instance.UpdateTrangThaiPhong(cbPhong.Text);
                this.Close();
            }
            else if (Check() == 1)
            {
                lblCheck_TenKH.Visible = true;
                lblCheck_TenKH.Text = "Chưa điền tên khách hàng";
            }
            else if (Check() == 2)
            {
                lblCheck_TenKH.Visible = true;
                lblCheck_TenKH.Text = "Tên khách hàng chỉ bao gồm chữ số và dấu cách";
            }
            else if (Check() == 3)
            {
                lblCheck_DienThoai.Visible = true;
                lblCheck_DienThoai.Text = "Chưa điền số điện thoại";
            }
            else if (Check() == 4)
            {
                lblCheck_DienThoai.Visible = true;
                lblCheck_DienThoai.Text = "Điện thoại chỉ gồm chữ số hoặc dấu + ở đầu";
            }
            else if (Check() == 5)
            {
                lblCheck_DiaChi.Visible = true;
                lblCheck_DiaChi.Text = "Chưa đìên điạ chỉ";
            }
            else if (Check() == 6)
            {
                lblCheck_DiaChi.Visible = true;
                lblCheck_DiaChi.Text = "Địa chỉ chỉ bao gồm chữ, số và dấu /";
            }
            else if (Check() == 7)
            {
                lblCheck_SoNguoi.Visible = true;
                lblCheck_SoNguoi.Text = "Chưa đìên số người";
            }
            else if (Check() == 8)
            {
                lblCheck_SoNguoi.Visible = true;
                lblCheck_SoNguoi.Text = "Chỉ điền vào số lượng";
            }
            else if (Check() == 9)
            {
                lblCheck_CheckOut.Visible = true;
                lblCheck_CheckOut.Text = "CheckOut phải muộn hơn CheckIn ít nhất 1 giờ" + "\n" + "và phải xuất hiện sau ngày hôm nay";
            }
            else if (Check() == 10)
            {
                lblCheck_TienDat.Visible = true;
                lblCheck_TienDat.Text = "Phải có tiền đặt cho việc đặt phòng";
            }
            else if (Check() == 11)
            {
                lblCheck_TienDat.Visible = true;
                lblCheck_TienDat.Text = "Chỉ điền vào số nguyên và phải lớn hơn 0";
            }
            else if (Check() == 12)
            {
                lblCheck_Phong.Visible = true;
                lblCheck_Phong.Text = "Phòng không hợp lệ";
            }
            else if (Check() == 13)
            {
                lblCheck_Phong.Visible = true;
                lblCheck_Phong.Text = "Phòng chưa sẵn sàng để thuê, có thể chuyển sang đặt phòng";
            }
            else if (Check() == 14)
            {
                lblCheck_Phong.Visible = true;
                lblCheck_Phong.Text = "Phòng đang bảo trì, có thể đặt phòng";
            }
            else if (Check() == 15)
            {
                lblCheck_CheckOut.Visible = true;
                lblCheck_CheckOut.Text = "CheckIn và CheckOut bị trùng ngày với lịch đặt khác";
                
                string tooltip = "";
                foreach (ThuePhong item in SoDoPhongDAO.Instance.GetListThuePhongByMaPhong(cbPhong.Text))
                {
                    if(item.MaKhachHang != txbMaKH.Text)
                    {
                        tooltip = string.Format(tooltip + item.CheckIn.ToString("dd/MM/yyyy HH:mm") + " - " + item.CheckOut.ToString("dd/MM/yyyy HH:mm") + "\n");
                    }
                }
                //ToolTip tt = new ToolTip() { ToolTipTitle = "Các ngày đã thuê", IsBalloon = true, ShowAlways = true };
                //tt.AutoPopDelay = 20000;       

                tt.SetToolTip(dtCheckOut, tooltip);
                tt.SetToolTip(dtCheckIn, tooltip);
            }
            else if (Check() == 16)
            {
                lblCheck_MucGia.Visible = true;
                lblCheck_MucGia.Text = "Mức giá không hợp lệ";
            }
            else if (Check() == 17)
            {
                lblCheck_PhuongThuc.Visible = true;
                lblCheck_PhuongThuc.Text = "Chọn một phương thức tính hóa đơn thuê phòng";
            }
            else if (Check() == 18)
            {
                lblCheck_CheckOut.Visible = true;
                lblCheck_CheckOut.Text = "Trường hợp đặt theo Ngày phải CheckIn và CheckOut" + "\n" + "vào 12:00 sáng trong ngày";
            }   
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbPhuongThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhuongThuc.Text.Contains("Ngày"))
            {

            }
        }
    }
}

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



//-----------------------------------------TOOLTIP + FORMAT DATETIME------------
//string tooltip = "";
//foreach (ThuePhong item in SoDoPhongDAO.Instance.GetListThuePhongByMaPhong(cbPhong.Text))
//{
//    tooltip = string.Format(tooltip + item.CheckIn.ToString("dd/MM/yyyy HH:mm") + " - " + item.CheckOut.ToString("dd/MM/yyyy HH:mm") + "\n");
//}
//ToolTip tt = new ToolTip() { ToolTipTitle = "Các ngày đã thuê", IsBalloon = true, ShowAlways = true };
//tt.AutoPopDelay = 20000;
//tt.SetToolTip(dtCheckOut, tooltip);




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


// ----------------------------------Tạo Delegate----------------------------------------------
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

//------------------------------HIỆN TOOLTIP CHO CONTROLS---------------
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