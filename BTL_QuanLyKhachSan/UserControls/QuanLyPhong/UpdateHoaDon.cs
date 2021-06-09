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

//txbTongTien.Text = TongTienTT(item.MaPhieuTT, CheckIn, CheckOut, item.NgayBatDau, item.NgayKetThuc, MG, item.PhuongThucTT, ThemNguoi, Nguoi, bool chk);     

namespace BTL_QuanLyKhachSan.UserControls.QuanLyPhong
{
    public partial class UpdateHoaDon : Form
    {
        public UpdateHoaDon()
        {
            InitializeComponent();
        }

        string MaTP;

        decimal[] tongHoaDon = new decimal[5];
        int soHoaDon = 0;

        public void TinhHoaDon(string TP)
        {
            MaTP = TP;
            List<ThanhToan> listTT = ThanhToanDAO.Instance.GetListThanhToanByMaTP(TP);

            string P = "";
            DateTime CheckIn = new DateTime();
            DateTime CheckOut = new DateTime();
            string GhiChu = "";

            foreach (ThanhToan item in listTT)
            {
                if (item.GhiChu == null)
                {
                    P = ThanhToanDAO.Instance.GetMaPhongByMaTP(TP);
                    CheckIn = ThanhToanDAO.Instance.GetCheckInByMaTP(TP);
                    CheckOut = ThanhToanDAO.Instance.GetCheckOutByMaTP(TP);
                    GhiChu = "";
                }
                else if (item.GhiChu != null)
                {
                    string[] split = item.GhiChu.Split(new Char[] { '|' });
                    P = split[0];
                    //---------------------------------------------------------------------CHECK IN
                    CheckIn = Convert.ToDateTime(split[1]);
                    //---------------------------------------------------------------------CHECK OUT
                    CheckOut = Convert.ToDateTime(split[2]);
                    //---------------------------------------------------------------------GHI CHÚ
                    GhiChu = split[3];

                }
                Panel panel = new Panel();
                flpMain.Controls.Add(panel);
                panel.BackColor = Color.Gray;
                panel.AutoScroll = true;
                panel.Size = new Size(508, 382);

                Label lblPhong = new Label();
                panel.Controls.Add(lblPhong);
                lblPhong.Location = new Point(43, 18);
                lblPhong.Size = new Size(40, 13);
                lblPhong.Text = "Phòng";

                TextBox txbPhong = new TextBox();
                panel.Controls.Add(txbPhong);
                txbPhong.Location = new Point(16, 34);
                txbPhong.Size = new Size(91, 20);
                //-----------------------------------------------------------------------------PHÒNG
                txbPhong.Text = P;
                txbPhong.ReadOnly = true;

                Label lblMucGia = new Label();
                panel.Controls.Add(lblMucGia);
                lblMucGia.Location = new Point(36, 63);
                lblMucGia.Size = new Size(50, 13);
                lblMucGia.Text = "Mức giá";

                decimal MG;

                TextBox txbMucGia = new TextBox();
                panel.Controls.Add(txbMucGia);
                txbMucGia.Location = new Point(16, 79);
                txbMucGia.Size = new Size(64, 20);
                txbMucGia.Text = ThanhToanDAO.Instance.GetMucGiaByMaTT(item.MaPhieuTT, item.PhuongThucTT);
                txbMucGia.ReadOnly = true;
                //--------------------------------------------------------------------------------MỨC GIÁ
                MG = Convert.ToDecimal(txbMucGia.Text);

                Label lblPhuongThuc = new Label();
                panel.Controls.Add(lblPhuongThuc);
                lblPhuongThuc.Location = new Point(86, 82);
                lblPhuongThuc.Size = new Size(37, 13);
                if (item.PhuongThucTT == "Ngày")
                {
                    lblPhuongThuc.Text = "/Ngày";
                }
                else if (item.PhuongThucTT == "Giờ")
                {
                    lblPhuongThuc.Text = "/Giờ";
                }

                Label lblCheckIn = new Label();
                panel.Controls.Add(lblCheckIn);
                lblCheckIn.Location = new Point(228, 18);
                lblCheckIn.Size = new Size(48, 13);
                lblCheckIn.Text = "check-in";

                DateTimePicker dtCheckIn = new DateTimePicker();
                panel.Controls.Add(dtCheckIn);
                dtCheckIn.CustomFormat = "dd/MM/yyyy HH:mm";
                dtCheckIn.Format = DateTimePickerFormat.Custom;
                dtCheckIn.Location = new Point(188, 34);
                dtCheckIn.Size = new Size(131, 20);
                dtCheckIn.Value = CheckIn;
                dtCheckIn.Enabled = false;

                Label lblCheckOut = new Label();
                panel.Controls.Add(lblCheckOut);
                lblCheckOut.Location = new Point(402, 18);
                lblCheckOut.Size = new Size(55, 13);
                lblCheckOut.Text = "check-out";

                DateTimePicker dtCheckOut = new DateTimePicker();
                panel.Controls.Add(dtCheckOut);
                dtCheckOut.CustomFormat = "dd/MM/yyyy HH:mm";
                dtCheckOut.Format = DateTimePickerFormat.Custom;
                dtCheckOut.Location = new Point(362, 34);
                dtCheckOut.Size = new Size(131, 20);
                dtCheckOut.Value = CheckOut;
                dtCheckOut.Enabled = false;

                Label lblStart = new Label();
                panel.Controls.Add(lblStart);
                lblStart.Location = new Point(216, 63);
                lblStart.Size = new Size(85, 13);
                lblStart.Text = "Ngày bắt đầu";

                DateTimePicker dtStart = new DateTimePicker();
                panel.Controls.Add(dtStart);
                dtStart.CustomFormat = "dd/MM/yyyy HH:mm";
                dtStart.Format = DateTimePickerFormat.Custom;
                dtStart.Location = new Point(188, 79);
                dtStart.Size = new Size(131, 20);
                //--------------------------------------------------------------------------NGÀY BẮT ĐẦU
                dtStart.Value = item.NgayBatDau;
                dtStart.Enabled = false;


                Label lblEnd = new Label();
                panel.Controls.Add(lblEnd);
                lblEnd.Location = new Point(385, 63);
                lblEnd.Size = new Size(85, 13);
                lblEnd.Text = "Ngày kết thúc";

                DateTime ss = new DateTime(1900, 10, 10);

                DateTimePicker dtEnd = new DateTimePicker();
                panel.Controls.Add(dtEnd);
                dtEnd.CustomFormat = "dd/MM/yyyy HH:mm";
                dtEnd.Format = DateTimePickerFormat.Custom;
                dtEnd.Location = new Point(362, 79);
                dtEnd.Size = new Size(131, 20);
                //----------------------------------------------------------------------------NGÀY KẾT THÚC
                if (item.NgayKetThuc == ss)
                {
                    dtEnd.Value = DateTime.Now;
                }
                else
                {
                    dtEnd.Value = item.NgayKetThuc;
                }
                DateTime End = dtEnd.Value;
                dtEnd.Enabled = false;

                int Nguoi = 0;
                decimal ThemNguoi = 0;
                if (ThanhToanDAO.Instance.GetChenhLechNguoiByMaTT(item.MaPhieuTT) > 0)
                {
                    Label lblNguoi = new Label();
                    panel.Controls.Add(lblNguoi);
                    lblNguoi.Location = new Point(156, 113);
                    lblNguoi.Size = new Size(71, 13);
                    lblNguoi.Text = "Số người vượt";

                    TextBox txbNguoi = new TextBox();
                    panel.Controls.Add(txbNguoi);
                    txbNguoi.Location = new Point(145, 130);
                    txbNguoi.Size = new Size(91, 20);
                    txbNguoi.Text = ThanhToanDAO.Instance.GetChenhLechNguoiByMaTT(item.MaPhieuTT).ToString();
                    //---------------------------------------------------------------------CHÊNH LỆCH NGƯỜI
                    Nguoi = Convert.ToInt32(txbNguoi.Text);

                    Label lblThemNguoi = new Label();
                    panel.Controls.Add(lblThemNguoi);
                    lblThemNguoi.Location = new Point(22, 113);
                    lblThemNguoi.Size = new Size(76, 13);
                    lblThemNguoi.Text = "Giá thêm người";

                    TextBox txbThemNguoi = new TextBox();
                    panel.Controls.Add(txbThemNguoi);
                    txbThemNguoi.Location = new Point(16, 130);
                    txbThemNguoi.Size = new Size(91, 20);
                    txbThemNguoi.Text = ThanhToanDAO.Instance.GetGiaThemNguoiByMaTT(item.MaPhieuTT).ToString();
                    //----------------------------------------------------------------------GIÁ THÊM NGƯỜI
                    ThemNguoi = ThanhToanDAO.Instance.GetGiaThemNguoiByMaTT(item.MaPhieuTT);
                }

                //----------------------------------------------------------------------------GHI CHÚ
                if (GhiChu != "")
                {
                    Label lblGhiChu = new Label();
                    panel.Controls.Add(lblGhiChu);
                    lblGhiChu.Location = new Point(345, 113);
                    lblGhiChu.Size = new Size(76, 13);
                    lblGhiChu.Text = "Ghi chú";

                    TextBox txbGhiChu = new TextBox();
                    panel.Controls.Add(txbGhiChu);
                    txbGhiChu.Location = new Point(247, 130);
                    txbGhiChu.Size = new Size(246, 20);
                    txbGhiChu.Text = GhiChu;
                    txbGhiChu.ReadOnly = true;
                }

                Label lblTongTien = new Label();
                panel.Controls.Add(lblTongTien);
                lblTongTien.Location = new Point(393, 315);
                lblTongTien.Size = new Size(48, 13);
                lblTongTien.Text = "Tổng tiền";

                TextBox txbTongTien = new TextBox();
                panel.Controls.Add(txbTongTien);
                txbTongTien.Location = new Point(372, 331);
                txbTongTien.Size = new Size(91, 20);
                txbTongTien.ReadOnly = true;
                //-----------------------------------------------------------------------------------TAG
                
                TagM tag = new TagM()
                {
                    tagTT = item.MaPhieuTT,
                    tagCheckIn = CheckIn,
                    tagCheckOut = CheckOut,
                    tagStart = item.NgayBatDau,
                    tagEnd = End,
                    tagMG = MG,
                    tagPT = item.PhuongThucTT,
                    tagNguoi = Nguoi,
                    tagThemNguoi = ThemNguoi
                };
                txbTongTien.Tag = tag;

                TextBox txbSTT = new TextBox();
                panel.Controls.Add(txbSTT);
                txbSTT.Location = new Point(464, 359);
                txbSTT.Size = new Size(20, 20);
                txbSTT.Text = soHoaDon.ToString();
                txbSTT.ReadOnly = true;
                //-----------------------------------------------------------------------------------TAG
                txbSTT.Tag = txbTongTien;

                ListView lvThanhToanPhu = new ListView();
                panel.Controls.Add(lvThanhToanPhu);
                lvThanhToanPhu.GridLines = true;
                lvThanhToanPhu.Location = new Point(16, 170);
                lvThanhToanPhu.Size = new Size(447, 125);
                lvThanhToanPhu.View = View.Details;
                //---------------------------------------------------------------------------TAG
                lvThanhToanPhu.Tag = txbSTT;

                lvThanhToanPhu.Columns.Add("Tiền phụ thu", 102, HorizontalAlignment.Center);
                lvThanhToanPhu.Columns.Add("Ghi chú", 340, HorizontalAlignment.Center);

                List<ThanhToanPhu> listTTP = ThanhToanDAO.Instance.GetListThanhToanPhuByMaTT(item.MaPhieuTT);

                lvThanhToanPhu.Items.Clear();
                foreach (ThanhToanPhu item1 in listTTP)
                {
                    ListViewItem lsv = new ListViewItem();
                    lsv.Text = item1.SoTien.ToString();
                    lsv.SubItems.Add(item1.GhiChu);
                    lvThanhToanPhu.Items.Add(lsv);
                }

                CheckBox chkPhuThu = new CheckBox();
                panel.Controls.Add(chkPhuThu);
                chkPhuThu.Location = new Point(258, 331);
                chkPhuThu.Size = new Size(84, 17);
                chkPhuThu.Text = "Tính phụ thu";
                //-----------------------------------------------------------------------------------TAG
                chkPhuThu.Tag = lvThanhToanPhu;

                chkPhuThu.Checked = true;
                chkPhuThu.CheckedChanged += ChkPhuThu_CheckedChanged;

                TinhToan(tag, chkPhuThu, lvThanhToanPhu,txbSTT, txbTongTien, soHoaDon);

                tongHoaDon[soHoaDon] = Convert.ToDecimal(txbTongTien.Text);
                soHoaDon++;

                UpdateTongHoaDon();
            }
            
        }

        public void TinhToan(TagM tag, CheckBox chk, ListView lvThanhToanPhu, TextBox txbSTT, TextBox txbTongTien, int soHoaDon)
        {
            string TT = tag.tagTT;
            DateTime CheckIn = tag.tagCheckIn;
            DateTime CheckOut = tag.tagCheckOut;
            DateTime Start = tag.tagStart;
            DateTime End = tag.tagEnd;
            decimal MG = tag.tagMG;
            string PT = tag.tagPT;
            decimal ThemNguoi = tag.tagThemNguoi;
            int Nguoi = tag.tagNguoi;

            decimal Tong = 0;
            TimeSpan span = new TimeSpan();

            if (Nguoi > 0)
            {
                MG = MG + Nguoi * ThemNguoi;
            }

            List<ThanhToanPhu> listTTP = ThanhToanDAO.Instance.GetListThanhToanPhuByMaTT(TT);
            foreach (ThanhToanPhu item in listTTP)
            {
                Tong = Tong + item.SoTien;
            }

            if (PT == "Ngày")
            {
                if (Start < CheckIn)
                {
                    CheckIn = new DateTime(Start.Year, Start.Month, Start.Day, 12, 0, 0);
                }
                if (End > CheckOut)
                {
                    CheckOut = new DateTime(End.Year, End.Month, End.Day, 12, 0, 0);
                }

                span = CheckOut - CheckIn;

                Tong = Tong + span.Days * MG;

                if (chk.Checked == true)
                {
                    DateTime CheckIn1M = new DateTime(Start.Year, Start.Month, Start.Day, 0, 0, 0);
                    DateTime CheckIn2M = new DateTime(Start.Year, Start.Month, Start.Day, 6, 0, 0);
                    DateTime CheckIn3M = new DateTime(Start.Year, Start.Month, Start.Day, 10, 0, 0);

                    DateTime CheckOut1S = new DateTime(End.Year, End.Month, End.Day, 0, 0, 0);
                    DateTime CheckOut2S = new DateTime(End.Year, End.Month, End.Day, 6, 0, 0);
                    DateTime CheckOut3S = new DateTime(End.Year, End.Month, End.Day, 10, 0, 0);

                    DateTime CheckOut1M = new DateTime(End.Year, End.Month, End.Day, 13, 0, 0);
                    DateTime CheckOut2M = new DateTime(End.Year, End.Month, End.Day, 15, 0, 0);
                    DateTime CheckOut3M = new DateTime(End.Year, End.Month, End.Day, 18, 0, 0);

                    if (CheckIn2M <= Start && Start <= CheckIn3M)
                    {
                        //ThanhToanDAO.Instance.UpdateThanhToanPhu(TT, MG * 30 / 100, "Check-in sớm");
                        ListViewItem lsv = new ListViewItem();
                        lsv.Text = (MG * 30 / 100).ToString();
                        lsv.SubItems.Add("Check-in sớm");

                        lvThanhToanPhu.Items.Add(lsv);
                        Tong = Tong + (MG * 30 / 100);
                    }
                    else if (CheckIn1M <= Start && Start < CheckIn2M)
                    {
                        //ThanhToanDAO.Instance.UpdateThanhToanPhu(TT, MG * 50 / 100, "Check-in sớm");
                        ListViewItem lsv = new ListViewItem();
                        lsv.Text = (MG * 50 / 100).ToString();
                        lsv.SubItems.Add("Check-in sớm");

                        lvThanhToanPhu.Items.Add(lsv);
                        Tong = Tong + (MG * 50 / 100);
                    }
                    else if (Start < CheckIn1M)
                    {
                        //ThanhToanDAO.Instance.UpdateThanhToanPhu(TT, MG, "Check-in sớm");
                        ListViewItem lsv = new ListViewItem();
                        lsv.Text = MG.ToString();
                        lsv.SubItems.Add("Check-in sớm");

                        lvThanhToanPhu.Items.Add(lsv);
                        Tong = Tong + MG;
                    }

                    if (CheckOut2S <= End && End <= CheckOut3S)
                    {
                        //ThanhToanDAO.Instance.UpdateThanhToanPhu(TT, -(MG * 30 / 100), "Check-out sớm");
                        ListViewItem lsv = new ListViewItem();
                        lsv.Text = string.Format("-" + (MG * 30 / 100).ToString());
                        lsv.SubItems.Add("Check-out sớm");

                        lvThanhToanPhu.Items.Add(lsv);
                        Tong = Tong - (MG * 30 / 100);
                    }
                    else if (CheckOut1S <= End && End < CheckOut2S)
                    {
                        //ThanhToanDAO.Instance.UpdateThanhToanPhu(TT, -(MG * 50 / 100), "Check-out sớm");
                        ListViewItem lsv = new ListViewItem();
                        lsv.Text = string.Format("-" + (MG * 50 / 100).ToString());
                        lsv.SubItems.Add("Check-out sớm");

                        lvThanhToanPhu.Items.Add(lsv);
                        Tong = Tong - (MG * 50 / 100);
                    }


                    if (CheckOut1M <= End && End <= CheckOut2M)
                    {
                        //ThanhToanDAO.Instance.UpdateThanhToanPhu(TT, MG * 30 / 100, "Check-out muộn");
                        ListViewItem lsv = new ListViewItem();
                        lsv.Text = string.Format((MG * 30 / 100).ToString());
                        lsv.SubItems.Add("Check-out muộn");

                        lvThanhToanPhu.Items.Add(lsv);
                        Tong = Tong + (MG * 30 / 100);
                    }
                    else if (CheckOut2M <= End && End < CheckOut3M)
                    {
                        //ThanhToanDAO.Instance.UpdateThanhToanPhu(TT, MG * 50 / 100, "Check-out muộn");
                        ListViewItem lsv = new ListViewItem();
                        lsv.Text = string.Format((MG * 50 / 100).ToString());
                        lsv.SubItems.Add("Check-out muộn");

                        lvThanhToanPhu.Items.Add(lsv);
                        Tong = Tong + (MG * 50 / 100);
                    }
                    else if (End > CheckOut3M)
                    {
                        //ThanhToanDAO.Instance.UpdateThanhToanPhu(TT, MG, "Check-out muộn");
                        ListViewItem lsv = new ListViewItem();
                        lsv.Text = MG.ToString();
                        lsv.SubItems.Add("Check-out muộn");

                        lvThanhToanPhu.Items.Add(lsv);
                        Tong = Tong + MG;
                    }

                }
                else if (chk.Checked == false)
                {
                    int i = 0;
                    foreach (ListViewItem item in lvThanhToanPhu.Items)
                    {
                        string ghiChu = item.SubItems[1].Text;
                        if (ghiChu == "Check-out muộn" || ghiChu == "Check-out sớm" || ghiChu == "Check-in sớm")
                        {
                            lvThanhToanPhu.Items[i].Remove();
                            //Tong = Tong - Convert.ToDecimal(item.Text);
                        }
                        else { i++; }
                    }
                }
            }

            else if (PT == "Giờ")
            {
                span = End - Start;
                Tong = Tong + (span.Days * 24 + span.Hours) * MG;
                if (span.Minutes >= 30)
                {
                    Tong = Tong + MG;
                }
            }

            txbTongTien.Text = Tong.ToString();

            tongHoaDon[Convert.ToInt32(txbSTT.Text)] = Tong;
            UpdateTongHoaDon();
        }
        private void ChkPhuThu_CheckedChanged(object sender, EventArgs e)
        {

            TagM tag = ((((sender as CheckBox).Tag as ListView).Tag as TextBox).Tag as TextBox).Tag as TagM;
            CheckBox chk = sender as CheckBox;
            ListView lvThanhToanPhu = (sender as CheckBox).Tag as ListView;
            TextBox txbSTT = ((sender as CheckBox).Tag as ListView).Tag as TextBox;
            TextBox txbTongTien = (((sender as CheckBox).Tag as ListView).Tag as TextBox).Tag as TextBox;

            TinhToan(tag, chk, lvThanhToanPhu,txbSTT, txbTongTien, Convert.ToInt32(txbSTT.Text));
            UpdateTongHoaDon();
        }

        public void UpdateTongHoaDon()
        {
            decimal TongHoaDon = 0;
            int i;
            for(i = 0; i < soHoaDon; i++)
            {
                TongHoaDon = TongHoaDon + tongHoaDon[i];
            }
            txbTongHoaDon.Text = TongHoaDon.ToString();

        }

        #region ?????????????????????????????????????????????????????????????????????
        public decimal TongTienTT(string TT, DateTime CheckIn, DateTime CheckOut, DateTime Start, DateTime End, decimal MG, string PT, decimal ThemNguoi, int Nguoi, bool chk)
        {
            decimal Tong = 0;
            TimeSpan span = new TimeSpan();

            if (Nguoi > 0)
            {
                Tong = Tong + Nguoi * ThemNguoi;
            }

            if (PT == "Ngày")
            {
                if (Start < CheckIn)
                {
                    CheckIn = new DateTime(Start.Year, Start.Month, Start.Day, 12, 0, 0);
                }
                if (End > CheckOut)
                {
                    CheckOut = new DateTime(End.Year, End.Month, End.Day, 12, 0, 0);
                }

                span = CheckOut - CheckIn;

                Tong = Tong + span.Days * MG;

                if (chk == true)
                {
                    DateTime CheckIn1M = new DateTime(Start.Year, Start.Month, Start.Day, 0, 0, 0);
                    DateTime CheckIn2M = new DateTime(Start.Year, Start.Month, Start.Day, 6, 0, 0);
                    DateTime CheckIn3M = new DateTime(Start.Year, Start.Month, Start.Day, 10, 0, 0);

                    DateTime CheckOut1S = new DateTime(End.Year, End.Month, End.Day, 0, 0, 0);
                    DateTime CheckOut2S = new DateTime(End.Year, End.Month, End.Day, 6, 0, 0);
                    DateTime CheckOut3S = new DateTime(End.Year, End.Month, End.Day, 10, 0, 0);

                    DateTime CheckOut1M = new DateTime(End.Year, End.Month, End.Day, 13, 0, 0);
                    DateTime CheckOut2M = new DateTime(End.Year, End.Month, End.Day, 15, 0, 0);
                    DateTime CheckOut3M = new DateTime(End.Year, End.Month, End.Day, 18, 0, 0);

                    if (CheckIn2M <= Start && Start <= CheckIn3M)
                    {
                        ThanhToanDAO.Instance.UpdateThanhToanPhu(TT, MG * 30 / 100, "Check-in sớm");
                    }
                    else if (CheckIn1M <= Start && Start < CheckIn2M)
                    {
                        ThanhToanDAO.Instance.UpdateThanhToanPhu(TT, MG * 50 / 100, "Check-in sớm");
                    }
                    else if (Start < CheckIn1M)
                    {
                        ThanhToanDAO.Instance.UpdateThanhToanPhu(TT, MG, "Check-in sớm");
                    }

                    if (CheckOut2S <= End && End <= CheckOut3S)
                    {
                        ThanhToanDAO.Instance.UpdateThanhToanPhu(TT, -(MG * 30 / 100), "Check-out sớm");
                    }
                    else if (CheckOut1S <= End && End < CheckOut2S)
                    {
                        ThanhToanDAO.Instance.UpdateThanhToanPhu(TT, -(MG * 50 / 100), "Check-out sớm");
                    }


                    if (CheckOut1M <= End && End <= CheckOut2M)
                    {
                        ThanhToanDAO.Instance.UpdateThanhToanPhu(TT, MG * 30 / 100, "Check-out muộn");
                    }
                    else if (CheckOut2M <= End && End < CheckOut3M)
                    {
                        ThanhToanDAO.Instance.UpdateThanhToanPhu(TT, MG * 50 / 100, "Check-out muộn");
                    }
                    else if (End > CheckOut3M)
                    {
                        ThanhToanDAO.Instance.UpdateThanhToanPhu(TT, MG, "Check-out muộn");
                    }

                }
            }

            else if (PT == "Giờ")
            {
                span = End - Start;
                Tong = Tong + (span.Days * 24 + span.Hours) * MG;
                if (span.Minutes >= 30)
                {
                    Tong = Tong + MG;
                }
            }
            #endregion

            List<ThanhToanPhu> listTTP = ThanhToanDAO.Instance.GetListThanhToanPhuByMaTT(TT);
            foreach (ThanhToanPhu item in listTTP)
            {
                Tong = Tong + item.SoTien;
            }

            return Tong;
        }

        public class TagM
        {
            public string tagTT { get; set; }
            public DateTime tagCheckIn { get; set; }
            public DateTime tagCheckOut { get; set; }
            public DateTime tagStart { get; set; }
            public DateTime tagEnd { get; set; }
            public decimal tagMG { get; set; }
            public string tagPT { get; set; }
            public decimal tagThemNguoi { get; set; }
            public int tagNguoi { get; set; }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToanDAO.Instance.XoaThanhToanByMaTP(MaTP);

            string P = ThanhToanDAO.Instance.GetMaPhongByMaTP(MaTP);
            ThuePhongDAO.Instance.UpdateTrangThaiPhong(P);
        }
    }
}
//--------------------SỬ DỤNG SPLIT VÀ TRIM()---------------------
//----------VD SỬ DỤNG SPLIT TÁCH DẤU CÁCH KHỎI CHUỖI-----
//public static void Main()
//{
//    string chuoi_dau = "nothing gonna    change my love   for C#";
//    string[] chuoi_tach = chuoi_dau.Split(new Char[] { ' ' });
//    string chuoi_ketqua = "";

//    int i = 0;
//    foreach (string s in chuoi_tach)
//    {
//        //Console.WriteLine("--" + s.Trim() + "--");
//        if (chuoi_tach[i] != "")
//            chuoi_ketqua += s;
//        i++;
//    }
//    Console.WriteLine("---->>" + chuoi_ketqua);
//}

//---------------------------------TẠO CONTROL = CODE, GỌI CHỈNH SỬA TEXTBOX QUA BUTTON CLICK------
//public UC_CachTinhChiPhi()
//{
//    InitializeComponent();

//    for (int i = 0; i < 3; i++)
//    {
//        Panel pnl = new Panel();
//        pnl.Size = new Size(219, 100);

//        TextBox txb = new TextBox();
//        pnl.Controls.Add(txb);
//        txb.Location = new Point(113, 32);
//        txb.Size = new Size(100, 20);


//        Button btn = new Button();
//        pnl.Controls.Add(btn);
//        btn.Location = new Point(13, 30);
//        btn.Size = new Size(75, 23);
//        btn.Text = "buttonnn";
//        btn.Tag = txb;
//        btn.Click += Btn_Click;

//        FlowLayoutPanel.Controls.Add(pnl);
//    }
//}

//private void Btn_Click(object sender, EventArgs e)
//{
//    ((sender as Button).Tag as TextBox).Text = "hahahaaa";
//}