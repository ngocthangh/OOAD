using QuanLySieuThi.Common;
using QuanLySieuThi.DataBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi.Presentation
{
    public partial class frmDangNhap : Form
    {
        private DataTable dt;
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            dt = NhanVienService.LoadDataTable();
            tedTenDangNhap.Focus();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (tedTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền tên đăng nhập!");
                tedTenDangNhap.Focus();
                return;
            }
            if (tedMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền mật khẩu!");
                tedTenDangNhap.Focus();
                return;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].Field<string>("TenDangNhap") == tedTenDangNhap.Text && ProjectUltil.Decrypt(dt.Rows[i].Field<string>("MatKhau")) == tedMatKhau.Text)
                {
                    MessageBox.Show("Đăng nhập thành công!\nXin chào " + dt.Rows[i].Field<string>("HoTen") + "....");
                    ProjectUltil.MaNhanVien = dt.Rows[i].Field<string>("MaNhanVien");
                    ProjectUltil.HoTenNhanVien = dt.Rows[i].Field<string>("HoTen");
                    ProjectUltil.MaChucVu = dt.Rows[i].Field<int>("MaChucVu");
                    btnThoat.PerformClick();
                    return;
                }
            }
            MessageBox.Show("Đăng nhập thất bại!");
        }
        private void cbtShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtShowPass.Checked)
            {
                tedMatKhau.Properties.PasswordChar = '\0';
            }
            else
            {
                tedMatKhau.Properties.PasswordChar = '●';
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void tedMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }
    }
}
