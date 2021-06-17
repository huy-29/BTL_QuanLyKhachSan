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
    public partial class UC_SoDoPhong : UserControl
    {
        public UC_SoDoPhong()
        {
            InitializeComponent();

            LoadComboBoxTang();
            LoadComboBoxLoaiPhong();
            LoadSoDoPhong();
        }

        void LoadSoDoPhong()
        {
            List<Phong> list = PhongDAO.Instance.GetListPhong();

            LoadSoDoPhongTheoList(list);
        }

        void LoadSoDoPhongTheoList(List<Phong> list)
        {
            flpPhong.Controls.Clear();

            int i = 3;

            foreach(Phong item in list)
            {
                string soTang = "";
                //string tenTang = "";
                //string loaiPhong = "";
                string soNguoi = "";
                foreach(Tang itemT in TangDAO.Instance.GetListTang())
                {
                    if(item.MaTang == itemT.MaTang)
                    {
                        soTang = itemT.MaTang;
                        //tenTang = itemT.TenTang;
                    }
                }
                foreach (LoaiPhong itemLP in LoaiPhongDAO.Instance.GetListLoaiPhong())
                {
                    if (item.MaLoaiPhong == itemLP.MaLoaiPhong)
                    {
                        //loaiPhong = itemLP.TenLoaiPhong;
                        soNguoi = itemLP.SoNguoi.ToString();
                    }
                }
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Click += btn_Click;
                btn.Tag = item;

                string name = string.Format(item.MaPhong + "\n" + item.TrangThai + "\nTầng: " + soTang + "\nSố người: " + soNguoi);
                btn.Text = name;

                btn.TabIndex = i;
                i++;

                //btn.ForeColor = Color.White;
                ContextMenuStrip cms = new ContextMenuStrip();
                cms.AutoSize = true;

                if (item.TrangThai == "Trống")
                {
                    btn.BackColor = Color.LightGreen;
                    var itemTool1 = new ToolStripButton("Nhận phòng", null, new EventHandler(NhanPhong_click));
                    itemTool1.Tag = item;
                    var itemTool2 = new ToolStripButton("Đặt phòng", null, new EventHandler(DatPhong_click));
                    itemTool2.Tag = item;
                    var itemTool3 = new ToolStripButton("Đặt về bảo trì", null, new EventHandler(BaoTri_click));
                    itemTool3.Tag = item;

                    cms.Items.Add(itemTool1);
                    cms.Items.Add(itemTool2);
                    cms.Items.Add(itemTool3);
                    //cms.Items.Add("Nhận phòng", null,new EventHandler(NhanPhong_click));                   
                    //cms.Items.Add("Đặt phòng", null, new EventHandler(DatPhong_click));
                    //cms.Items.Add("Đặt về bảo trì", null, new EventHandler(BaoTri_click));
                    // cms.Tag = item;

                }
                else if(item.TrangThai == "Đang thuê")
                {
                    btn.BackColor = Color.Red;

                    var itemTool1 = new ToolStripButton("Trả phòng", null, new EventHandler(TraPhong_click));
                    itemTool1.Tag = item;
                    var itemTool2 = new ToolStripButton("Chuyển phòng", null, new EventHandler(ChuyenPhong_click));
                    itemTool2.Tag = item;
                    var itemTool3 = new ToolStripButton("Đặt phòng", null, new EventHandler(DatPhong_click));
                    itemTool3.Tag = item;
                    //var itemTool4 = new ToolStripButton("Sửa thông tin", null, new EventHandler(SuaThongTin_click));
                    //itemTool4.Tag = item;

                    cms.Items.Add(itemTool1);
                    cms.Items.Add(itemTool2);
                    cms.Items.Add(itemTool3);
                    //cms.Items.Add(itemTool4);
                }
                else if (item.TrangThai == "Đặt trước")
                {
                    btn.BackColor = Color.LightPink;

                    var itemTool1 = new ToolStripButton("Đặt phòng", null, new EventHandler(DatPhong_click));
                    itemTool1.Tag = item;
                    //var itemTool2 = new ToolStripButton("Trả phòng", null, new EventHandler(TraPhong_click));
                    //itemTool2.Tag = item;  
                    //var itemTool3 = new ToolStripButton("Sửa thông tin", null, new EventHandler(SuaThongTin_click));
                    //itemTool3.Tag = item;
                    var itemTool4 = new ToolStripButton("Đặt về bảo trì", null, new EventHandler(BaoTri_click));
                    itemTool4.Tag = item;

                    cms.Items.Add(itemTool1);
                    //cms.Items.Add(itemTool2);
                    //cms.Items.Add(itemTool3);
                    cms.Items.Add(itemTool4);
                }
                else if (item.TrangThai == "Bảo trì")
                {
                    btn.BackColor = Color.Orange;

                    var itemTool2 = new ToolStripButton("Đặt phòng", null, new EventHandler(DatPhong_click));
                    itemTool2.Tag = item;
                    var itemTool3 = new ToolStripButton("Đặt về sẵn sàng", null, new EventHandler(SanSang_click));
                    itemTool3.Tag = item;

                    cms.Items.Add(itemTool2);
                    cms.Items.Add(itemTool3);
                }
                //cms.Show(btn, new Point(50, 50));
                btn.ContextMenuStrip = cms;

                flpPhong.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var PhongInfo = ((sender as Button).Tag as Phong).MaLoaiPhong;
        }


        public delegate void delThuePhong(string P, string TP, string KH, string task);
        private void NhanPhong_click(object sender, EventArgs e)
        {
            // MessageBox.Show("Nhận phòng" + ((sender as ToolStripButton).Tag as Phong).MaPhong);
            var PhongInfo = ((sender as ToolStripButton).Tag as Phong);

            string P = PhongInfo.MaPhong;
            string TP = SoDoPhongDAO.Instance.GetMaThuePhong();
            string KH = SoDoPhongDAO.Instance.GetMaKH();
            
            UpdateNhanPhong f = new UpdateNhanPhong();
            delThuePhong del = new delThuePhong(f.NhanPhong);
            del(P,TP,KH,"Thêm");
            f.ShowDialog();

            LoadSoDoPhongTheoComboBox();
        }
        private void DatPhong_click(object sender, EventArgs e)
        {
            //MessageBox.Show("Đặt phòng" + ((sender as ToolStripButton).Tag as Phong).MaPhong);
            var PhongInfo = ((sender as ToolStripButton).Tag as Phong);
            string P = PhongInfo.MaPhong;
            string TP = SoDoPhongDAO.Instance.GetMaThuePhong();
            string KH = SoDoPhongDAO.Instance.GetMaKH();

            UpdateNhanPhong f = new UpdateNhanPhong();
            delThuePhong del = new delThuePhong(f.NhanPhong);
            del(P, TP, KH, "Đặt mới");

            f.ShowDialog();
            LoadSoDoPhongTheoComboBox();
        }
        private void BaoTri_click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bảo trì" + ((sender as ToolStripButton).Tag as Phong).MaPhong);
            string P = ((sender as ToolStripButton).Tag as Phong).MaPhong;
            SoDoPhongDAO.Instance.DoiTrangThaiPhong(P, "Bảo trì");
            LoadSoDoPhongTheoComboBox();
        }
        private void SanSang_click(object sender, EventArgs e)
        {
            string P = ((sender as ToolStripButton).Tag as Phong).MaPhong;

            ThuePhongDAO.Instance.UpdateTrangThaiPhong(P);
            //int i = 0;
            //foreach(ThuePhong item in SoDoPhongDAO.Instance.GetListThuePhong())
            //{
            //    if(item.MaPhong == P && item.TienDat != 0) { i = 1; }
            //    else if (item.MaPhong == P && item.TienDat == 0) { i = 2; }
            //}
            //if (i == 0)
            //{
            //    SoDoPhongDAO.Instance.DoiTrangThaiPhong(P, "Trống");
            //}
            //else if (i == 1)
            //{
            //    SoDoPhongDAO.Instance.DoiTrangThaiPhong(P, "Đặt trước");
            //}
            //else if (i == 2)
            //{
            //    SoDoPhongDAO.Instance.DoiTrangThaiPhong(P, "Đang thuê");
            //}
            LoadSoDoPhongTheoComboBox();
        }

        public delegate void delTraPhong(string TP);
        private void TraPhong_click(object sender, EventArgs e)
        {
            string P = ((sender as ToolStripButton).Tag as Phong).MaPhong;
            string TP = SoDoPhongDAO.Instance.GetMaThuePhongHienTaiByMaPhong(P);

            UpdateHoaDon f = new UpdateHoaDon();
            delTraPhong del = new delTraPhong(f.TinhHoaDon);
            del(TP);
            f.ShowDialog();
            LoadSoDoPhongTheoComboBox();
        }

        public delegate void delChuyenPhong(string P, string newP);
        private void ChuyenPhong_click(object sender, EventArgs e)
        {
            string P = ((sender as ToolStripButton).Tag as Phong).MaPhong;
            DateTime CheckOut = SoDoPhongDAO.Instance.GetCheckOutByMaPhongDangThue(P);

            if (CheckOut > DateTime.Now)
            {
                UpdateChuyenPhong f = new UpdateChuyenPhong();
                delChuyenPhong del = new delChuyenPhong(f.ChuyenPhong);
                del(P, "");
                f.ShowDialog();
                LoadSoDoPhongTheoComboBox();
            }
            else if (CheckOut <= DateTime.Now)
            {
                MessageBox.Show("Phòng đã quá hạn check-out. Vui lòng thanh toán");
            }
        }

        private void SuaThongTin_click(object sender, EventArgs e)
        {
            string P = ((sender as ToolStripButton).Tag as Phong).MaPhong;
            string TP = SoDoPhongDAO.Instance.GetMaThuePhongHienTaiByMaPhong(P);
            string KH = DatPhongDAO.Instance.GetMaKhachHangByMaTP(TP);

            UpdateNhanPhong f = new UpdateNhanPhong();
            delThuePhong del = new delThuePhong(f.NhanPhong);
            del(P, TP, KH, "Sửa thuê phòng");
            f.ShowDialog();
            LoadSoDoPhongTheoComboBox();

        }


        void LoadComboBoxTang()
        {
            List<Tang> list = new List<Tang>();

            list.Add(new Tang("Tất cả", ""));
            foreach (Tang item in TangDAO.Instance.GetListTang())
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
            foreach (LoaiPhong item in LoaiPhongDAO.Instance.GetListLoaiPhong())
            {
                list.Add(item);
            }
            cbLoaiPhong.DataSource = list;
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
        }

        void LoadSoDoPhongTheoComboBox()
        {
            string T = cbTang.Text;
            string LP = cbLoaiPhong.Text;
            string St = cbTrangThai.Text;

            if (T == "Tất cả") { T = ""; }
            if (LP == "Tất cả") { LP = ""; }
            if(St == "Tất cả") { St = ""; }

            List<Phong> list = SoDoPhongDAO.Instance.TimPhongChoSoDoPhong(T, LP, St);

            flpPhong.Controls.Clear();
            LoadSoDoPhongTheoList(list);
            
        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSoDoPhongTheoComboBox();
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSoDoPhongTheoComboBox();
        }

        private void cbTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSoDoPhongTheoComboBox();
        }
    }
}


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


//-----------------------------------CONTEXT_MENU_STRIP----------------------------------------
//public FormManuContext()
//{
//    InitializeComponent();
//    this.Load += new EventHandler(FormManuContext_Load);
//}

//void FormManuContext_Load(object sender, EventArgs e)
//{
//    ContextMenuStrip cms = new ContextMenuStrip();
//    // Bạn nhớ thay đường dẫn Image ở context menu 1 & 2 bằng đường dẫn image ở máy bạn nhé
//    // Context menu 1
//    cms.Items.Add("Góc Kinh Nghiệm", Image.FromFile(@"D:ImagesAvatarsPhanThiet-2.jpg"), new EventHandler(Gockinhnghiem_click));
//    // Context menu 2
//    cms.Items.Add("Chrome", Image.FromFile(@"D:ImagesAvatars130.jpg"), new EventHandler(Chrome_click));

//    this.ContextMenuStrip = cms;

//}

//// Hàm này sẽ được thực thi khi bạn nhấn vào "Góc kinh nghiệm"
//void Gockinhnghiem_click(object sender, EventArgs e)
//{
//    MessageBox.Show("Bạn vừa nhấn vào "Góc Kinh Nghiệm"!");
//}

//// Hàm này sẽ được thực thi khi bạn nhấn vào "Chrome"
//void Chrome_click(object sender, EventArgs e)
//{
//    MessageBox.Show("Bạn vừa nhấn vào "Chrome"!");
//}


