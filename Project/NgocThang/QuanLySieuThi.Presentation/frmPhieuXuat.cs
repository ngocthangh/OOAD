using DevExpress.XtraEditors;
using QuanLySieuThi.DataBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi.Presentation
{
    public partial class frmPhieuXuat : XtraForm
    {
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            grcPhieuXuat.DataSource = PhieuXuatService.LoadDataTable();
        }

        private void btnLapPhieuXuat_Click(object sender, EventArgs e)
        {
            frmPhieuXuatThemSua f = new frmPhieuXuatThemSua();
            f.FormClosing += new FormClosingEventHandler(Reload);
            f.ShowDialog();
        }
        private void Reload(object sender, FormClosingEventArgs e)
        {
            frmPhieuXuatThemSua f = (frmPhieuXuatThemSua)sender;
            if (f.isDataChanged == true)
            {
                 grcPhieuXuat.DataSource = PhieuXuatService.LoadDataTable();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {

        }
    }
}
