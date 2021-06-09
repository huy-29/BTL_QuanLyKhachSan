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

namespace BTL_QuanLyKhachSan.UserControls.QuanLyPhong
{
    public partial class UpdateChuyenPhong : Form
    {
        public UpdateChuyenPhong()
        {
            InitializeComponent();

            pnlGiaTrongKhoangNgayCu.Visible = false;

            lblCheck_PhongMoi.Visible = false;
            lblCheck_MucGiaMoi.Visible = false;
            lblCheck_PhuongThucMoi.Visible = false;
            lblCheck_SoNguoiMoi.Visible = false;
            pnlGiaTrongKhoangNgayMoi.Visible = false;

            chkPhongTrong.Checked = true;
            LoadComboBoxPhong();
        }

        public void ChuyenPhong(string P, string newP)
        {
            cbPhongCu.Text = P;

            cbPhongCu.SelectedIndex = -1;
            FillInfo(P);
            pnlGiaTrongKhoangNgayCu.Enabled = false;
            pnlThongTinPhongCu.Enabled = false;

            cbPhongMoi.SelectedIndex = -1;
            if (newP != "")
            {
                cbPhongMoi.Text = newP;
            }
        }

        void FillInfo(string P)
        {
            string TP = ThuePhongDAO.Instance.GetMaThuePhongByMaPhong(P);

            List<ThanhToan> listTT = SoDoPhongDAO.Instance.GetListThanhToanHienTaiByMaThuePhong(TP);
            string PhuongThuc = "";
            foreach (ThanhToan item in listTT)
            {     
                foreach (MucGia item1 in SoDoPhongDAO.Instance.GetListMucGiaByMaMucGia(item.MaMucGia))
                {
                    if (item1.MaMucGia == item.MaMucGia)
                    {
                        cbMucGiaCu.Text = item1.TenMucGia;
                        txbGiaThemNguoiCu.Text = item1.DonGiaThemNguoi.ToString() + "/ Người";

                        if (item.PhuongThucTT == "Giờ")
                        {
                            PhuongThuc = string.Format(item1.DonGiaGio.ToString() + "/ " + "Giờ");
                        }
                        else if (item.PhuongThucTT == "Ngày")
                        {
                            PhuongThuc = string.Format(item1.DonGiaNgay.ToString() + "/ " + "Ngày");
                        }
                        break;
                    }
                }
                cbPhuongThucCu.Text = PhuongThuc;

                DateTime check = new DateTime(1900, 10, 10);
                if(item.NgayBatDau != check && item.NgayKetThuc != check)
                {
                    pnlGiaTrongKhoangNgayCu.Visible = true;
                    dtNgayBatDauCu.Value = item.NgayBatDau;
                    dtNgayKetThucCu.Value = item.NgayKetThuc;
                }
                txbSoNguoiMoi.Text = item.SoNguoi.ToString();
            }
        }

        void LoadComboBoxPhong()
        {
            List<Phong> list = new List<Phong>();
            
            if(chkPhongTrong.Checked == true)
            {
                list = ThuePhongDAO.Instance.GetListPhongTrong();
                cbPhongMoi.DataSource = list;
                cbPhongMoi.DisplayMember = "MaPhong";
            }
            else if((chkPhongTrong.Checked == false))
            {
                list = ThuePhongDAO.Instance.GetListPhong();
                cbPhongMoi.DataSource = list;
                cbPhongMoi.DisplayMember = "MaPhong";
            }
        }

        private void cbPhongMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPhuongThucMoi.Items.Clear();
            pnlGiaTrongKhoangNgayMoi.Visible = false;

            List<MucGia> listMG = SoDoPhongDAO.Instance.GetListMucGiaByMaPhong(cbPhongMoi.Text);

            cbMucGiaMoi.DataSource = listMG;
            cbMucGiaMoi.DisplayMember = "TenMucGia";
        }

        private void cbMucGiaMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<MucGia> listMG = SoDoPhongDAO.Instance.GetListMucGiaByTenMucGia(cbMucGiaMoi.Text);
            DateTime dtSoSanh = new DateTime(1900, 10, 10);

            foreach (MucGia item in listMG)
            {
                txbGiaThemNguoiMoi.Text = string.Format(item.DonGiaThemNguoi.ToString() + "/ người");
                cbPhuongThucMoi.Items.Clear();
                cbPhuongThucMoi.Items.Add(item.DonGiaNgay.ToString() + "/ Ngày");
                cbPhuongThucMoi.Items.Add(item.DonGiaGio.ToString() + "/ Giờ");

                if (item.NgayBatDau == dtSoSanh)
                {
                    pnlGiaTrongKhoangNgayMoi.Visible = false;
                }
                else if (item.NgayBatDau != dtSoSanh)
                {
                    pnlGiaTrongKhoangNgayMoi.Visible = true;
                    dtNgayBatDauMoi.Value = item.NgayBatDau;
                    dtNgayKetThucMoi.Value = item.NgayKetThuc;
                }
            }
        }

        int Check()
        {
            int a = 0;

            if(cbPhongCu.Text == cbPhongMoi.Text)
            {
                return 1;
            }

            a = 3;
            foreach(Phong item in ThuePhongDAO.Instance.GetListPhong())
            {
                if (cbPhongMoi.Text == item.MaPhong)
                {
                    a = 0;   
                    if(item.TrangThai != "Trống")
                    {
                        return 2;
                    }
                }
            }
            if (a == 3) { return 3; }

            a = 4;
            foreach (MucGia item in cbMucGiaMoi.Items)
            {
                if (cbMucGiaMoi.Text == item.TenMucGia)
                {
                    a = 0;
                    break;
                }
            }
            if (a == 4) { return 4; }

            if (cbPhuongThucMoi.Text == "")
            {
                return 5;
            }

            if(cbPhuongThucCu.Text.Substring(cbPhuongThucCu.Text.Length - 4, 4) != cbPhuongThucMoi.Text.Substring(cbPhuongThucMoi.Text.Length - 4, 4))
            {
                return 6;
            }

            if(txbSoNguoiMoi.Text == "") { return 7; }

            if(Regex.IsMatch(txbSoNguoiMoi.Text, @"^[0-9]*$") == false) { return 8; }

            return a;
        }

        public void CheckPhongMoi()
        {
            int check = Check();
            if(check == 0)
            {
                UpdateTP();
                ThuePhongDAO.Instance.UpdateTrangThaiPhong(cbPhongCu.Text);
                ThuePhongDAO.Instance.UpdateTrangThaiPhong(cbPhongMoi.Text);
                this.Close();
            }
            else if(check == 1)
            {
                lblCheck_PhongMoi.Visible = true;
                lblCheck_PhongMoi.Text = "Phòng mới trùng với phòng cũ";
            }
            else if (check == 2)
            {
                lblCheck_PhongMoi.Visible = true;
                lblCheck_PhongMoi.Text = "Phòng chưa sẵn sàng";
            }
            else if (check == 3)
            {
                lblCheck_PhongMoi.Visible = true;
                lblCheck_PhongMoi.Text = "Phòng không hợp lệ";
            }
            else if (check == 4)
            {
                lblCheck_MucGiaMoi.Visible = true;
                lblCheck_MucGiaMoi.Text = "Tên mức giá không hợp lệ";
            }
            else if (check == 5)
            {
                lblCheck_PhuongThucMoi.Visible = true;
                lblCheck_PhuongThucMoi.Text = "Chọn 1 phương thức thanh toán";
            }
            else if (check == 6)
            {
                lblCheck_PhuongThucMoi.Visible = true;
                lblCheck_PhuongThucMoi.Text = "Phải chọn cùng phương thức với phòng cũ";
            }
            else if (check == 7)
            {
                lblCheck_SoNguoiMoi.Visible = true;
                lblCheck_SoNguoiMoi.Text = "Điền số người";
            }
            else if (check == 7)
            {
                lblCheck_SoNguoiMoi.Visible = true;
                lblCheck_SoNguoiMoi.Text = "Chỉ điền số";
            }

        }
        //EXEC dbo.UpdateChuyenPhong @TP = '', @Pcu = '502', @Pmoi = '702', @Nguoi = 0, @Start = '10101 0:0', 
        //    @Now = '20210529 23:0', @End = '10101 0:0', @tenMG = N'phòng đồ', @PT = N'Ngày', 
        //    @GhiChu = N'502|10101 0:0|20210529 23:0||Chuyển phòng'
        void UpdateTP()
        {
            string MaTP = "";
            //string MGcu = "";
            string Pcu = cbPhongCu.Text;
            string Pmoi = cbPhongMoi.Text;
            int Nguoi = Convert.ToInt32(txbSoNguoiMoi.Text);

            DateTime d1 = new DateTime();
            DateTime d2 = new DateTime();
            DateTime now = DateTime.Now;

            List<ThuePhong> listTP = DatPhongDAO.Instance.GetListThuePhongByMaPhong(cbPhongCu.Text);
            foreach(ThuePhong item in listTP)
            {
                MaTP = item.MaThuePhong;
                
                d1 = item.CheckIn;
                d2 = item.CheckOut;
            }

            //string[] split = cbPhuongThucCu.Text.Split(new Char[] { '/' });
            //MGcu = split[0];

            if(cbPhuongThucMoi.Text.Contains("Ngày") == true)
            {
                now = new DateTime(now.Year, now.Month, now.Day, 12, 0, 0);
            }
            
            string Start = d1.ToString();
            string End = d2.ToString();
            string Now = now.ToString();

            //if (d1.Month < 10)
            //{
            //    if (d1.Day < 10)
            //    {
            //        Start = string.Format(d1.Year.ToString() + "0" + d1.Month.ToString() + "0" + d1.Day.ToString() + " " + d1.Hour.ToString() + ":" + d1.Minute.ToString());
            //    }
            //    else if (d1.Day >= 10)
            //    {
            //        Start = string.Format(d1.Year.ToString() + "0" + d1.Month.ToString() + d1.Day.ToString() + " " + d1.Hour.ToString() + ":" + d1.Minute.ToString());
            //    }
            //}
            //else if (d1.Month >= 10)
            //{
            //    if (d1.Day < 10)
            //    {
            //        Start = string.Format(d1.Year.ToString() + d1.Month.ToString() + "0" + d1.Day.ToString() + " " + d1.Hour.ToString() + ":" + d1.Minute.ToString());
            //    }
            //    else if (d1.Day >= 10)
            //    {
            //        Start = string.Format(d1.Year.ToString() + d1.Month.ToString() + d1.Day.ToString() + " " + d1.Hour.ToString() + ":" + d1.Minute.ToString());
            //    }
            //}

            //if (d2.Month < 10)
            //{
            //    if (d2.Day < 10)
            //    {
            //        End = string.Format(d2.Year.ToString() + "0" + d2.Month.ToString() + "0" + d2.Day.ToString() + " " + d2.Hour.ToString() + ":" + d2.Minute.ToString());
            //    }
            //    else if (d1.Day >= 10)
            //    {
            //        End = string.Format(d2.Year.ToString() + "0" + d2.Month.ToString() + d2.Day.ToString() + " " + d2.Hour.ToString() + ":" + d2.Minute.ToString());
            //    }
            //}
            //else if (d2.Month >= 10)
            //{
            //    if (d2.Day < 10)
            //    {
            //        End = string.Format(d2.Year.ToString() + d2.Month.ToString() + "0" + d2.Day.ToString() + " " + d2.Hour.ToString() + ":" + d2.Minute.ToString());
            //    }
            //    else if (d2.Day >= 10)
            //    {
            //        End = string.Format(d2.Year.ToString() + d2.Month.ToString() + d2.Day.ToString() + " " + d2.Hour.ToString() + ":" + d2.Minute.ToString());
            //    }
            //}

            //if (now.Month < 10)
            //{
            //    if (now.Day < 10)
            //    {
            //        Now = string.Format(now.Year.ToString() + "0" + now.Month.ToString() + "0" + now.Day.ToString() + " " + now.Hour.ToString() + ":" + now.Minute.ToString());
            //    }
            //    else if (now.Day >= 10)
            //    {
            //        Now = string.Format(now.Year.ToString() + "0" + now.Month.ToString() + now.Day.ToString() + " " + now.Hour.ToString() + ":" + now.Minute.ToString());
            //    }
            //}
            //else if (now.Month >= 10)
            //{
            //    if (now.Day < 10)
            //    {
            //        Now = string.Format(now.Year.ToString() + now.Month.ToString() + "0" + now.Day.ToString() + " " + now.Hour.ToString() + ":" + now.Minute.ToString());
            //    }
            //    else if (now.Day >= 10)
            //    {
            //        Now = string.Format(now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + " " + now.Hour.ToString() + ":" + now.Minute.ToString());
            //    }
            //}

            //decimal TienDat = 0;            

            string TenMG = cbMucGiaMoi.Text;
            string PhuongThuc = "";

            if (cbPhuongThucMoi.Text.Contains("Ngày") == true)
            {
                PhuongThuc = "Ngày";
            }
            else if (cbPhuongThucMoi.Text.Contains("Giờ"))
            {
                PhuongThuc = "Giờ";
            }

            string GhiChu = string.Format(cbPhongCu.Text + "|" + Start + "|" + Now  + "|" + "Chuyển phòng");

            ThuePhongDAO.Instance.ChuyenPhong(MaTP, Pcu, Pmoi, Nguoi, Start, Now, End, TenMG, PhuongThuc, GhiChu);
        }

        //public void TinhHoaDonCu(string TP, DateTime d1, DateTime now)
        //{
        //    string[] split = cbPhuongThucCu.Text.Split(new char[] { '/' });

        //    decimal MG = Convert.ToDecimal(split[0]);
        //    string PT = split[1];

        //    int Nguoi = 0 ;
        //    int ThemNguoi = ThuePhongDAO.Instance.GetChenhLechNguoiByMaTP(TP);

        //    DateTime Start = new DateTime();
        //    DateTime End = new DateTime();
        //    TimeSpan span = now - d1 ;

        //    foreach(ThanhToan item in ThuePhongDAO.Instance.GetListThanhToanHienTaiByMaThuePhong(TP))
        //    {
        //        Start = item.NgayBatDau;
        //        End = item.NgayKetThuc;
        //        Nguoi = item.SoNguoi;
        //    }           

        //    if(PT == " Ngày")
        //    {

        //    }
        //}

        //public delegate void delTinhHoaDon(string TP);

        //UpdateHoaDon f = new UpdateHoaDon();
        //delTinhHoaDon del = new delTinhHoaDon(f.TinhHoaDon);
        //del(ThuePhongDAO.Instance.GetMaThuePhongByMaPhong(cbPhongCu.Text));
        //f.ShowDialog();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            lblCheck_PhongMoi.Visible = false;
            lblCheck_MucGiaMoi.Visible = false;
            lblCheck_PhuongThucMoi.Visible = false;
            lblCheck_SoNguoiMoi.Visible = false;
            pnlGiaTrongKhoangNgayMoi.Visible = false;

            CheckPhongMoi();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkPhongTrong_CheckedChanged(object sender, EventArgs e)
        {
            LoadComboBoxPhong();
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