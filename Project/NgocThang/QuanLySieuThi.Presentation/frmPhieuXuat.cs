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
            f.ShowDialog();
        }
    }
}
