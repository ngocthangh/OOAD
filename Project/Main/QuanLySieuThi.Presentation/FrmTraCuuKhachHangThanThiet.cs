using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.DataBussiness;

namespace QuanLySieuThi.Presentation
{
    public partial class FrmTraCuuKhachHangThanThiet : Form
    {
        public FrmTraCuuKhachHangThanThiet()
        {
            InitializeComponent();
        }

        private void txtKHTTSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string key = txtKHTTSearch.Text;
                if (key.Trim() != "")
                {
                    grcKHTTSearch.DataSource = KhachHangThanThietService.Search(key);
                }
                else
                {
                    grcKHTTSearch.DataSource = KhachHangThanThietService.LoadDataTable();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtKHTTSearch.Text;
            if (key.Trim() != "")
            {
                grcKHTTSearch.DataSource = KhachHangThanThietService.Search(key);
            }
            else
            {
                grcKHTTSearch.DataSource = KhachHangThanThietService.LoadDataTable();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmKhachHangThanThiet f = new frmKhachHangThanThiet();
            f.ShowDialog();
            grcKHTTSearch.DataSource = KhachHangThanThietService.LoadDataTable();
        }

        private void FrmTraCuuKhachHangThanThiet_Load(object sender, EventArgs e)
        {
            grcKHTTSearch.DataSource = KhachHangThanThietService.LoadDataTable();
        }

        private void grvTraCuuKHTT_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
             if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
