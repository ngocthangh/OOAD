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
using DevExpress.XtraEditors;

namespace QuanLySieuThi.Presentation
{
    public partial class FrmChucVu : Form
    {
        public FrmChucVu()
        {
            
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var dtChucVu = grcChucVu.DataSource as DataTable;
            
            if (dtChucVu == null || dtChucVu.GetChanges() == null) return;
            if(ChucVuService.SaveChanges(dtChucVu))
            {
                XtraMessageBox.Show("Lưu thành công", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grcChucVu.DataSource = ChucVuService.LoadDataTable();
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmChucVu_Load(object sender, EventArgs e)
        {
            var dt = ChucVuService.LoadDataTable();
            grcChucVu.DataSource = dt;

        }

        private void CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if(e.Info.IsRowIndicator&&e.RowHandle>=0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc xóa dòng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)!=DialogResult.Yes)
            return;
            gridView1.DeleteSelectedRows();
            
        }

        private void frmNhaCungCap_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dt = grcChucVu.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;
            if (
                XtraMessageBox.Show("Bạn có muốn lưu những thay đổi không?", "Thoát", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!ChucVuService.SaveChanges(dt.GetChanges()))
                {
                    XtraMessageBox.Show("Lưu thất bại", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
           
        }
    }
}
