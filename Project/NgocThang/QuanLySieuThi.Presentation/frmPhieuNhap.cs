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
    public partial class frmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            grcPhieuNhap.DataSource = PhieuNhapService.LoadDataTable();
        }

        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            frmPhieuNhapThemSua f = new frmPhieuNhapThemSua();
            f.FormClosing += new FormClosingEventHandler(Reload);
            f.ShowDialog();
        }

        private void Reload(object sender, FormClosingEventArgs e)
        {
            frmPhieuNhapThemSua f = (frmPhieuNhapThemSua)sender;
            if (f.isDataChanged == true)
            {
                grcPhieuNhap.DataSource = PhieuNhapService.LoadDataTable();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
