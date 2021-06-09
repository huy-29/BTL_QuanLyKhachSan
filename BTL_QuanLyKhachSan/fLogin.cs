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

namespace BTL_QuanLyKhachSan
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txbTaiKhoan.Text;
            string password = txbMatKhau.Text;
            if (Login(username, password))
            {
                DangNhap dangNhap = DangNhapDAO.Instance.GetTaiKhoanByUsername(username);
                frMain f = new frMain(dangNhap);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        bool Login(string username, string password)
        {
            if(DangNhapDAO.Instance.Login(username, password))
            {
                return true;
            }
            return false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
